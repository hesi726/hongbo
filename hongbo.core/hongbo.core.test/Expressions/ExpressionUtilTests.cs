using Microsoft.VisualStudio.TestTools.UnitTesting;
using hongbao.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using hongboExtension.test;

namespace hongbao.Expressions.Tests
{
    [TestClass()]
    public class ExpressionUtilTests
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        public void And_Multi()
        {
            System.Linq.Expressions.Expression<Func<Person, bool>> exp1 = (person) => person.Id == 1;
            Expression < Func < Person, bool>> exp2 = (person) => person.Name == "A";
            Expression < Func < Person, bool>> exp3 = (person) => person.Age == 18;

            var lambda = ExpressionUtil.And(exp1, exp2, exp3);
            Assert.IsNotNull(Person.entityQueryable.FirstOrDefault(lambda));


            Expression<Func<Person, bool>> exp4 = (person) => person.Age == 20;
            lambda = ExpressionUtil.And(exp1, exp2, exp4);
            Assert.IsNull(Person.entityQueryable.FirstOrDefault(lambda));
        }


        /// <summary>
        /// 
        /// </summary>
        [TestMethod()]
        public void ExpressionUtil_CreateEqualsLambda()
        {
            var lambda = ExpressionUtil.CreateEqualLambda<Person, string>("Name", "A");
            Assert.IsNotNull(Person.entityQueryable.FirstOrDefault(lambda));

            lambda = ExpressionUtil.CreateEqualLambda<Person>("Name", "A");
            Assert.IsNotNull(Person.entityQueryable.FirstOrDefault(lambda));

            lambda = ExpressionUtil.CreateEqualLambda<Person>("Sex", EnumSex.Female);
            Assert.IsNotNull(Person.entityQueryable.FirstOrDefault(lambda));

            lambda = ExpressionUtil.CreateEqualLambda<Person>("Sex", null);
            Assert.IsNotNull(Person.entityQueryable.FirstOrDefault(lambda));

            lambda = ExpressionUtil.CreateEqualLambda<Person>("Child", true);
            Assert.IsNotNull(Person.entityQueryable.FirstOrDefault(lambda));
        }



        [TestMethod()]
        public void ExpressionUtil_GetMultiOrConditionExpression()
        {
            var options = new string[] { "A", "B" };
            var expression = ExpressionUtil.GetMultiOrConditionExpression<Person>(options, "Name");
            var result = Person.entityQueryable.Where(expression).ToList();
            Assert.IsTrue(result.Count == 2);

            var ageOptions = new string[] { "18", "19" };
            expression = ExpressionUtil.GetMultiOrConditionExpression<Person>(ageOptions, "Age");
            result = Person.entityQueryable.AsQueryable().Where(expression).ToList();
            Assert.IsTrue(result.Count == 2);

            var sexOptions = new object[] { EnumSex.Male, EnumSex.Female };
            var sexExpression = ExpressionUtil.GetMultiOrConditionExpression<Person>(sexOptions, "Sex");
            Expression<Func<Person, bool>> myexp = (p) => ((p.Sex != null) && (p.Sex.Value == EnumSex.Male)) ||
                                                                ((p.Sex != null) && (p.Sex.Value == EnumSex.Female));
            var myExpFunc = myexp.Compile();

            var compileFunc = sexExpression.Compile();
            var sexResultWithCompileFunc = Person.entityQueryable.Where(compileFunc).ToList();

            var sexResult = Person.entityQueryable.AsQueryable().Where(sexExpression).ToList();
            Assert.IsTrue(sexResult.Count == 3);
        }

        [TestMethod()]
        public void ExpressionUtil_CreateBetween()
        {
           var expression = ExpressionUtil.CreateBetweenLambda<Person>("age", 18.ToString(), 19.ToString());
           var result = Person.entityQueryable.AsQueryable().Where(expression).ToList();
           Assert.IsTrue(result.Count == 2);

            expression = ExpressionUtil.CreateBetweenLambda<Person>("age", 18, 19);
            result = Person.entityQueryable.AsQueryable().Where(expression).ToList();
            Assert.IsTrue(result.Count == 2);

            expression = ExpressionUtil.CreateBetweenLambda<Person>("age", 18, null);
            result = Person.entityQueryable.AsQueryable().Where(expression).ToList();
            Assert.IsTrue(result.Count == 4);

            expression = ExpressionUtil.CreateBetweenLambda<Person>("age", 18, "");
            result = Person.entityQueryable.AsQueryable().Where(expression).ToList();
            Assert.IsTrue(result.Count == 4);
        }
    }
     
   
}