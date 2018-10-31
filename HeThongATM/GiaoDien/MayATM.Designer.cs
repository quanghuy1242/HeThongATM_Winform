using HeThongATM.Controller;

namespace HeThongATM.GiaoDien
{
    partial class MayATM
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuiTien = new System.Windows.Forms.Button();
            this.btnRutTien = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.Label();
            this.btnGiaoDichThucHien = new System.Windows.Forms.Button();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(178, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xin vui lòng chọn các chức năng bên dưới:";
            // 
            // btnGuiTien
            // 
            this.btnGuiTien.AutoSize = true;
            this.btnGuiTien.Location = new System.Drawing.Point(132, 176);
            this.btnGuiTien.Name = "btnGuiTien";
            this.btnGuiTien.Padding = new System.Windows.Forms.Padding(5);
            this.btnGuiTien.Size = new System.Drawing.Size(160, 33);
            this.btnGuiTien.TabIndex = 3;
            this.btnGuiTien.Text = "Gửi tiền";
            this.btnGuiTien.UseVisualStyleBackColor = true;
            this.btnGuiTien.Click += new System.EventHandler(this.btnGuiTien_Click);
            // 
            // btnRutTien
            // 
            this.btnRutTien.AutoSize = true;
            this.btnRutTien.Location = new System.Drawing.Point(132, 215);
            this.btnRutTien.Name = "btnRutTien";
            this.btnRutTien.Padding = new System.Windows.Forms.Padding(5);
            this.btnRutTien.Size = new System.Drawing.Size(160, 33);
            this.btnRutTien.TabIndex = 4;
            this.btnRutTien.Text = "Rút tiền";
            this.btnRutTien.UseVisualStyleBackColor = true;
            this.btnRutTien.Click += new System.EventHandler(this.btnRutTien_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.AutoSize = true;
            this.btnThongTin.Location = new System.Drawing.Point(371, 176);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Padding = new System.Windows.Forms.Padding(5);
            this.btnThongTin.Size = new System.Drawing.Size(160, 33);
            this.btnThongTin.TabIndex = 5;
            this.btnThongTin.Text = "Truy vấn thông tin tài khoản";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(371, 254);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(5);
            this.btnThoat.Size = new System.Drawing.Size(160, 33);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Đăng xuất";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(49, 103);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(566, 23);
            this.txtUser.TabIndex = 7;
            this.txtUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGiaoDichThucHien
            // 
            this.btnGiaoDichThucHien.AutoSize = true;
            this.btnGiaoDichThucHien.Location = new System.Drawing.Point(371, 215);
            this.btnGiaoDichThucHien.Name = "btnGiaoDichThucHien";
            this.btnGiaoDichThucHien.Padding = new System.Windows.Forms.Padding(5);
            this.btnGiaoDichThucHien.Size = new System.Drawing.Size(160, 33);
            this.btnGiaoDichThucHien.TabIndex = 8;
            this.btnGiaoDichThucHien.Text = "Lịch sử giao dịch";
            this.btnGiaoDichThucHien.UseVisualStyleBackColor = true;
            this.btnGiaoDichThucHien.Click += new System.EventHandler(this.btnGiaoDichThucHien_Click);
            // 
            // btnNapTien
            // 
            this.btnNapTien.AutoSize = true;
            this.btnNapTien.Location = new System.Drawing.Point(132, 254);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Padding = new System.Windows.Forms.Padding(5);
            this.btnNapTien.Size = new System.Drawing.Size(160, 33);
            this.btnNapTien.TabIndex = 9;
            this.btnNapTien.Text = "Nạp tiền";
            this.btnNapTien.UseVisualStyleBackColor = true;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 61);
            this.label3.TabIndex = 10;
            this.label3.Text = "DEFBANK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mọi thứ sẽ trở nên tồi tệ nếu không có chúng tôi";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "                                                                                 " +
    "                        ";
            // 
            // MayATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNapTien);
            this.Controls.Add(this.btnGiaoDichThucHien);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.btnRutTien);
            this.Controls.Add(this.btnGuiTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MayATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống ATM - Ngân Hàng Ahaha";
            this.Load += new System.EventHandler(this.MayATM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuiTien;
        private System.Windows.Forms.Button btnRutTien;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Button btnGiaoDichThucHien;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}