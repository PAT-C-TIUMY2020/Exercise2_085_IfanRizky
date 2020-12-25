namespace Exercise2_085_IfanRizky
{
    partial class FormMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMahasiswa));
            this.lbl_jumlah = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_lihat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.textBoxAngkatan = new System.Windows.Forms.TextBox();
            this.lbl_angkatan = new System.Windows.Forms.Label();
            this.lbl_prodi = new System.Windows.Forms.Label();
            this.textBoxProdi = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_nim = new System.Windows.Forms.Label();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_jumlah
            // 
            this.lbl_jumlah.AutoSize = true;
            this.lbl_jumlah.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jumlah.Location = new System.Drawing.Point(114, 507);
            this.lbl_jumlah.Name = "lbl_jumlah";
            this.lbl_jumlah.Size = new System.Drawing.Size(109, 19);
            this.lbl_jumlah.TabIndex = 188;
            this.lbl_jumlah.Text = "JUMLAH    :";
            this.lbl_jumlah.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(268, 507);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(46, 17);
            this.lbl_total.TabIndex = 187;
            this.lbl_total.Text = "label2";
            // 
            // btn_hitung
            // 
            this.btn_hitung.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_hitung.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hitung.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_hitung.Location = new System.Drawing.Point(158, 415);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(207, 46);
            this.btn_hitung.TabIndex = 186;
            this.btn_hitung.Text = "HITUNG DATA";
            this.btn_hitung.UseVisualStyleBackColor = false;
            this.btn_hitung.Click += new System.EventHandler(this.btn_hitung_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_clear.Location = new System.Drawing.Point(542, 62);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(139, 51);
            this.btn_clear.TabIndex = 185;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.Location = new System.Drawing.Point(1140, 33);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(98, 80);
            this.btn_close.TabIndex = 184;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_lihat
            // 
            this.btn_lihat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_lihat.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lihat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_lihat.Location = new System.Drawing.Point(541, 564);
            this.btn_lihat.Name = "btn_lihat";
            this.btn_lihat.Size = new System.Drawing.Size(207, 46);
            this.btn_lihat.TabIndex = 183;
            this.btn_lihat.Text = "LIHAT DATA";
            this.btn_lihat.UseVisualStyleBackColor = false;
            this.btn_lihat.Click += new System.EventHandler(this.btn_lihat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(540, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 341);
            this.dataGridView1.TabIndex = 182;
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.Location = new System.Drawing.Point(1140, 119);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(51, 50);
            this.btn_search.TabIndex = 181;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxSearch.Location = new System.Drawing.Point(541, 130);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(575, 22);
            this.textBoxSearch.TabIndex = 180;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(977, 62);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 51);
            this.btn_delete.TabIndex = 179;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(832, 62);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(139, 51);
            this.btn_update.TabIndex = 178;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add.Location = new System.Drawing.Point(687, 62);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(139, 51);
            this.btn_add.TabIndex = 177;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Location = new System.Drawing.Point(33, 571);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(131, 118);
            this.btn_back.TabIndex = 176;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // textBoxAngkatan
            // 
            this.textBoxAngkatan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxAngkatan.Location = new System.Drawing.Point(220, 325);
            this.textBoxAngkatan.Name = "textBoxAngkatan";
            this.textBoxAngkatan.Size = new System.Drawing.Size(271, 22);
            this.textBoxAngkatan.TabIndex = 175;
            // 
            // lbl_angkatan
            // 
            this.lbl_angkatan.AutoSize = true;
            this.lbl_angkatan.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_angkatan.Location = new System.Drawing.Point(49, 325);
            this.lbl_angkatan.Name = "lbl_angkatan";
            this.lbl_angkatan.Size = new System.Drawing.Size(140, 19);
            this.lbl_angkatan.TabIndex = 174;
            this.lbl_angkatan.Text = "ANGKATAN    :";
            this.lbl_angkatan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_prodi
            // 
            this.lbl_prodi.AutoSize = true;
            this.lbl_prodi.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prodi.Location = new System.Drawing.Point(49, 259);
            this.lbl_prodi.Name = "lbl_prodi";
            this.lbl_prodi.Size = new System.Drawing.Size(141, 19);
            this.lbl_prodi.TabIndex = 173;
            this.lbl_prodi.Text = "PRODI              :";
            this.lbl_prodi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxProdi
            // 
            this.textBoxProdi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxProdi.Location = new System.Drawing.Point(220, 259);
            this.textBoxProdi.Name = "textBoxProdi";
            this.textBoxProdi.Size = new System.Drawing.Size(271, 22);
            this.textBoxProdi.TabIndex = 172;
            // 
            // textBoxNama
            // 
            this.textBoxNama.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxNama.Location = new System.Drawing.Point(220, 196);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(271, 22);
            this.textBoxNama.TabIndex = 171;
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(49, 196);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(145, 19);
            this.lbl_nama.TabIndex = 170;
            this.lbl_nama.Text = "NAMA               :";
            this.lbl_nama.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_nim
            // 
            this.lbl_nim.AutoSize = true;
            this.lbl_nim.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nim.Location = new System.Drawing.Point(49, 130);
            this.lbl_nim.Name = "lbl_nim";
            this.lbl_nim.Size = new System.Drawing.Size(146, 19);
            this.lbl_nim.TabIndex = 169;
            this.lbl_nim.Text = "NIM                   :";
            this.lbl_nim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxNIM.Location = new System.Drawing.Point(220, 130);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(271, 22);
            this.textBoxNIM.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 51);
            this.label1.TabIndex = 167;
            this.label1.Text = "FORM MAHASISWA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1270, 701);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_jumlah);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_hitung);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_lihat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.textBoxAngkatan);
            this.Controls.Add(this.lbl_angkatan);
            this.Controls.Add(this.lbl_prodi);
            this.Controls.Add(this.textBoxProdi);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.lbl_nim);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.label1);
            this.Name = "FormMahasiswa";
            this.Text = "Form Mahasiswa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_jumlah;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_hitung;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_lihat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox textBoxAngkatan;
        private System.Windows.Forms.Label lbl_angkatan;
        private System.Windows.Forms.Label lbl_prodi;
        private System.Windows.Forms.TextBox textBoxProdi;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_nim;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.Label label1;
    }
}

