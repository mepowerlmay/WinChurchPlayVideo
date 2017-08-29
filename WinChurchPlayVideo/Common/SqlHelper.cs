using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WinChurchPlayVideo.Common
{
    public class SqlHelper
    {

        /// <summary>
        /// 產生SQL語法
        /// </summary>
        /// <param name="record">字典物件</param>
        /// <param name="tableName">表格名稱</param>
        /// <param name="parameters">陣列參數 OleDbParameter   out</param>
        /// <returns>回傳 OleDbParameter[] 跟 string   sql</returns>
        public static string GenerateSQL_Ins(Dictionary<string, string> record,
                                    string tableName,
            out SqlParameter[] parameters)
        {       
            

            var parameterList = new List<SqlParameter>();
            var sqlTemplate = "INSERT INTO {0}({1}) VALUES({2})";
            var colList = string.Empty;
            var valueList = string.Empty;

            foreach (string columnName in record.Keys)
            {
                string value = record[columnName];
                if (string.IsNullOrEmpty(value) == true) continue;

                if (string.IsNullOrEmpty(colList) == false)
                {
                    colList += ",";
                }
                colList += columnName;

                if (string.IsNullOrEmpty(valueList) == false)
                {
                    valueList += ",";
                }
                valueList += "@" + columnName;

                SqlParameter p = new SqlParameter(columnName, value);
                parameterList.Add(p);
            }

            parameters = parameterList.ToArray();

            return string.Format(sqlTemplate, tableName, colList, valueList);
        }



        /// <summary>
        /// 產生SQL語法
        /// </summary>
        /// <param name="record">字典物件</param>
        /// <param name="tableName">表格名稱</param>
        /// <param name="parameters">陣列參數 OleDbParameter   out</param>
        /// <returns>回傳 OleDbParameter[] 跟 string   sql</returns>
        public static string GenerateSQL_Update(Dictionary<string, string> record,
                                    string tableName,
            out SqlParameter[] parameters)
        {


            var parameterList = new List<SqlParameter>();
            var sqlTemplate = "update  {0} set {1}";          
            var valueList = string.Empty;

            foreach (string columnName in record.Keys)
            {
                string value = record[columnName];
                if (string.IsNullOrEmpty(value) == true) continue;



                if (string.IsNullOrEmpty(valueList) == false)
                {
                    valueList += ",";
                }

                valueList += string.Concat(columnName, "=@", columnName);

               SqlParameter p = new SqlParameter(columnName, value);
                parameterList.Add(p);
            }

            parameters = parameterList.ToArray();

            return string.Format(sqlTemplate ,tableName  ,   valueList);
        }
    }
}
