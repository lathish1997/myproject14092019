using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsBusinessLayer
{
    public class Queries
    {
        public static string registerMember = "insert into [member](firstname,lastname,age,gender,dob,contactnumber,altcontactnumber,emailid,password,plancodeid,memberplanid,addressline1,addressline2,city,state,zipcode,active) values(@firstname,@lastname,@age,@gender,@dob,@contactnumber,@altcontactnumber,@emailid,@password,@plancodeid,@memberplanid,@addressline1,@addressline2,@city,@state,@zipcode,@active)";
        public static string loginMember = "select emailid,password from [member]";
        public static string approveMember = "update [member] set active=@active where memberid=@id";
        public static string getDataMember = "select * from [member];";
        public static string getMemberById = "select * from [member] where memberid = @id;";

        public static string registerAdmin = "insert into [admin](firstname,lastname,age,gender,dob,contactnumber,altcontactnumber,emailid,active) values(@firstname,@lastname,@age,@gender,@dob,@contactnumber,@altcontactnumber,@emailid,@active)";
        public static string loginAdmin = "select emailid,password from [admin]";
        public static string approveAdmin = "update [admin] set active=@active where adminid=@adminid";        
        public static string getAdmin = "select * from [admin];";
        public static string getAdminById = "select * from [admin] WHERE adminid = @adminid";

        public static string addPlan = "insert into [plancode](plandescription,coverage1,coverage2,coverage3,coverage4,coverage5) values(@plandescription,@coverage1,@coverage2,@coverage3,@coverage4,@coverage5)";
        public static string removePlan = "delete from [plancode] where plancodeid=@plancodeid";
        public static string viewPlan = "select * from plancode";
        public static string editPlan = "update [plancode] set plandescription=@plandescription,coverage1=@coverage1,coverage2=@coverage2,coverage3=@coverage3,coverage4=@coverage4,coverage5=@coverage5";
        
    }
}
