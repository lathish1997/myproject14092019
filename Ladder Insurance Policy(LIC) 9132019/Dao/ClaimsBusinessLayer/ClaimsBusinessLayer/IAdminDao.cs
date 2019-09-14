using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDataLayer;

namespace ClaimsBusinessLayer
{
    interface IAdminDao
    {
        bool LoginSuperUser(string userId, string password);
        bool RegisterAdmin(Admin admin);
        int LoginAdmin(string emailId, string password);
        bool ApproveAdmin(int adminId, string active);
        List<Admin> GetAdminList();
        Admin GetAdminById(int adminId);
    }
}
