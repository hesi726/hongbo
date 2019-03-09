using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hongboExtension.test
{
    public class Person
    {
        /// <summary>
        /// 测试的人员列表;
        /// </summary>
        public static List<Person> personList = new List<Person>
        {
            new Person { Id = 1, Name = "A", Age= 18, Sex = EnumSex.Male},
            new Person { Id = 2, Name = "B", Age= 19, Sex = EnumSex.Male},
            new Person { Id = 3, Name = "C", Age= 20, Sex = EnumSex.Female},
            new Person { Id = 14,Name = "D", Age= 21 , Child = true, UpperIds = ",2," },
        };
        public static IQueryable<Person> entityQueryable = personList.AsQueryable();

        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public EnumSex? Sex { get; set; }

        public bool Child { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string UpperIds { get; set; }
    }



    public enum EnumSex
    {
        Male,
        Female
    }
}
