﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HullMaintenance
{
    public static class DbHelper
    {
        public static string DbServer { get; private set; }
        public static string DbName { get; private set; }
        public static string DbUserId { get; private set; }
        public static string DbPassworkd { get; private set; }
        public static string DbConnectionString { get; private set; }

        /// <summary>
        /// Create DB Connection String
        /// </summary>
        /// <returns></returns>
        public static string CreateDatabaseConnection(string dbServer, string dbName, string userId, string password)
        {
            DbServer = dbServer;
            DbName = dbName;
            DbUserId = userId;
            DbPassworkd = password;
            DbConnectionString = String.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}; Persist Security Info=True;",
                                              dbServer, dbName, userId, password);

            return DbConnectionString;
        }

        /// <summary>
        /// Create Delete Query by id
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetDeleteQuery(string tableName, int id)
        {
            return String.Format(@"DELETE FROM {0} WHERE id = {1};", tableName, id);
        }

        /// <summary>
        /// Create Insert Query
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static string GetInsertQuery(string tableName)
        {
            string insertQuery = String.Format("INSERT INTO {0} " +
                "(customer, site, type, category1, category2, priority, work_time, worker" +
                ", receive_date, due_date, start_date, end_date, verification_date, update_date" +
                ", status, document_file, sample_file, mail_file, summary_kr, summary_jp, details, writer, save_date)" +
                " VALUES " + "" +
                "(@customer, @site, @type, @category1, @category2, @priority, @workTime, @worker" +
                ", @receiveDate, @dueDate, @startDate, @endDate, @verificationDate, @updateDate" +
                ", @status, @documentFile,  @sampleFile, @mailFile, @summaryKr, @summaryJp, @details, @writer, @saveDate)" +
                " SELECT id = @@IDENTITY;", tableName);

            return insertQuery;
        }

        /// <summary>
        /// Create Update Query by id
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetUpdateQuery(string tableName, int id)
        {
            string updateQuery = String.Format("UPDATE {0} SET " +
                "customer = @customer" +
                ", site = @site" +
                ", type = @type" +
                ", category1 = @category1" +
                ", category2 = @category2" +
                ", priority = @priority" +
                ", work_time = @workTime" +
                ", worker = @worker" +
                ", receive_date = @receiveDate" +
                ", due_date = @dueDate" +
                ", start_date = @startDate" +
                ", end_date = @endDate" +
                ", verification_date = @verificationDate" +
                ", update_date = @updateDate" +
                ", status = @status" +
                ", document_file = @documentFile" +
                ", sample_file = @sampleFile" +
                ", mail_file = @mailFile" +
                ", summary_kr = @summaryKr" +
                ", summary_jp = @summaryJp" +
                ", details = @details" +
                ", writer = @writer" +
                ", save_date = @saveDate " +
                "WHERE id = {1};", tableName, id);

            return updateQuery;
        }

        /// <summary>
        /// Get DataTable from DB
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static DataTable GetDataTableFromDB(string tableName)
        {
            DataTable dt = new DataTable();
            dt.TableName = tableName;

            string query = String.Format("SELECT * FROM {0} ORDER BY id DESC", tableName);

            using (SqlConnection conn = new SqlConnection(DbConnectionString))
            {
                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand scm = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader sdr = scm.ExecuteReader();

                    dt.Load(sdr);
                    dt.Columns.Add("document_name");
                    foreach (DataRow row in dt.Rows)
                    {
                        string file = row["document_file"].ToString();

                        if (String.IsNullOrEmpty(file) == true)
                        {
                            continue;
                        }

                        file = file.Split(Path.DirectorySeparatorChar).Last();
                        row["document_name"] = file;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return dt;
        }

        /// <summary>
        /// Get Dictionary DataTables
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, DataTable> GetDataTableDictionary(List<string> tableNames)
        {
            Dictionary<string, DataTable> dic = new Dictionary<string, DataTable>();

            foreach (string tableName in tableNames)
            {
                DataTable dt = GetDataTableFromDB(tableName);

                dt.TableName = tableName;

                if (dic.ContainsKey(tableName) == false)
                {
                    dic.Add(tableName, dt);
                }
            }

            return dic;
        }

        /// <summary>
        /// Select Table List in DB
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTableListFromDB()
        {
            List<string> tableList = new List<string>();

            string query = String.Format("SELECT T.name AS TABLE_NAME, C.name AS COLUMN_NAME " +
                                         "FROM sys.tables AS T " +
                                         "INNER JOIN sys.columns AS C " +
                                         "ON T.object_id = C.object_id " +
                                         "WHERE C.name = 'summary_kr' " +
                                         "ORDER BY TABLE_NAME ASC;");

            using (SqlConnection conn = new SqlConnection(DbConnectionString))
            {
                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand scm = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader sdr = scm.ExecuteReader();

                    while (sdr.Read())
                    {
                        tableList.Add(Convert.ToString(sdr["TABLE_NAME"]));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return tableList;
            }
        }

        public static DataTable GetCustomerDt()
        {
            DataTable dt = new DataTable();

            string query = String.Format("SELECT * FROM customer_info");

            using (SqlConnection conn = new SqlConnection(DbConnectionString))
            {
                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand scm = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader sdr = scm.ExecuteReader();

                    dt.Load(sdr);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return dt;
        }
        /// <summary>
        /// Get Customer Folder Names
        /// </summary>
        /// <param name="customerList"></param>
        /// <returns></returns>
        public static Dictionary<string, DataRow> GetCustomerInfoDicFromDB()
        {
            Dictionary<string, DataRow> dic = new Dictionary<string, DataRow>();
            DataTable dt = new DataTable();

            string query = String.Format("SELECT * FROM customer_info");

            using (SqlConnection conn = new SqlConnection(DbConnectionString))
            {
                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter();
                SqlCommand scm = new SqlCommand(query, conn);

                try
                {
                    SqlDataReader sdr = scm.ExecuteReader();

                    dt.Load(sdr);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string tableName = row["table_name"].ToString();

                    if (dic.ContainsKey(tableName) == false)
                    {
                        dic.Add(tableName, row);
                    }
                }

                #region Test
                //dic = dt.AsEnumerable().ToDictionary<DataRow, string, string[]>(row => row.Field<string>("table_name"), 
                //                                                                row => new string[] 
                //                                                                {
                //                                                                    row.Field<string>("customer_en"),
                //                                                                    row.Field<string>("customer_kr"),
                //                                                                    row.Field<string>("folder_name"),
                //                                                                    row.Field<string>("abbr")
                //                                                                });
                #endregion
            }

            return dic;
        }
    }
}
