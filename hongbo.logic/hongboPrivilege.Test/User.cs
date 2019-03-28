using hongbao.privileges;
using System;
using System.Collections.Generic;
using System.Text;

namespace hongboPrivilege.Test
{

    [ClassAllowModify(TestConst.Privilege_UserModify)]
    [ClassAllowQuery(TestConst.Privilege_UserQuery)]
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
