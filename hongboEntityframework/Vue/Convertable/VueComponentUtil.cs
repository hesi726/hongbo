using hongbao.CollectionExtension;
using hongbao.Vue.Attributes;
using hongbao.Vue.Convertable;
using hongbao.Vue.Enums;
using hongbaoStandardExtension.CollectionExtension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hongbao.Vue.Attributes
{
    /// <summary>
    /// 组件的工具类;
    /// 给定一个类，获取该类的三个属性列表：
    /// a. 用于显示在 ELTable 中的 AbstractPropertyComponentAttribute 数组定义 
    /// b. 用于过滤数据的 AbstractPropertyComponentAttribute 数组定义 ( 默认下，对于 Name 和 CreateDatetime 总是具有过滤条件，
    ///         但是对于所有的其他列，必须显示定义有 
    /// c. 用于编辑数据的 AbstractPropertyComponentAttribute 数组定义  
    /// </summary>
    public static class VueComponentUtil
    {
        #region 辅助函数
        /// <summary>
        /// 判断给定 property 是否存在 AbstractPropertyComponentAttribute标注且标注中 componentSchema为 给定schema 的 标注,
        /// 如果存在此标注，还判断权限是否包含给定标注的权限，如果包含，则返回此标注；
        /// 如果存在多个符合的标注，则返回匹配  componentSchema为 给定schema 的所有标注;
        /// 否则，返回 null；        
        /// </summary>
        static IEnumerable<PropertyAndVuecompontAttribute> getPropertyWithAttributeFunc(PropertyInfo prop, 
            EnumComponentSchema schema,
            Func<ILimitAttribute, bool> filterPropertyAndComponentFunc)
        {
            if (filterPropertyAndComponentFunc == null) filterPropertyAndComponentFunc = (c) => true;
            Func<AbstractPropertyComponentAttribute, bool> filterFunc = (c) =>
                            (c.componentSchema == EnumComponentSchema.FilterAndEditAndList || c.componentSchema == schema || ((c.componentSchema & schema) > 0)) &&
                             filterPropertyAndComponentFunc(c);
            var propAttributes = prop.GetCustomAttributes<AbstractPropertyComponentAttribute>(true).ToList();  //
           

            // 获取到的标注中，如果子类和父类对同一个属性同时定义有标注，子类定义的标注在前，父类定义的标注在后；
            //麻烦的是 如果获取 父类中定义的 标注，则可能获取到多个标注； （例如， Name 同时在 OA_Role 和 父类: IdAndNameAndCreateDatetimeEntity 中定义了标注)
            //如果不获取父类中定义的标注，则某一个属性在子类中未定义标注时，标注就无法获取到；( OA_User 无法获取到 父类父类: IdAndNameAndCreateDatetimeEntity 中定义的标注)
            //另外，可能对于同一个属性会定有多个标注; 
            var result = propAttributes.Where(filterFunc)
                .OrderBy(c => c.componentSchema == schema ? 0 : 1)
                .Select(attr => new PropertyAndVuecompontAttribute(prop, attr)).ToList();
            IListExtension.ReverseForEach(result, (item, index) =>
            {                
                //移走相同属性的，
                var sameItemIndex = result.FindIndex((xitem) => 
                    item.VueComponentAttribute.propertyPath == xitem.VueComponentAttribute.propertyPath);
                if (sameItemIndex < index)
                {
                    propAttributes.RemoveAt(index);
                }
            });
            return result;
        }
        /// <summary>
        /// 类型的属性在未定义访问标注时，默认下是 允许还是禁止 编辑、列表，
        /// 如果类上有 ClassPropertyDefaultAttribute 标注，则返回 ClassPropertyDefaultAttribute 标注;        
        /// 否则，返回 ClassPropertyDenyAccessAttribute (类的属性默认禁止访问);
        /// </summary>
        /// <param name="type"></param>
        static ClassPropertyDefaultAttribute GetPropertyDefaultCanAccess(Type type)
        {
            var attr = type.GetCustomAttribute<ClassPropertyDefaultAttribute>();
            if (attr == null)
            {
              return new ClassPropertyDefaultAttribute(EnumClassPropertyEntityOperate.DenyEditAndList);
            }
            return attr;
        }
        #endregion

        #region 根据类获取 PropertyInfo 对应的列表、编辑以及过滤定义


        /// <summary>
        /// 获取类上可访问的属性以及VueComponent标注;
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="filterPropertyAndComponentFunc"></param>
        /// <param name="schema"></param>
        /// <returns></returns>
        private static List<PropertyAndVuecompontAttribute> GetPropertyAndVueComponentList(Type entityType,
            EnumComponentSchema schema,
            Func<ILimitAttribute, bool> filterPropertyAndComponentFunc)
        {
            var propDefaultListAndEdit = GetPropertyDefaultCanAccess(entityType);
            List<PropertyAndVuecompontAttribute> propertyComponentAttributeEnum = new List<PropertyAndVuecompontAttribute>();
            if (propDefaultListAndEdit.DefaultPropertyEntityOperate == EnumClassPropertyEntityOperate.AllowEditAndList)
            //属性未定义 PropertyDenyListAttribute 和 PropertyDenyListAndEditAttribute 标注时,即显示在列表中
            {
                entityType.GetProperties()
                   .Where(a =>  (schema == EnumComponentSchema.List || a.CanWrite) 
                     && a.GetCustomAttribute<PropertyDenyListAttribute>() == null
                     && a.GetCustomAttribute<PropertyDenyListAndEditAttribute>() == null)
                   .ForEach(prop =>
                   {
                       var props = getPropertyWithAttributeFunc(prop, schema, filterPropertyAndComponentFunc);
                       propertyComponentAttributeEnum.AddRange(props);
                   });
            }
            else
            {
                //属性必须要定义有 componentSchema=EnumComponentSchema.List 的标注时, 显示在列表中
                entityType.GetProperties().ForEach(a =>
                    {
                        var enums = getPropertyWithAttributeFunc(a, schema, filterPropertyAndComponentFunc);
                        propertyComponentAttributeEnum.AddRange(enums.Where(b => b.VueComponentAttribute != null));
                    });                   
            }

            return propertyComponentAttributeEnum;
        }

        

        /// <summary>
        /// 获取某一个类中 包含有 componentSchema=EnumComponentSchema.Filter 的标注的 PropertyInfo 数组
        /// </summary>
        /// <returns></returns>
        public static List<AbstractPropertyComponentAttribute> GetFilterablePropertyList(
             Type entityType,
             Func<PropertyInfo, bool> filterPropertyFunc,
             Func<ILimitAttribute, bool> filterPropertyAndComponentFunc
             )
        {
            if (filterPropertyFunc == null) filterPropertyFunc = (prop) => true;
            if (entityType.GetCustomAttribute<ClassDenyFilterAttribute>() != null)  //类禁止过滤;
            {
                return new List<AbstractPropertyComponentAttribute>();
            }
            List<PropertyAndVuecompontAttribute> propertyComponentAttributeEnum = new List<PropertyAndVuecompontAttribute>();
            //属性定义 componentSchema为 Filter的 标注时, 即显示在过滤条件中
            entityType.GetProperties().Where(filterPropertyFunc) //过滤属性;
                        .ForEach(b =>
                        {
                            if (b.Name == "Name" || b.Name == "CreateDateTime")
                            {
                                propertyComponentAttributeEnum.AddRange(getPropertyWithAttributeFunc(b, EnumComponentSchema.Filter, filterPropertyAndComponentFunc));
                            }
                            else
                            {
                                var enums = getPropertyWithAttributeFunc(b, EnumComponentSchema.Filter, filterPropertyAndComponentFunc)
                                     .Where(c => c.VueComponentAttribute != null);
                                propertyComponentAttributeEnum.AddRange(enums);
                            }
                        });
            return ConvertToClientVueComponentAttribute(entityType, propertyComponentAttributeEnum, EnumComponentSchema.Filter);
        }
        /// <summary>
        /// 获取某一个类在用于在导出时显示的列定义
        /// </summary>
        /// <returns></returns>
        public static List<AbstractPropertyComponentAttribute> GetExportablePropertyList(Type entityType,
             Func<PropertyInfo, bool> filterFunc,
             Func<ILimitAttribute, bool> filterPropertyAndComponentFunc
            )
        {
            if (filterFunc == null) filterFunc = (prop) => true;
            if (entityType.GetCustomAttribute<ClassDenyListAttribute>() != null)  //类禁止在列表中显示
            {
                return new List<AbstractPropertyComponentAttribute>();
            }
            IEnumerable<PropertyAndVuecompontAttribute> propertyComponentAttributeEnum =
                    GetPropertyAndVueComponentList(entityType, EnumComponentSchema.Export, filterPropertyAndComponentFunc)
                    .Where(a => filterFunc(a.Property));
            return ConvertToClientVueComponentAttribute(entityType, propertyComponentAttributeEnum, EnumComponentSchema.List);
        }

        /// <summary>
        /// 获取某一个类在用于在列表中显示的列定义
        /// </summary>
        /// <returns></returns>
        public static List<AbstractPropertyComponentAttribute> GetColumnablePropertyList(Type entityType, 
             Func<PropertyInfo, bool> filterFunc,
             Func<ILimitAttribute, bool> filterPropertyAndComponentFunc
            )
        {
            if (filterFunc == null) filterFunc = (prop) => true;
            if (entityType.GetCustomAttribute<ClassDenyListAttribute>() != null)  //类禁止在列表中显示
            {
                return new List<AbstractPropertyComponentAttribute>();
            }
            var  propertyComponentAttributeEnum =
                    GetPropertyAndVueComponentList(entityType, EnumComponentSchema.List, filterPropertyAndComponentFunc)
                    .Where(a => filterFunc(a.Property)).ToList();
            return ConvertToClientVueComponentAttribute(entityType, propertyComponentAttributeEnum, EnumComponentSchema.List);
        }

       
        /// <summary>
        /// 获取某一个类在用于编辑的列定义
        /// </summary>
        /// <returns></returns>
        public static List<AbstractPropertyComponentAttribute> GetEditablePropertyList(Type entityType,
             Func<PropertyInfo, bool> filterFunc,
             Func<ILimitAttribute, bool> filterPropertyAndComponentFunc)
        {
            if (filterFunc == null) filterFunc = (prop) => true;
            if (entityType.GetCustomAttribute<ClassDenyEditAttribut>() != null)  //类禁止编辑
            {
                return new List<AbstractPropertyComponentAttribute>();
            }
            IEnumerable<PropertyAndVuecompontAttribute> propertyComponentAttributeEnum =  GetPropertyAndVueComponentList(entityType, EnumComponentSchema.Edit, filterPropertyAndComponentFunc)
                    .Where(a=> a.Property.CanWrite && filterFunc(a.Property));
            return ConvertToClientVueComponentAttribute(entityType, propertyComponentAttributeEnum, EnumComponentSchema.Edit);
        }
        #endregion

        #region 根据 Type, Property, AbstractPropertyComponentAttribut  计算用于在客户端展现的 AbstractPropertyComponentAttribut


        /// <summary>
        /// 根据 Type, IEnumerable&lt;(Property, AbstractPropertyComponentAttribut)&gt; 进行如下操作：
        /// a. 填充 AbstractPropertyComponentAttribut.label 
        /// b. 当 componentAttr.componentType == EnumComponentType.Auto 时，需要根据 PropertyInfo 转换为 客户端Vue组件类型;
        /// 返回转换后的 客户端Vue组件列表
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="propertyComponentAttrEnum"></param>
        /// <param name="schema"></param>
        /// <returns></returns>
        private static List<AbstractPropertyComponentAttribute> ConvertToClientVueComponentAttribute(Type entityType,
                IEnumerable<PropertyAndVuecompontAttribute> propertyComponentAttrEnum,
                EnumComponentSchema schema)
        {
            return propertyComponentAttrEnum
                    .Select(a => ConvertToClientVueComponentAttribute(entityType, a.Property, a.VueComponentAttribute, schema))
                    .Where(a=> a!=null)
                    .OrderBy(a=> a.serial)
                    .ToList();
        }

        /// <summary>
        /// 根据 Type, Property, AbstractPropertyComponentAttribut 进行如下操作：
        /// a. 填充 AbstractPropertyComponentAttribut.label 
        /// b. 当 componentAttr.componentType == EnumComponentType.Auto 时，需要根据 PropertyInfo 转换为具体的 组件类型;
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="property"></param>
        /// <param name="componentAttr"> 为null时表示自动构建  </param>
        /// <param name="schema"></param>
        /// <returns></returns>
        private static AbstractPropertyComponentAttribute ConvertToClientVueComponentAttribute(Type entityType, 
                PropertyInfo property, 
                AbstractPropertyComponentAttribute componentAttr,
                EnumComponentSchema schema)
        {
            var inputComponentAttr = componentAttr;
            componentAttr.property = property;
            if (componentAttr == null || componentAttr.componentType == EnumComponentType.auto)  //为空或者自动
            {
                var name = property.Name;

                if (name == "Id" || name == "Xid" || name == "Guid" || name=="LastModifyDateTime")   //这些列不可编辑,不可过滤，也不会显示在列表中;                
                {
                    return null;
                }
                if (schema == EnumComponentSchema.Edit && 
                    (name=="CreateDateTime" || name == "LastModifyDateTime"))
                {
                    return null;
                }
                
                var propertyType = property.PropertyType;
                Type innerType = propertyType;
                if (propertyType.IsGenericType) innerType = propertyType.GenericTypeArguments[0];
                AbstractConvertable convertible = null;
                if (propertyType == typeof(string)) convertible = new StringConvertable(entityType, property);
                else if (propertyType == typeof(DateTime) || innerType == typeof(DateTime)) convertible = new DatetimeConvertable(entityType, property);
                else if (propertyType.IsEnum || innerType.IsEnum) convertible = new EnumConvertable(entityType, property);
                else if (propertyType == typeof(Int32) || innerType == typeof(Int32)) convertible = new IntConvertable(entityType, property);
                else if (propertyType == typeof(Int64) || innerType == typeof(Int64)) convertible = new Int64Convertable(entityType, property);
                else if (propertyType == typeof(decimal) || innerType == typeof(decimal)) convertible = new DecimalConvertable(entityType, property);
                else if (propertyType == typeof(Boolean) || innerType == typeof(Boolean)) convertible = new BoolConvertable(entityType, property);
                else convertible = new StringConvertable(entityType, property);  //默认使用字符串转换类型;
                /*{
                    throw new Exception("不支持的类型转换: (");
                }*/
                if (componentAttr != null)
                {
                    if (property.Name == "CreateUserId")
                    {
                        componentAttr.width = "80";
                    }
                    if (property.Name == "CreateDateTime")
                    {
                        componentAttr.width = "160";
                    }
                    if (property.Name == "Name")
                    {
                        componentAttr.width = "180";
                    }
                }
                if (schema == EnumComponentSchema.Filter)
                {                    
                    componentAttr = convertible.ConvertToFilterVueComponentAttribute(entityType, property);
                }
                else if (schema == EnumComponentSchema.Edit)
                {
                    componentAttr = convertible.ConvertToClientEditVueComponentAttribute(entityType, property);
                }
                else if (schema == EnumComponentSchema.List)
                {
                    componentAttr = convertible.ConvertToClientTableColumnVueComponentAttribute(entityType, property);
                    
                }
            }
            if (componentAttr != null)
            {
                if (property.Name == "CreateUserId" && componentAttr.serial == 0)
                {
                    componentAttr.serial = 999;
                }
                if (property.Name == "CreateDateTime" && componentAttr.serial == 0)
                {
                    componentAttr.serial = 1000;
                }
                if (property.Name == "Name" && componentAttr.serial == 0)
                {
                    componentAttr.serial = -1;
                }
                CopyPropertyInAttributeDefine(componentAttr, inputComponentAttr);
            }
            return componentAttr;
        }

        /// <summary>
        /// 复制在组件上定义的标注的属性到 自动创建的 标注对象上，避免自动创建的标注对象丢失了属性;
        /// </summary>
        /// <param name="autoCreateOrOriginalAttr">自动创建的标注实例或者原始标注实例</param>
        /// <param name="attrDefineInProperty">在 属性 上定义的原始标注 实例</param>
        private static void CopyPropertyInAttributeDefine(AbstractPropertyComponentAttribute autoCreateOrOriginalAttr, 
            AbstractPropertyComponentAttribute attrDefineInProperty)
        {
            if (autoCreateOrOriginalAttr.label==null)
            {
                autoCreateOrOriginalAttr.label = GetDisplay(attrDefineInProperty.property);
            }
            if (autoCreateOrOriginalAttr == attrDefineInProperty) return;
            autoCreateOrOriginalAttr.property = attrDefineInProperty.property;            
            if (attrDefineInProperty != null)
            {
                autoCreateOrOriginalAttr.serial = attrDefineInProperty.serial;
                autoCreateOrOriginalAttr.limitRequestEntityType = attrDefineInProperty.limitRequestEntityType;
                autoCreateOrOriginalAttr.showCondition = attrDefineInProperty.showCondition;
                autoCreateOrOriginalAttr.showConditionValue = attrDefineInProperty.showConditionValue;
                autoCreateOrOriginalAttr.anyPrivilege = attrDefineInProperty.anyPrivilege;
                autoCreateOrOriginalAttr.allPrivilege = attrDefineInProperty.allPrivilege;
                autoCreateOrOriginalAttr.inline = attrDefineInProperty.inline;
                autoCreateOrOriginalAttr.editspan = attrDefineInProperty.editspan;
                autoCreateOrOriginalAttr.sortable = attrDefineInProperty.sortable;
                autoCreateOrOriginalAttr.sortableProperty = attrDefineInProperty.sortableProperty;
                autoCreateOrOriginalAttr.userType = attrDefineInProperty.userType;

                if (!string.IsNullOrEmpty(attrDefineInProperty.propertyPath))  //自动创建的 AbstractPropertyComponentAttribute 可能会设置 propertyPath
                {
                    autoCreateOrOriginalAttr.propertyPath = attrDefineInProperty.propertyPath;
                }
                if (!string.IsNullOrEmpty(attrDefineInProperty.width)) //自动创建的 AbstractPropertyComponentAttribute 可能会设置 width
                {
                    autoCreateOrOriginalAttr.width = attrDefineInProperty.width;
                }
                if (!string.IsNullOrEmpty(attrDefineInProperty.label)) //自动创建的 AbstractPropertyComponentAttribute 可能会设置 label
                {
                    autoCreateOrOriginalAttr.label = attrDefineInProperty.label;
                }
            }
        }

        /// <summary>
        /// 获取属性的DisplayName标注的名称;
        /// 也可能通过备注获取备注的属性;
        /// </summary>
        /// <returns></returns>
        private static string GetDisplay(PropertyInfo property)
        {
            var display = property.GetCustomAttribute<DisplayAttribute>();
            if (display != null) return display.Name;
            var displayName = property.GetCustomAttribute<DisplayNameAttribute>();
            if (displayName != null) return displayName.DisplayName;
            if (property.Name == "Remark")
            {
                return "备注";
            }
            return property.Name;
        }
        #endregion
    }

    /// <summary>
    /// PropertyInfo 以及其上的 VueComponent 标注;
    /// </summary>
    public class PropertyAndVuecompontAttribute
    {
       
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="prop"></param>
        /// <param name="attr"></param>
        public PropertyAndVuecompontAttribute(PropertyInfo prop, AbstractPropertyComponentAttribute attr)
        {
            this.Property = prop;
            this.VueComponentAttribute = attr;
        }

        /// <summary>
        /// PropertyInfo 
        /// </summary>
        public PropertyInfo Property { get; set; }

        /// <summary>
        /// VueComponent标注，可能为null;
        /// </summary>
        public AbstractPropertyComponentAttribute VueComponentAttribute { get; set; }
    }
}
