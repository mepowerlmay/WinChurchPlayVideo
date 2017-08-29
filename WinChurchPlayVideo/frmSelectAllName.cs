using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frmSelectAllName : Form
    {
        private CustomerService service { get; set; }
        private List<ListItem> GroupNameItem { get; set; }

        private frmPlayForm frm { get; set; }

        public frmSelectAllName(frmPlayForm frm)
        {

            InitializeComponent();
            this.frm = frm;
            service = new CustomerService();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmSelectAllName_Load(object sender, EventArgs e)
        {
            GetNameData();
            ShowNames();
        }

        /// <summary>
        /// 取得姓名資料
        /// </summary>
        private void GetNameData()
        {
            

            

            chkblAllNameSelect.DataSource = DropDownListHelper.GetAllNames(); ;


            chkblAllNameSelect.ValueMember = "Value";

            chkblAllNameSelect.DisplayMember = "Text";




        }

        private void chkblAllNameSelect_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {

                foreach (int i in chkblAllNameSelect.CheckedIndices)
                    chkblAllNameSelect.SetItemCheckState(i, CheckState.Unchecked);




                ListItem item = (ListItem)chkblAllNameSelect.Items[e.Index];

                DataTable dt = service.GetAll(item.Text.TrimEnd());


                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    string value = dt.Rows[i]["Area"].ToString();
                    ListItem qitem = DropDownListHelper.GetArea()
                                        .Where(p => p.Value == value).FirstOrDefault();
                    if (qitem != null)
                    {
                        dt.Rows[i]["Area"] = qitem.Text;
                    }
                }



                dataGridView1.DataSource = dt;


                ShowGrid();

                dataGridView1.AutoResizeRows();
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeColumnHeadersHeight();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowNames();
        }


        /// <summary>
        ///  顯示名稱清單
        /// </summary>
        private void ShowNames()
        {
            chkblAllNameSelect.Dock = DockStyle.Fill;
            chkblAllNameSelect.Visible = true;
            dataGridView1.Dock = DockStyle.None;
            dataGridView1.Visible = false;
        }

        /// <summary>
        /// 顯示 grid 清單
        /// </summary>
        private void ShowGrid()
        {
            chkblAllNameSelect.Dock = DockStyle.None;
            chkblAllNameSelect.Visible = false;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                long ID = Convert.ToInt32(row.Cells["ID"].Value);
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                DataTable dt = service.Get(ID);

                if (dt.Rows.Count > 0)
                {

                    string VideoAddress = dt.Rows[0]["VideoAddress"].ToString().Trim();

                    if (!VideoAddress.EndsWith("mp4", StringComparison.OrdinalIgnoreCase))
                    {
                        VideoAddress = VideoAddress + ".mp4";
                    }

                    frm.PlayVideo(VideoAddress);
                    this.Close();
                }


            }
        }
    }
}
