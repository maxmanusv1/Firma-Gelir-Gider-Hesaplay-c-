namespace MuhOdemeApp
{
    partial class firmagoruntule
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraislemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yapılanİşlemleriGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(726, 273);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Firma ismi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 726;
            // 
            // isimiDeğiştirToolStripMenuItem
            // 
            this.isimiDeğiştirToolStripMenuItem.Name = "isimiDeğiştirToolStripMenuItem";
            this.isimiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.isimiDeğiştirToolStripMenuItem.Text = "İsimi Değiştir";
            this.isimiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.isimiDeğiştirToolStripMenuItem_Click);
            // 
            // paraislemleriToolStripMenuItem
            // 
            this.paraislemleriToolStripMenuItem.Name = "paraislemleriToolStripMenuItem";
            this.paraislemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paraislemleriToolStripMenuItem.Text = "Para islemleri";
            this.paraislemleriToolStripMenuItem.Click += new System.EventHandler(this.borçÖdeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isimiDeğiştirToolStripMenuItem,
            this.paraislemleriToolStripMenuItem,
            this.yapılanİşlemleriGörToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Text = "İşlem yap";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // yapılanİşlemleriGörToolStripMenuItem
            // 
            this.yapılanİşlemleriGörToolStripMenuItem.Name = "yapılanİşlemleriGörToolStripMenuItem";
            this.yapılanİşlemleriGörToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yapılanİşlemleriGörToolStripMenuItem.Text = "Yapılan işlemleri gör";
            this.yapılanİşlemleriGörToolStripMenuItem.Click += new System.EventHandler(this.yapılanİşlemleriGörToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // firmagoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 273);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "firmagoruntule";
            this.ShowIcon = false;
            this.Text = "Firmaları görüntüle";
            this.Load += new System.EventHandler(this.firmagoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ToolStripMenuItem isimiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraislemleriToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yapılanİşlemleriGörToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}