namespace WinChurchPlayVideo
{
    partial class frmfrmCustomerCRUD
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
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labArea = new System.Windows.Forms.Label();
            this.labIdno = new System.Windows.Forms.Label();
            this.Idno = new System.Windows.Forms.TextBox();
            this.labBarcodeNumber = new System.Windows.Forms.Label();
            this.VideoAddress = new System.Windows.Forms.TextBox();
            this.labVideoaddress = new System.Windows.Forms.Label();
            this.BarcodeNumber = new System.Windows.Forms.TextBox();
            this.labIsDelete = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.ComboBox();
            this.IsDelete = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CustomerName.Location = new System.Drawing.Point(150, 40);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(146, 33);
            this.CustomerName.TabIndex = 0;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(29, 37);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 21);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名";
            // 
            // labArea
            // 
            this.labArea.AutoSize = true;
            this.labArea.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labArea.Location = new System.Drawing.Point(29, 79);
            this.labArea.Name = "labArea";
            this.labArea.Size = new System.Drawing.Size(52, 21);
            this.labArea.TabIndex = 3;
            this.labArea.Text = "地區";
            // 
            // labIdno
            // 
            this.labIdno.AutoSize = true;
            this.labIdno.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIdno.Location = new System.Drawing.Point(29, 120);
            this.labIdno.Name = "labIdno";
            this.labIdno.Size = new System.Drawing.Size(115, 21);
            this.labIdno.TabIndex = 5;
            this.labIdno.Text = "身分證字號";
            // 
            // Idno
            // 
            this.Idno.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Idno.Location = new System.Drawing.Point(150, 117);
            this.Idno.Name = "Idno";
            this.Idno.Size = new System.Drawing.Size(146, 33);
            this.Idno.TabIndex = 4;
            // 
            // labBarcodeNumber
            // 
            this.labBarcodeNumber.AutoSize = true;
            this.labBarcodeNumber.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBarcodeNumber.Location = new System.Drawing.Point(29, 226);
            this.labBarcodeNumber.Name = "labBarcodeNumber";
            this.labBarcodeNumber.Size = new System.Drawing.Size(94, 21);
            this.labBarcodeNumber.TabIndex = 7;
            this.labBarcodeNumber.Text = "條碼編號";
            // 
            // VideoAddress
            // 
            this.VideoAddress.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VideoAddress.Location = new System.Drawing.Point(150, 156);
            this.VideoAddress.Multiline = true;
            this.VideoAddress.Name = "VideoAddress";
            this.VideoAddress.Size = new System.Drawing.Size(267, 65);
            this.VideoAddress.TabIndex = 6;
            // 
            // labVideoaddress
            // 
            this.labVideoaddress.AutoSize = true;
            this.labVideoaddress.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labVideoaddress.Location = new System.Drawing.Point(29, 155);
            this.labVideoaddress.Name = "labVideoaddress";
            this.labVideoaddress.Size = new System.Drawing.Size(94, 21);
            this.labVideoaddress.TabIndex = 9;
            this.labVideoaddress.Text = "影片位址";
            // 
            // BarcodeNumber
            // 
            this.BarcodeNumber.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BarcodeNumber.Location = new System.Drawing.Point(150, 227);
            this.BarcodeNumber.Name = "BarcodeNumber";
            this.BarcodeNumber.Size = new System.Drawing.Size(267, 33);
            this.BarcodeNumber.TabIndex = 8;
            // 
            // labIsDelete
            // 
            this.labIsDelete.AutoSize = true;
            this.labIsDelete.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIsDelete.Location = new System.Drawing.Point(29, 266);
            this.labIsDelete.Name = "labIsDelete";
            this.labIsDelete.Size = new System.Drawing.Size(99, 21);
            this.labIsDelete.TabIndex = 13;
            this.labIsDelete.Text = "停用/啟用";
            // 
            // Area
            // 
            this.Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Area.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Area.FormattingEnabled = true;
            this.Area.Location = new System.Drawing.Point(150, 82);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(146, 29);
            this.Area.TabIndex = 14;
            // 
            // IsDelete
            // 
            this.IsDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsDelete.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IsDelete.FormattingEnabled = true;
            this.IsDelete.Location = new System.Drawing.Point(150, 266);
            this.IsDelete.Name = "IsDelete";
            this.IsDelete.Size = new System.Drawing.Size(146, 29);
            this.IsDelete.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(87, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 43);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("PMingLiU", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEdit.Location = new System.Drawing.Point(190, 333);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 43);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmfrmCustomerCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 403);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.IsDelete);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.labIsDelete);
            this.Controls.Add(this.labVideoaddress);
            this.Controls.Add(this.BarcodeNumber);
            this.Controls.Add(this.labBarcodeNumber);
            this.Controls.Add(this.VideoAddress);
            this.Controls.Add(this.labIdno);
            this.Controls.Add(this.Idno);
            this.Controls.Add(this.labArea);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.CustomerName);
            this.Name = "frmfrmCustomerCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "影片/編輯新增";
            this.Load += new System.EventHandler(this.frmfrmCustomerCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labArea;
        private System.Windows.Forms.Label labIdno;
        private System.Windows.Forms.TextBox Idno;
        private System.Windows.Forms.Label labBarcodeNumber;
        private System.Windows.Forms.TextBox VideoAddress;
        private System.Windows.Forms.Label labVideoaddress;
        private System.Windows.Forms.TextBox BarcodeNumber;
        private System.Windows.Forms.Label labIsDelete;
        private System.Windows.Forms.ComboBox Area;
        private System.Windows.Forms.ComboBox IsDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
    }
}