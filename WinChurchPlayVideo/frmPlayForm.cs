using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WinChurchPlayVideo
{
    public partial class frmPlayForm : Form
    {
        /// <summary>
        /// 條碼編號
        /// </summary>
        private string BarCode;

        private string StrConn { get { return ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString; } }

        public frmPlayForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = 100;
            txtBarcode.Focus();

            //BarCode = string.Empty;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            txtBarcode.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            this.Close();
        }

        private void txtBarcode_Click(object sender, EventArgs e)
        {
            txtBarcode.Text = string.Empty;
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.KeyChar.ToString()))
            {
                if (string.IsNullOrEmpty(txtBarcode.Text))
                {
                    MessageBox.Show("請條碼");
                    return;
                }

                txtBarcode.Text = txtBarcode.Text.Remove(0,1);

                DataTable dt = new DataTable();
                string sql = " select VideoAddress from Customer where BarcodeNumber = '" + txtBarcode.Text + "' ";

                using (OleDbConnection conn = new OleDbConnection(StrConn))
                {
                    using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                    {
                        conn.Open();
                        dt.Load(cmd.ExecuteReader());
                    }
                }

                if (dt.Rows.Count > 0)
                {
                    string VideoAddress = dt.Rows[0]["VideoAddress"].ToString().Trim();

                    if (!VideoAddress.EndsWith("mp4", StringComparison.OrdinalIgnoreCase))
                    {
                        VideoAddress = VideoAddress + ".mp4";
                    }

                    PlayVideo(VideoAddress);
                }
                else
                {
                    MessageBox.Show("查無影片資訊");
                }


            }
            else
            {
                BarCode += e.KeyChar.ToString();
                txtBarcode.Text = BarCode;
            }
        }

        /// <summary>
        /// 播放影片
        /// </summary>
        /// <param name="address">影片路徑位址</param>
        public void PlayVideo(string address)
        {
            axWindowsMediaPlayer1.URL = address;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtBarcode.Text = string.Empty;

            BarCode = string.Empty;

            txtBarcode.Focus();

            timer1.Stop();
        }

        private void btnNameQuery_Click(object sender, EventArgs e)
        {
            frmSelectAllName frm = new frmSelectAllName(this);
            frm.ShowDialog();
        }
    }
}