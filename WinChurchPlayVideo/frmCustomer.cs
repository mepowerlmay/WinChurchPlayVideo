using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinChurchPlayVideo.Common;
using WinChurchPlayVideo.Helper;
using WinChurchPlayVideo.Service;

namespace WinChurchPlayVideo
{
    public partial class frmCustomer : Form
    {

        private string StrConn { get { return ConfigurationManager.ConnectionStrings["conn"].ConnectionString; } }


        private CustomerService service { get; set; }

        public frmCustomer()

        {
            service = new CustomerService();
            InitializeComponent();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmfrmCustomerCRUD frm = new frmfrmCustomerCRUD();

            frm.ShowDialog();
            GetData();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "刪除", Name = "dgvbtnDelete", HeaderText = "", UseColumnTextForButtonValue = true });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "編輯", Name = "dgvbtnEdit", HeaderText = "", UseColumnTextForButtonValue = true });

            GetData();
        }


        /// <summary>
        /// 取得所有資料
        /// </summary>
        private void GetData()
        {

            DataTable dt = service.GetAll(txtArea.Text, txtCustomerName.Text, txtBarcodeNumber.Text);
            List<ListItem> Areas = DropDownListHelper.GetArea();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["IsDelete"].ToString() == "0") {
                    dt.Rows[i]["IsDelete"] = "停用";
                }
                else
                {
                    dt.Rows[i]["IsDelete"] = "啟用";
                }
                ListItem tempAreaItem = Areas.Where(p => p.Value == dt.Rows[i]["Area"].ToString()).FirstOrDefault();

                if (tempAreaItem != null)
                {
                    dt.Rows[i]["Area"] = tempAreaItem.Text;
                }


            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            //string IsDelete = row.Cells["IsDelete"].Value.ToString().Trim();
            //if (IsDelete == "0")
            //{
            //    row.Cells["IsDelete"].Value = "停用";
            //}
            //else
            //{
            //    row.Cells["IsDelete"].Value = "啟用";
            //}
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            GetData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                long ID = Convert.ToInt32(row.Cells["ID"].Value);
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value.Equals("刪除"))
                {
                    DialogResult result = MessageBox.Show("確認是否 刪除", "視窗", MessageBoxButtons.YesNo);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        service.Delete(ID);

                        GetData();
                    }


                }
                else if (cell.Value.Equals("編輯"))
                {
                    frmfrmCustomerCRUD frm = new frmfrmCustomerCRUD(ID);
                    frm.ShowDialog();

                    GetData();

                }


            }
        }


    }
}
