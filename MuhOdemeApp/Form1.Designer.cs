namespace MuhOdemeApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evraklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resimleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.evraklarToolStripMenuItem,
            this.ayarlarToolStripMenuItem1,
            this.ayarlarToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaEkleToolStripMenuItem,
            this.firmaKaldırToolStripMenuItem,
            this.firmalarıGörüntüleToolStripMenuItem});
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.firmaToolStripMenuItem.Text = "Firma";
            // 
            // firmaEkleToolStripMenuItem
            // 
            this.firmaEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("firmaEkleToolStripMenuItem.Image")));
            this.firmaEkleToolStripMenuItem.Name = "firmaEkleToolStripMenuItem";
            this.firmaEkleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.firmaEkleToolStripMenuItem.Text = "Firma Ekle";
            this.firmaEkleToolStripMenuItem.Click += new System.EventHandler(this.firmaEkleToolStripMenuItem_Click);
            // 
            // firmaKaldırToolStripMenuItem
            // 
            this.firmaKaldırToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("firmaKaldırToolStripMenuItem.Image")));
            this.firmaKaldırToolStripMenuItem.Name = "firmaKaldırToolStripMenuItem";
            this.firmaKaldırToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.firmaKaldırToolStripMenuItem.Text = "Firma Kaldır";
            this.firmaKaldırToolStripMenuItem.Click += new System.EventHandler(this.firmaKaldırToolStripMenuItem_Click);
            // 
            // firmalarıGörüntüleToolStripMenuItem
            // 
            this.firmalarıGörüntüleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("firmalarıGörüntüleToolStripMenuItem.Image")));
            this.firmalarıGörüntüleToolStripMenuItem.Name = "firmalarıGörüntüleToolStripMenuItem";
            this.firmalarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.firmalarıGörüntüleToolStripMenuItem.Text = "Firmaları görüntüle";
            this.firmalarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.firmalarıGörüntüleToolStripMenuItem_Click);
            // 
            // evraklarToolStripMenuItem
            // 
            this.evraklarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimleriGörüntüleToolStripMenuItem});
            this.evraklarToolStripMenuItem.Name = "evraklarToolStripMenuItem";
            this.evraklarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.evraklarToolStripMenuItem.Text = "Evraklar";
            // 
            // resimleriGörüntüleToolStripMenuItem
            // 
            this.resimleriGörüntüleToolStripMenuItem.Name = "resimleriGörüntüleToolStripMenuItem";
            this.resimleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.resimleriGörüntüleToolStripMenuItem.Text = "Tüm Resimleri Görüntüle";
            this.resimleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.resimleriGörüntüleToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem1
            // 
            this.ayarlarToolStripMenuItem1.Name = "ayarlarToolStripMenuItem1";
            this.ayarlarToolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.ayarlarToolStripMenuItem1.Text = "Son Ödemeler";
            this.ayarlarToolStripMenuItem1.Click += new System.EventHandler(this.ayarlarToolStripMenuItem1_Click);
            // 
            // ayarlarToolStripMenuItem2
            // 
            this.ayarlarToolStripMenuItem2.Name = "ayarlarToolStripMenuItem2";
            this.ayarlarToolStripMenuItem2.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem2.Text = "Ayarlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(768, 358);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Firma ismi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 189;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Borç";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 189;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ödenmiş";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 189;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kalan";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 189;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(457, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaKaldırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evraklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resimleriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem2;
    }
}

