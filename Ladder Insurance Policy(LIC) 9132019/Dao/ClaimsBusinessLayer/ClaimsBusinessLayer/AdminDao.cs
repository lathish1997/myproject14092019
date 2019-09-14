using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ClaimsDataLayer;


namespace ClaimsBusinessLayer
{
    public class AdminDao : IAdminDao
    {
        public static string callConnection = ConnectionHandler.ConnectionVariable;
        public bool ApproveAdmin(int adminId, string active)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.approveAdmin
                };

                command.Parameters.Add(Constants.atAdminId, SqlDbType.Int).Value = adminId;
                command.Parameters.Add(Constants.atAdminActive, SqlDbType.VarChar).Value = active;         

                int i = command.ExecuteNonQuery();
                bool result = false;
                if(i>0)
                {
                    result = true;
                }
                return result;
            }
        }

        public Admin GetAdminById(int adminId)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.getAdminById
                };

                command.Parameters.Add(Constants.atAdminId, SqlDbType.Int).Value = adminId;

                SqlDataReader dataReader = command.ExecuteReader();
                Admin admin = new Admin();

                while (dataReader.Read())
                {
                    admin.AdminID = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminId)));
                    admin.FirstName = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminFirstName)));
                    admin.LastName = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminLastName)));
                    admin.Age = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminAge)));
                    admin.Gender = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminGender)));
                    admin.Dob = Convert.ToDateTime(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminDob)));
                    admin.ContactNumber = Convert.ToInt64(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminContactNumber)));
                    admin.AltContactNumber = Convert.ToInt64(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminAltContactNumber)));
                    admin.EmailId = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminEmailId)));
                    admin.Active = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminActive)));

                }
                return admin;
            }
        }

        public List<Admin> GetAdminList()
        {
            List<Admin> adminList = new List<Admin>();


            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.getAdmin
                };

                SqlDataReader dataReader = command.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    Admin admin = new Admin();
                    admin.AdminID = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminId)));
                    admin.FirstName = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminFirstName)));
                    admin.LastName = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminLastName)));
                    admin.Age = Convert.ToInt32(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminAge)));
                    admin.Gender = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminGender)));
                    admin.Dob = Convert.ToDateTime(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminDob)));
                    admin.ContactNumber = Convert.ToInt64(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminContactNumber)));
                    admin.AltContactNumber = Convert.ToInt64(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminAltContactNumber)));
                    admin.EmailId = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminEmailId)));
                    admin.Active = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminActive)));

                    adminList.Add(admin);
                    count++;
                }
                if (count == 0)
                {
                    throw new NoAdminException();
                }
                return adminList;
            }
        }

        public int LoginAdmin(string emailId, string password)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.loginAdmin
                };

                SqlDataReader dataReader = command.ExecuteReader();
                int i = 0;
                while (dataReader.Read())
                {
                    if (
                        Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminEmailId))) == emailId &&
                        Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminPassword))) == password
                        && Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminActive))).Equals(Constants.valueYes, StringComparison.InvariantCultureIgnoreCase)
                      )
                    {
                        i = 1;
                        break;
                    }
                    else if (
                        Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminEmailId))) == emailId &&
                        Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminPassword))) == password
                        && Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.adminPassword))).Equals(Constants.valueNo, StringComparison.InvariantCultureIgnoreCase)
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

        public bool LoginSuperUser(string userId, string password)
        {
            if(userId.Equals(Constants.superUserId) && password.Equals(Constants.superUserPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RegisterAdmin(Admin admin)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.registerAdmin
                };

                command.Parameters.Add(Constants.atAdminFirstName, SqlDbType.VarChar).Value = admin.FirstName;
                command.Parameters.Add(Constants.atAdminLastName, SqlDbType.VarChar).Value = admin.LastName;
                command.Parameters.Add(Constants.atAdminAge, SqlDbType.Int).Value = admin.Age;
                command.Parameters.Add(Constants.atAdminGender, SqlDbType.VarChar).Value = admin.Gender;
                command.Parameters.Add(Constants.atAdminDob, SqlDbType.Date).Value = admin.Dob;
                command.Parameters.Add(Constants.atAdminContactNumber, SqlDbType.BigInt).Value = admin.ContactNumber;
                command.Parameters.Add(Constants.atAdminAltcontactNumber, SqlDbType.BigInt).Value = admin.AltContactNumber;
                command.Parameters.Add(Constants.atAdminEmailId, SqlDbType.VarChar).Value = admin.EmailId;
                command.Parameters.Add(Constants.atAdminPassword, SqlDbType.VarChar).Value = admin.Password;
                command.Parameters.Add(Constants.atAdminActive, SqlDbType.VarChar).Value = Constants.valueNo;

                int i = command.ExecuteNonQuery();
                bool result = false;
                if (i > 0)
                {
                    result = true;
                }
                return result;
            }
        }
    }
}
