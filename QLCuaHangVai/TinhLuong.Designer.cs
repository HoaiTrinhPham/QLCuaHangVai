namespace QLCuaHangVai
{
    partial class TinhLuong
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
            this.rdTungNV = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btLuong = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongLuong = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // rdTungNV
            // 
            this.rdTungNV.AutoSize = true;
            this.rdTungNV.Checked = true;
            this.rdTungNV.Location = new System.Drawing.Point(12, 23);
            this.rdTungNV.Name = "rdTungNV";
            this.rdTungNV.Size = new System.Drawing.Size(117, 21);
            this.rdTungNV.TabIndex = 0;
            this.rdTungNV.TabStop = true;
            this.rdTungNV.Text = "Từng nhân viên";
            this.rdTungNV.UseVisualStyleBackColor = true;
            this.rdTungNV.CheckedChanged += new System.EventHandler(this.rdTungNV_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAll);
            this.groupBox1.Controls.Add(this.rdTungNV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính lương";
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Location = new System.Drawing.Point(222, 23);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(124, 21);
            this.rdAll.TabIndex = 0;
            this.rdAll.Text = "Tất cả nhân viên";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(122, 78);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(131, 26);
            this.txtMaNV.TabIndex = 4;
            // 
            // btLuong
            // 
            this.btLuong.Location = new System.Drawing.Point(297, 74);
            this.btLuong.Name = "btLuong";
            this.btLuong.Size = new System.Drawing.Size(75, 30);
            this.btLuong.TabIndex = 5;
            this.btLuong.Text = "Lương";
            this.btLuong.UseVisualStyleBackColor = true;
            this.btLuong.Click += new System.EventHandler(this.btLuong_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.Ho,
            this.Ten,
            this.GioLuong,
            this.tienCong,
            this.Luong});
            this.dgvNhanVien.Location = new System.Drawing.Point(7, 125);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(492, 180);
            this.dgvNhanVien.TabIndex = 6;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 75;
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.Name = "Ho";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.Width = 50;
            // 
            // GioLuong
            // 
            this.GioLuong.DataPropertyName = "GioLuong";
            this.GioLuong.HeaderText = "Giờ công";
            this.GioLuong.Name = "GioLuong";
            this.GioLuong.Width = 50;
            // 
            // tienCong
            // 
            this.tienCong.DataPropertyName = "tienCong";
            this.tienCong.HeaderText = "Tiền Công/giờ";
            this.tienCong.Name = "tienCong";
            this.tienCong.Width = 70;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng cộng:";
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.AutoSize = true;
            this.txtTongLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongLuong.Location = new System.Drawing.Point(424, 311);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.Size = new System.Drawing.Size(76, 19);
            this.txtTongLuong.TabIndex = 7;
            this.txtTongLuong.Text = "Tổng cộng:";
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 354);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.btLuong);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TinhLuong";
            this.Load += new System.EventHandler(this.TinhLuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdTungNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btLuong;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTongLuong;
    }
}