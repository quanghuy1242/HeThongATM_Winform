namespace HeThongATM.GiaoDien
{
    partial class GiaoDich
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDong1 = new System.Windows.Forms.Button();
            this.btnRut = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtSoDu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTienGui = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuiTien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTKNhan = new System.Windows.Forms.TextBox();
            this.txtSoDu2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDong3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienNap = new System.Windows.Forms.TextBox();
            this.txtSoDu3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnClEp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(273, 158);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDong1);
            this.tabPage1.Controls.Add(this.btnRut);
            this.tabPage1.Controls.Add(this.txtTien);
            this.tabPage1.Controls.Add(this.txtSoDu);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(265, 132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rút tiền";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDong1
            // 
            this.btnDong1.Location = new System.Drawing.Point(133, 79);
            this.btnDong1.Name = "btnDong1";
            this.btnDong1.Size = new System.Drawing.Size(75, 23);
            this.btnDong1.TabIndex = 5;
            this.btnDong1.Text = "Đóng";
            this.btnDong1.UseVisualStyleBackColor = true;
            this.btnDong1.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnRut
            // 
            this.btnRut.Location = new System.Drawing.Point(52, 79);
            this.btnRut.Name = "btnRut";
            this.btnRut.Size = new System.Drawing.Size(75, 23);
            this.btnRut.TabIndex = 4;
            this.btnRut.Text = "Rút tiền";
            this.btnRut.UseVisualStyleBackColor = true;
            this.btnRut.Click += new System.EventHandler(this.btnRut_Click);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(149, 42);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(100, 20);
            this.txtTien.TabIndex = 3;
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(149, 16);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.ReadOnly = true;
            this.txtSoDu.Size = new System.Drawing.Size(100, 20);
            this.txtSoDu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số tiền cần rút:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Dư Tài Khoản hiện nay:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTienGui);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnDong);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnGuiTien);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtTKNhan);
            this.tabPage2.Controls.Add(this.txtSoDu2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(265, 132);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gửi tiền";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTienGui
            // 
            this.txtTienGui.Location = new System.Drawing.Point(149, 73);
            this.txtTienGui.Name = "txtTienGui";
            this.txtTienGui.Size = new System.Drawing.Size(100, 20);
            this.txtTienGui.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nhập số tiền cần gửi:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(137, 103);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 23;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số Dư Tài Khoản hiện nay:";
            // 
            // btnGuiTien
            // 
            this.btnGuiTien.Location = new System.Drawing.Point(56, 103);
            this.btnGuiTien.Name = "btnGuiTien";
            this.btnGuiTien.Size = new System.Drawing.Size(75, 23);
            this.btnGuiTien.TabIndex = 22;
            this.btnGuiTien.Text = "Gửi tiền";
            this.btnGuiTien.UseVisualStyleBackColor = true;
            this.btnGuiTien.Click += new System.EventHandler(this.btnGuiTien_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhập số tài khoản nhận:";
            // 
            // txtTKNhan
            // 
            this.txtTKNhan.Location = new System.Drawing.Point(149, 43);
            this.txtTKNhan.Name = "txtTKNhan";
            this.txtTKNhan.Size = new System.Drawing.Size(100, 20);
            this.txtTKNhan.TabIndex = 21;
            this.txtTKNhan.TextChanged += new System.EventHandler(this.txtTKNhan_TextChanged);
            // 
            // txtSoDu2
            // 
            this.txtSoDu2.Location = new System.Drawing.Point(149, 17);
            this.txtSoDu2.Name = "txtSoDu2";
            this.txtSoDu2.ReadOnly = true;
            this.txtSoDu2.Size = new System.Drawing.Size(100, 20);
            this.txtSoDu2.TabIndex = 20;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDong3);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnNapTien);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtTienNap);
            this.tabPage3.Controls.Add(this.txtSoDu3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(265, 132);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nạp tiền";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDong3
            // 
            this.btnDong3.Location = new System.Drawing.Point(132, 81);
            this.btnDong3.Name = "btnDong3";
            this.btnDong3.Size = new System.Drawing.Size(75, 23);
            this.btnDong3.TabIndex = 23;
            this.btnDong3.Text = "Đóng";
            this.btnDong3.UseVisualStyleBackColor = true;
            this.btnDong3.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số Dư Tài Khoản hiện nay:";
            // 
            // btnNapTien
            // 
            this.btnNapTien.Location = new System.Drawing.Point(51, 81);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(75, 23);
            this.btnNapTien.TabIndex = 22;
            this.btnNapTien.Text = "Nạp tiền";
            this.btnNapTien.UseVisualStyleBackColor = true;
            this.btnNapTien.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nhập số tiền nạp:";
            // 
            // txtTienNap
            // 
            this.txtTienNap.Location = new System.Drawing.Point(148, 44);
            this.txtTienNap.Name = "txtTienNap";
            this.txtTienNap.Size = new System.Drawing.Size(100, 20);
            this.txtTienNap.TabIndex = 21;
            // 
            // txtSoDu3
            // 
            this.txtSoDu3.Location = new System.Drawing.Point(148, 18);
            this.txtSoDu3.Name = "txtSoDu3";
            this.txtSoDu3.ReadOnly = true;
            this.txtSoDu3.Size = new System.Drawing.Size(100, 20);
            this.txtSoDu3.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Location = new System.Drawing.Point(291, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 136);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keyboard";
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(6, 105);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(112, 23);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(6, 18);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(65, 18);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(124, 18);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 23);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.Location = new System.Drawing.Point(6, 76);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 23);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(124, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(53, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.Location = new System.Drawing.Point(65, 76);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 23);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.Location = new System.Drawing.Point(124, 47);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 23);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.Location = new System.Drawing.Point(124, 76);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 23);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.Location = new System.Drawing.Point(65, 47);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 23);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Location = new System.Drawing.Point(6, 47);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 23);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnClEp
            // 
            this.btnClEp.Location = new System.Drawing.Point(208, 13);
            this.btnClEp.Name = "btnClEp";
            this.btnClEp.Size = new System.Drawing.Size(75, 20);
            this.btnClEp.TabIndex = 18;
            this.btnClEp.Text = ">>";
            this.btnClEp.UseVisualStyleBackColor = true;
            this.btnClEp.Click += new System.EventHandler(this.btnClEp_Click);
            // 
            // GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 182);
            this.Controls.Add(this.btnClEp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giao Dịch";
            this.Load += new System.EventHandler(this.GiaoDich_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDong1;
        private System.Windows.Forms.Button btnRut;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtSoDu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuiTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTKNhan;
        private System.Windows.Forms.TextBox txtSoDu2;
        private System.Windows.Forms.TextBox txtTienGui;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDong3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienNap;
        private System.Windows.Forms.TextBox txtSoDu3;
        private System.Windows.Forms.Button btnClEp;
    }
}