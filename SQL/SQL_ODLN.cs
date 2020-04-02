using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using AppTotutrial2.Model;
using Dapper;

namespace AppTutorial2_Server.SQL
{
    public class SQL_ODLN
    {
        string _dbConnStr;
        public string lastErrorMsg; 

        public SQL_ODLN (string dbConnStr)
        {
            _dbConnStr = dbConnStr;
        }

        /// <summary>
        /// Return list of DO
        /// </summary>
        /// <returns></returns>
        public ODLN [] GetDeliveryOrder()
        {
            List<ODLN> result = null;
            try
            {
                string sql = "SELECT TOP 1000 * FROM ODLN";
                using (var connection = new SqlConnection(_dbConnStr))
                {
                    result = connection.Query<ODLN>(sql).ToList();
                }
            }
            catch (Exception excep)
            {
                lastErrorMsg = excep.ToString();
            }
            return result?.ToArray();
        }

    }
}
