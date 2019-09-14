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
    class PlanCodeDao : IPlanCodeDao
    {
        public static string callConnection = ConnectionHandler.ConnectionVariable;
        public bool AddPlan(PlanCode planCode)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.addPlan
                };

                command.Parameters.Add(Constants.atPlanDescription, SqlDbType.VarChar).Value = planCode.PlanDescription;
                command.Parameters.Add(Constants.atCoverage1, SqlDbType.VarChar).Value = planCode.Coverage1;
                command.Parameters.Add(Constants.atCoverage2, SqlDbType.VarChar).Value = planCode.Coverage2;
                command.Parameters.Add(Constants.atCoverage3, SqlDbType.VarChar).Value = planCode.Coverage3;
                command.Parameters.Add(Constants.atCoverage4, SqlDbType.VarChar).Value = planCode.Coverage4;
                command.Parameters.Add(Constants.atCoverage5, SqlDbType.VarChar).Value = planCode.Coverage5;

                int i = command.ExecuteNonQuery();
                bool result = false;
                if (i > 0)
                {
                    result = true;
                }
                return result;
            }
        }

        public bool EditPlan(PlanCode planCode)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.editPlan
                };

                command.Parameters.Add(Constants.atPlanDescription, SqlDbType.VarChar).Value = planCode.PlanDescription;
                command.Parameters.Add(Constants.atCoverage1, SqlDbType.VarChar).Value = planCode.Coverage1;
                command.Parameters.Add(Constants.atCoverage2, SqlDbType.VarChar).Value = planCode.Coverage2;
                command.Parameters.Add(Constants.atCoverage3, SqlDbType.VarChar).Value = planCode.Coverage3;
                command.Parameters.Add(Constants.atCoverage4, SqlDbType.VarChar).Value = planCode.Coverage4;
                command.Parameters.Add(Constants.atCoverage5, SqlDbType.VarChar).Value = planCode.Coverage5;

                int i = command.ExecuteNonQuery();
                bool result = false;
                if (i > 0)
                {
                    result = true;
                }
                return result;
            }
        }

        public bool RemovePlan(PlanCode planCodeId)
        {
            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.removePlan
                };

                command.Parameters.Add(Constants.atPlanCodeId, SqlDbType.Int).Value = planCodeId;

                int i = command.ExecuteNonQuery();
                bool result = false;
                if (i > 0)
                {
                    result = true;
                }
                return result;
            }
        }

        public List<PlanCode> ViewPlan()
        {
            List<PlanCode> planCodeList = new List<PlanCode>();


            using (SqlConnection connection = new SqlConnection(callConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    CommandType = CommandType.Text,
                    CommandText = Queries.viewPlan
                };

                SqlDataReader dataReader = command.ExecuteReader();
                int count = 0;
                while (dataReader.Read())
                {
                    PlanCode planCode = new PlanCode();
                    planCode.PlanDescription = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.planDescription)));
                    planCode.Coverage1 = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.coverage1)));
                    planCode.Coverage2 = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.coverage2)));
                    planCode.Coverage3 = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.coverage3)));
                    planCode.Coverage4 = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.coverage4)));
                    planCode.Coverage5 = Convert.ToString(dataReader.GetValue(dataReader.GetOrdinal(Constants.coverage5)));

                    planCodeList.Add(planCode);
                    count++;
                }
                if (count == 0)
                {
                    throw new NoPlanException();
                }
                return planCodeList;
            }
        
        }
    }
}
