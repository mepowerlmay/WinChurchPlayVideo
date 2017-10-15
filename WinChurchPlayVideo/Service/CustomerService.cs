using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WinChurchPlayVideo.Common;

namespace WinChurchPlayVideo.Service
{
   public  class CustomerService : IDisposable
    {
        private string StrConn { get { return ConfigurationManager.ConnectionStrings["conn"].ConnectionString; } }

        /// <summary>
        /// 取得 單筆資料
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable Get(long ID)
        {
            DataTable dt = new DataTable();

            string sql = "select * from Customer where ID =" + ID + "";

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    dt.Load( cmd.ExecuteReader());
                }
            }

            return dt;
        }


        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="ID">主key</param>
        public void Delete(long ID)
        {
            string sql = "delete from Customer where ID =" + ID + "";

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 取得全部資料
        /// </summary>
        /// <param name="txtArea">地區</param>
        /// <param name="txtCustomerName">姓名</param>
        /// <param name="txtBarcodeNumber">條碼編號</param>
        /// <returns></returns>
        public DataTable GetAll(string txtArea,string txtCustomerName,string txtBarcodeNumber) {
            DataTable dt = new DataTable();
            var wherebuilder = new WhereClausesBuilder();
            var parameters = new List<SqlParameter>();


            string sql = "select * from Customer ";

            string where = " where 1=1 ";
            wherebuilder.appendCriteria("Area", txtArea, " Area like {0}+'%' ", ref where, ref parameters);
            wherebuilder.appendCriteria("CustomerName", txtCustomerName, " CustomerName like {0}+'%'", ref where, ref parameters);
            wherebuilder.appendCriteria("BarcodeNumber", txtBarcodeNumber, " BarcodeNumber = {0} ", ref where, ref parameters);

            sql += where;


            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
            
                    cmd.Parameters.AddRange(parameters.ToArray());
                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;

        }


        /// <summary>
        /// 取得所有姓氏清單
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllName() {

            DataTable dt = new DataTable();
            string sql = @"select distinct left([CustomerName],1) as username from [dbo].[Customer]";



            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                   
                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;

        }


        /// <summary>
        /// 取得姓名 清單
        /// </summary>
        /// <param name="txtCustomerName"></param>
        /// <returns></returns>
        public DataTable GetAll(string txtCustomerName) {
            DataTable dt = new DataTable();
            var wherebuilder = new WhereClausesBuilder();
            var parameters = new List<SqlParameter>();


            string sql = "select * from Customer ";

            string where = " where 1=1 ";
        
            wherebuilder.appendCriteria("CustomerName", txtCustomerName, " CustomerName like {0}+'%'", ref where, ref parameters);
          
            sql += where;


            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddRange(parameters.ToArray());
                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;
        }
    }
}
