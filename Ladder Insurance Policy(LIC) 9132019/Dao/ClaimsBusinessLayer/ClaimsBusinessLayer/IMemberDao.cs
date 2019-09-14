using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDataLayer;

namespace ClaimsBusinessLayer
{
    interface IMemberDao
    {
        bool RegisterMember(Member member);
        int  LoginMember(string emailId, string password);

        bool ApproveMember(int memberId, string active);

        List<Member> GetMemberList();

        Member GetMemberById(int memberId);
    }
}
