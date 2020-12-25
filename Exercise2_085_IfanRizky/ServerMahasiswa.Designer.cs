namespace Exercise2_085_IfanRizky
{
    partial class ServerMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerMahasiswa));
            this.lbl_off = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_on = new System.Windows.Forms.Label();
            this.btn_off = new System.Windows.Forms.Button();
            this.btn_on = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_off
            // 
            this.lbl_off.AutoSize = true;
            this.lbl_off.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_off.Location = new System.Drawing.Point(114, 428);
            this.lbl_off.Name = "lbl_off";
            this.lbl_off.Size = new System.Drawing.Size(140, 19);
            this.lbl_off.TabIndex = 178;
            this.lbl_off.Text = "Matikan Server";
            this.lbl_off.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(170, 293);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(46, 17);
            this.lbl_status.TabIndex = 177;
            this.lbl_status.Text = "status";
            // 
            // lbl_on
            // 
            this.lbl_on.AutoSize = true;
            this.lbl_on.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_on.Location = new System.Drawing.Point(114, 158);
            this.lbl_on.Name = "lbl_on";
            this.lbl_on.Size = new System.Drawing.Size(152, 19);
            this.lbl_on.TabIndex = 176;
            this.lbl_on.Text = "Nyalakan Server";
            this.lbl_on.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_off
            // 
            this.btn_off.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_off.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_off.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_off.Location = new System.Drawing.Point(88, 357);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(207, 46);
            this.btn_off.TabIndex = 175;
            this.btn_off.Text = "OFF";
            this.btn_off.UseVisualStyleBackColor = false;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // btn_on
            // 
            this.btn_on.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_on.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_on.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_on.Location = new System.Drawing.Point(88, 195);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(207, 46);
            this.btn_on.TabIndex = 174;
            this.btn_on.Text = "ON";
            this.btn_on.UseVisualStyleBackColor = false;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Location = new System.Drawing.Point(40, 554);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(131, 118);
            this.btn_back.TabIndex = 173;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.Location = new System.Drawing.Point(836, 23);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(98, 80);
            this.btn_close.TabIndex = 172;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 171;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 51);
            this.label1.TabIndex = 170;
            this.label1.Text = "SERVER MAHASISWA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1007, 713);
            this.Controls.Add(this.lbl_off);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_on);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_on);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ServerMahasiswa";
            this.Text = "Server Mahasiswa";
            this.Load += new System.EventHandler(this.ServerMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_off;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_on;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}