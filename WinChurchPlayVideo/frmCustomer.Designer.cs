namespace WinChurchPlayVideo
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.labCustomerName = new System.Windows.Forms.Label();
            this.labArea = new System.Windows.Forms.Label();
            this.labBarcode = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtBarcodeNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IsDelete,
            this.CustomerName,
            this.Area,
            this.Idno,
            this.VideoAddress,
            this.BarcodeNumber});
            this.dataGridView1.Location = new System.Drawing.Point(0, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "主key";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // IsDelete
            // 
            this.IsDelete.DataPropertyName = "IsDelete";
            this.IsDelete.HeaderText = "狀態";
            this.IsDelete.Name = "IsDelete";
            this.IsDelete.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "姓名";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "Area";
            this.Area.HeaderText = "地區";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // Idno
            // 
            this.Idno.DataPropertyName = "Idno";
            this.Idno.HeaderText = "身分證字號";
            this.Idno.Name = "Idno";
            this.Idno.ReadOnly = true;
            // 
            // VideoAddress
            // 
            this.VideoAddress.DataPropertyName = "VideoAddress";
            this.VideoAddress.HeaderText = "影片位址";
            this.VideoAddress.Name = "VideoAddress";
            this.VideoAddress.ReadOnly = true;
            // 
            // BarcodeNumber
            // 
            this.BarcodeNumber.DataPropertyName = "BarcodeNumber";
            this.BarcodeNumber.HeaderText = "條碼編號";
            this.BarcodeNumber.Name = "BarcodeNumber";
            this.BarcodeNumber.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(812, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQuery.Location = new System.Drawing.Point(724, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(82, 29);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // labCustomerName
            // 
            this.labCustomerName.AutoSize = true;
            this.labCustomerName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCustomerName.Location = new System.Drawing.Point(12, 9);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(66, 38);
            this.labCustomerName.TabIndex = 3;
            this.labCustomerName.Text = "師兄姐\r\n姓名";
            // 
            // labArea
            // 
            this.labArea.AutoSize = true;
            this.labArea.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labArea.Location = new System.Drawing.Point(205, 24);
            this.labArea.Name = "labArea";
            this.labArea.Size = new System.Drawing.Size(66, 19);
            this.labArea.TabIndex = 4;
            this.labArea.Text = "地區別";
            // 
            // labBarcode
            // 
            this.labBarcode.AutoSize = true;
            this.labBarcode.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBarcode.Location = new System.Drawing.Point(386, 24);
            this.labBarcode.Name = "labBarcode";
            this.labBarcode.Size = new System.Drawing.Size(104, 19);
            this.labBarcode.TabIndex = 5;
            this.labBarcode.Text = "barcode編號";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCustomerName.Location = new System.Drawing.Point(99, 14);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 30);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtArea.Location = new System.Drawing.Point(277, 13);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 30);
            this.txtArea.TabIndex = 7;
            // 
            // txtBarcodeNumber
            // 
            this.txtBarcodeNumber.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBarcodeNumber.Location = new System.Drawing.Point(487, 13);
            this.txtBarcodeNumber.Name = "txtBarcodeNumber";
            this.txtBarcodeNumber.Size = new System.Drawing.Size(231, 30);
            this.txtBarcodeNumber.TabIndex = 8;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 437);
            this.Controls.Add(this.txtBarcodeNumber);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.labBarcode);
            this.Controls.Add(this.labArea);
            this.Controls.Add(this.labCustomerName);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "影片檔案維護畫面";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label labCustomerName;
        private System.Windows.Forms.Label labArea;
        private System.Windows.Forms.Label labBarcode;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtBarcodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idno;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeNumber;
    }
}