using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WinChurchPlayVideo.Common;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;
using WinChurchPlayVideo.Helper;

namespace WinChurchPlayVideo
{
    public partial class frmfrmCustomerCRUD : Form
    {

        private long Id;

        private string StrConn { get { return ConfigurationManager.ConnectionStrings["conn"].ConnectionString; } }

        public frmfrmCustomerCRUD()
        {
            Id = 0;
            InitializeComponent();
        }


        public frmfrmCustomerCRUD(long Id)
        {
            InitializeComponent();
            this.Id = Id;
        }


        private void frmfrmCustomerCRUD_Load(object sender, EventArgs e)
        {
            SetListItems();

            if (this.Id != 0)
            {
                GetData(this.Id);

                btnAdd.Visible = false;
            }
            else
            {
                btnEdit.Visible = false;
            }
        }

        
        /// <summary>
        /// 取得單筆資料
        /// </summary>
        /// <param name="p"></param>
        private void GetData(long p)
        {
            string sql = "select * from Customer where ID =" + p + " ";
          
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    dt.Load(cmd.ExecuteReader());
                }
            }


            if (dt.Rows.Count > 0)
            {
                CustomerName.Text = dt.Rows[0]["CustomerName"].ToString().Trim();

                Area.SelectedValue = dt.Rows[0]["Area"].ToString();
                Idno.Text = dt.Rows[0]["Idno"].ToString().Trim();
                VideoAddress.Text = dt.Rows[0]["VideoAddress"].ToString().Trim();
                BarcodeNumber.Text = dt.Rows[0]["BarcodeNumber"].ToString().Trim();
                IsDelete.SelectedValue = dt.Rows[0]["IsDelete"].ToString().Trim();
            }
        }


        /// <summary>
        /// 設定所有清單集合
        /// </summary>
        private void SetListItems(){

            Area.DataSource = DropDownListHelper.GetArea();

            Area.ValueMember = "Value";
            Area.DisplayMember = "Text";
          


            List<ListItem> GroupListItem = new List<ListItem>();


            GroupListItem.Add(new ListItem { Text = "啟用", Value = "1" });
            GroupListItem.Add(new ListItem { Text = "停用", Value = "0" });
            IsDelete.DataSource = GroupListItem;
            IsDelete.ValueMember = "Value";
            IsDelete.DisplayMember = "Text";
         


        }


        /// <summary>
        /// 清空表單
        /// </summary>
        private void ClearForm()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBoxBase txt = (TextBoxBase)item;
                    txt.Text = string.Empty;
                }
                else if (item is ComboBox)
                {
                    ComboBox cbo = (ComboBox)item;
                    cbo.SelectedIndex = 0;
                }
            }


        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameters;
            int resultCount = 0;
            var dics = new Dictionary<string, string>();
            dics.Add("CustomerName", CustomerName.Text);
            dics.Add("Area", Area.SelectedValue.ToString());
            dics.Add("Idno", Idno.Text);
            dics.Add("VideoAddress", VideoAddress.Text);
            dics.Add("BarcodeNumber", BarcodeNumber.Text);
            dics.Add("IsDelete", IsDelete.SelectedValue.ToString());

            string sql = SqlHelper.GenerateSQL_Update(dics, "Customer", out parameters);
            sql += " where ID =" + this.Id + " ";




            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    resultCount = cmd.ExecuteNonQuery();
                }
            }

            if (resultCount > 0)
            {
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失敗");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            SqlParameter[] parameters;
            int resultCount = 0;
            var dics = new Dictionary<string, string>();
            dics.Add("CustomerName", CustomerName.Text);
            dics.Add("Area", Area.SelectedValue.ToString());
            dics.Add("Idno", Idno.Text);
            dics.Add("VideoAddress", VideoAddress.Text);
            dics.Add("BarcodeNumber", BarcodeNumber.Text);
            dics.Add("IsDelete", IsDelete.SelectedValue.ToString());

            string sql = SqlHelper.GenerateSQL_Ins(dics, "Customer", out parameters);



            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                 resultCount =   cmd.ExecuteNonQuery();
                }
            }

            if (resultCount > 0)
            {
                MessageBox.Show("新增成功");
                ClearForm();

            }
            else
            {
                MessageBox.Show("新增失敗");
            }




        }

   
    }
}

