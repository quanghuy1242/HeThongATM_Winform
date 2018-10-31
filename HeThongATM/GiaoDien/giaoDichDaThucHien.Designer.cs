namespace HeThongATM.GiaoDien
{
    partial class frmGiaoDichDaThucHien
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
            this.dtgvGiaoDich = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotknhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInGiaoDich = new System.Windows.Forms.Button();
            this.txtLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaoDich)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvGiaoDich
            // 
            this.dtgvGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGiaoDich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.ngayGD,
            this.gioGD,
            this.tienGD,
            this.soDu,
            this.loaiGD,
            this.sotknhan});
            this.dtgvGiaoDich.Location = new System.Drawing.Point(13, 13);
            this.dtgvGiaoDich.Name = "dtgvGiaoDich";
            this.dtgvGiaoDich.ReadOnly = true;
            this.dtgvGiaoDich.Size = new System.Drawing.Size(612, 198);
            this.dtgvGiaoDich.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(550, 217);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "giaoDichID";
            this.colId.HeaderText = "Mã GD";
            this.colId.MaxInputLength = 2222;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // ngayGD
            // 
            this.ngayGD.DataPropertyName = "ngayGD";
            this.ngayGD.HeaderText = "Ngày GD";
            this.ngayGD.Name = "ngayGD";
            this.ngayGD.ReadOnly = true;
            this.ngayGD.Width = 50;
            // 
            // gioGD
            // 
            this.gioGD.DataPropertyName = "gioGD";
            this.gioGD.HeaderText = "Giờ GD";
            this.gioGD.Name = "gioGD";
            this.gioGD.ReadOnly = true;
            this.gioGD.Width = 50;
            // 
            // tienGD
            // 
            this.tienGD.DataPropertyName = "soTien";
            this.tienGD.HeaderText = "Số Tiền";
            this.tienGD.Name = "tienGD";
            this.tienGD.ReadOnly = true;
            // 
            // soDu
            // 
            this.soDu.DataPropertyName = "soDu";
            this.soDu.HeaderText = "Số Dư";
            this.soDu.Name = "soDu";
            this.soDu.ReadOnly = true;
            // 
            // loaiGD
            // 
            this.loaiGD.DataPropertyName = "loaiGD";
            this.loaiGD.HeaderText = "Loại";
            this.loaiGD.Name = "loaiGD";
            this.loaiGD.ReadOnly = true;
            // 
            // sotknhan
            // 
            this.sotknhan.DataPropertyName = "soTaiKhoanNhan";
            this.sotknhan.HeaderText = "Tài Khoản nhận";
            this.sotknhan.Name = "sotknhan";
            this.sotknhan.ReadOnly = true;
            // 
            // btnInGiaoDich
            // 
            this.btnInGiaoDich.Location = new System.Drawing.Point(469, 217);
            this.btnInGiaoDich.Name = "btnInGiaoDich";
            this.btnInGiaoDich.Size = new System.Drawing.Size(75, 23);
            this.btnInGiaoDich.TabIndex = 2;
            this.btnInGiaoDich.Text = "In giao dịch";
            this.btnInGiaoDich.UseVisualStyleBackColor = true;
            this.btnInGiaoDich.Click += new System.EventHandler(this.btnInGiaoDich_Click);
            // 
            // txtLoading
            // 
            this.txtLoading.AutoSize = true;
            this.txtLoading.Location = new System.Drawing.Point(379, 222);
            this.txtLoading.Name = "txtLoading";
            this.txtLoading.Size = new System.Drawing.Size(0, 13);
            this.txtLoading.TabIndex = 3;
            // 
            // frmGiaoDichDaThucHien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 252);
            this.Controls.Add(this.txtLoading);
            this.Controls.Add(this.btnInGiaoDich);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dtgvGiaoDich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGiaoDichDaThucHien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao dịch đã thực hiện";
            this.Load += new System.EventHandler(this.frmGiaoDichDaThucHien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaoDich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvGiaoDich;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDu;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotknhan;
        private System.Windows.Forms.Button btnInGiaoDich;
        private System.Windows.Forms.Label txtLoading;
    }
}