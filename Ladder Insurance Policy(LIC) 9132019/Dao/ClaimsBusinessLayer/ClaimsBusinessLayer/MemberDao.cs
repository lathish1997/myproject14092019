using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimsDataLayer;
using System.Data.SqlClient;
using System.Data;

namespace ClaimsBusinessLayer
{
    public class MemberDao : IMemberDao
    {
        static string callConnection = ConnectionHandler.ConnectionVariable;
        public bool ApproveMember(int memberId, string active)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.approveMember
                };
                
                command.Parameters.Add(Constants.atMemberActive, SqlDbType.VarChar).Value = active;
                command.Parameters.Add(Constants.atMemberId, SqlDbType.Int).Value = memberId;

                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            }
        

        public Member GetMemberById(int memberId)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.getMemberById
                };

                command.Parameters.Add(Constants.atMemberId, SqlDbType.Int).Value = memberId;

                SqlDataReader dataReader = command.ExecuteReader();
                Member member = new Member();

                while (dataReader.Read())
                {
                    member.MemberID= Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberId)));
                    member.FirstName= Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberFirstName)));
                    member.LastName = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberLastName)));
                    member.Age = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberAge)));
                    member.Gender = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberGender)));
                    member.Dob = Convert.ToDateTime(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberDob)));
                    member.ContactNumber = Convert.ToInt64(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberContactNumber)));
                    member.AltContactNumber = Convert.ToInt64(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberAltContactNumber)));
                    member.EmailId = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberEmailId)));
                    member.Password = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberPassword)));
                    member.PlanCodeId = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberPlanCodeId)));
                    member.MemberPlanId = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberPlanId)));
                    member.AddressLine1 = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberAddressLine1)));
                    member.AddressLine2 = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberAddressLine2)));
                    member.City = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberCity)));
                    member.State = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberState)));
                    member.ZipCode = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberZipCode)));
                    member.Active = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberActive)));
                    
                }
                return member;
            }
        }

       

        public int  LoginMember(string emailId, string password)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.loginMember
                };

                SqlDataReader dataReader = command.ExecuteReader();
                int i = 0;
                while (dataReader.Read())
                {
                    if (
                        Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberId))) == emailId &&
                        Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberPassword))) == password
                        && Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberActive))).Equals(Constants.valueYes, StringComparison.InvariantCultureIgnoreCase)
                      )
                    {
                        i = 1;
                        break;
                    }
                    else if (
                        Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberId))) == emailId &&
                        Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberPassword))) == password
                        && Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberActive))).Equals(Constants.valueNo, StringComparison.InvariantCultureIgnoreCase)
                      )
                    {
                        i = 2;
                        break;
                    }
                    else
                    {
                        i = 0;
                    }
                }
                return i;
            }
        }

        public bool RegisterMember(Member member)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.registerMember
                };

                command.Parameters.Add(Constants.atMemberFirstName, SqlDbType.VarChar).Value = member.FirstName;
                command.Parameters.Add(Constants.atMemberLastName, SqlDbType.VarChar).Value = member.LastName;
                command.Parameters.Add(Constants.atMemberAge, SqlDbType.Int).Value = member.Age;
                command.Parameters.Add(Constants.atMemberGender, SqlDbType.VarChar).Value =member.Gender;
                command.Parameters.Add(Constants.atMemberDob, SqlDbType.Date).Value = member.Dob;
                command.Parameters.Add(Constants.atMemberContactNumber, SqlDbType.BigInt).Value = member.ContactNumber;
                command.Parameters.Add(Constants.atMemberAltcontactNumber, SqlDbType.BigInt).Value = member.AltContactNumber;
                command.Parameters.Add(Constants.atMemberEmailId, SqlDbType.VarChar).Value = member.EmailId;
                command.Parameters.Add(Constants.atMemberPassword, SqlDbType.VarChar).Value = member.Password;
                command.Parameters.Add(Constants.atMemberPlanCodeId, SqlDbType.Int).Value = member.PlanCodeId;
                command.Parameters.Add(Constants.atMemberPlanId, SqlDbType.Int).Value = member.MemberPlanId;
                command.Parameters.Add(Constants.atMemberAddressLine1, SqlDbType.VarChar).Value = member.AddressLine1;
                command.Parameters.Add(Constants.atMemberAddressLine2, SqlDbType.Int).Value = member.AddressLine2;
                command.Parameters.Add(Constants.atMemberCity, SqlDbType.VarChar).Value = member.City;
                command.Parameters.Add(Constants.atMemberState, SqlDbType.Int).Value = member.State;
                command.Parameters.Add(Constants.atMemberZipCode, SqlDbType.VarChar).Value = member.ZipCode;
                command.Parameters.Add(Constants.atMemberActive, SqlDbType.Int).Value =Constants.valueNo;


                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }



        public List<Member> GetMemberList()
        {
            List<Member> memberList = new List<Member>();

            int count = 0;
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText =Queries.getDataMember
                };

                SqlDataReader dataReader = command.ExecuteReader();
                Member member = new Member();
                while (dataReader.Read())
                {
                    member.MemberID = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberId)));
                    member.FirstName = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberFirstName)));
                    member.LastName = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberLastName)));
                    member.Age = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberAge)));
                    member.Gender = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberGender)));
                    member.Dob = Convert.ToDateTime(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberDob)));
                    member.ContactNumber = Convert.ToInt64(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberContactNumber)));
                    member.AltContactNumber = Convert.ToInt64(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberAltContactNumber)));
                    member.EmailId = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberEmailId)));
                    member.Password = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberPassword)));
                    member.PlanCodeId = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberPlanCodeId)));
                    member.MemberPlanId = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberPlanId)));
                    member.AddressLine1 = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberAddressLine1)));
                    member.AddressLine2 = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberAddressLine2)));
                    member.City = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberCity)));
                    member.State = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberState)));
                    member.ZipCode = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberZipCode)));
                    member.Active = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.memberActive)));
                    memberList.Add(member);
                    count++;
                }
                if(count==0)
                {
                    throw new NoMemberException();
                }
                return memberList;
            }
        }
    }
}
