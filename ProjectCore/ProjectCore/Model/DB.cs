using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjectCore.Model
{
    class DB
    {
        public static string ConnString { get; set; }
        public static List<T> PullData<T>(string sql, Func<SqlDataReader, T> processRecord, Action<SqlCommand> setParameters = null)
        {
            List<T> list = new List<T>();
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (setParameters != null)
                        setParameters(cmd);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())

                            list.Add(processRecord(dr));
                    }
                }
            }
            return list;
        }
    }
}