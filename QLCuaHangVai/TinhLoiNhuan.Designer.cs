namespace QLCuaHangVai
{
    partial class TinhLoiNhuan
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
            this.cbTheo = new System.Windows.Forms.ComboBox();
            this.dtgTheo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoanThu = new System.Windows.Forms.Label();
            this.lblLoiNhuan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTheo
            // 
            this.cbTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTheo.FormattingEnabled = true;
            this.cbTheo.Location = new System.Drawing.Point(268, 36);
            this.cbTheo.Name = "cbTheo";
            this.cbTheo.Size = new System.Drawing.Size(154, 21);
            this.cbTheo.TabIndex = 0;
            this.cbTheo.SelectedIndexChanged += new System.EventHandler(this.cbTheo_SelectedIndexChanged);
            // 
            // dtgTheo
            // 
            this.dtgTheo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTheo.Location = new System.Drawing.Point(268, 87);
            this.dtgTheo.Name = "dtgTheo";
            this.dtgTheo.Size = new System.Drawing.Size(154, 271);
            this.dtgTheo.TabIndex = 1;
            this.dtgTheo.SelectionChanged += new System.EventHandler(this.dtgTheo_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doanh thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lợi nhuận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn";
            // 
            // lblDoanThu
            // 
            this.lblDoanThu.AutoSize = true;
            this.lblDoanThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanThu.ForeColor = System.Drawing.Color.Red;
            this.lblDoanThu.Location = new System.Drawing.Point(80, 50);
            this.lblDoanThu.Name = "lblDoanThu";
            this.lblDoanThu.Size = new System.Drawing.Size(70, 25);
            this.lblDoanThu.TabIndex = 7;
            this.lblDoanThu.Text = "label5";
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiNhuan.ForeColor = System.Drawing.Color.Red;
            this.lblLoiNhuan.Location = new System.Drawing.Point(80, 103);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(70, 25);
            this.lblLoiNhuan.TabIndex = 7;
            this.lblLoiNhuan.Text = "label5";
            // 
            // TinhLoiNhuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 386);
            this.Controls.Add(this.lblLoiNhuan);
            this.Controls.Add(this.lblDoanThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgTheo);
            this.Controls.Add(this.cbTheo);
            this.Name = "TinhLoiNhuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TinhLoiNhuan";
            this.Load += new System.EventHandler(this.TinhLoiNhuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTheo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTheo;
        private System.Windows.Forms.DataGridView dtgTheo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoanThu;
        private System.Windows.Forms.Label lblLoiNhuan;
    }
}