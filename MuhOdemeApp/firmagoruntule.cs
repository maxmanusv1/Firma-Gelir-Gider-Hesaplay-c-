using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Microsoft.VisualBasic;

namespace MuhOdemeApp
{
    public partial class firmagoruntule : Form
    {
        private int rowIndex = 0;
        public firmagoruntule()
        {
            InitializeComponent();
        }

        private void firmagoruntule_Load(object sender, EventArgs e)
        {
          //  ArrayList arrayList = new ArrayList();
           
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\";
            DirectoryInfo di = new DirectoryInfo(path2);
            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo diNext in dirs)
            {
                dataGridView1.Rows.Add(diNext.ToString());
            }

            /*   DirectoryInfo directoryInfo = new DirectoryInfo(path2);
               foreach (FileInfo item in directoryInfo.GetFiles())
               {
                   string a = item.ToString();
                  // dataGridView1.Rows.Add(a.Remove(a.Length-4));//sondaki dosya uzantısını siler
               }
               */
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)//farenin sağ tuşuna basılmışsa
            {
                
            }
        }

        private void borçÖdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verigir verigir = new verigir();
            verigir.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // here we do not come although the contextmenustrip shows up under the mouse pointer
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                this.contextMenuStrip1.Show(this.dataGridView1, new Point(e.RowIndex, e.ColumnIndex));
            }
        }
        public static string gonderilecekveri;
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.dataGridView1.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[0];
                    this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                    gonderilecekveri = this.dataGridView1.CurrentCell.Value.ToString();

                }
            }
            catch (Exception hata)
            {
              
               
            }
                
          

            
        }
         private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
            }
        }

        private void paraİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void isimiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = Interaction.InputBox("İstenilen yeni firma ismini giriniz", "Firma", "Firma ismi", -1, -1);
            if (a!= "")
            {
                string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\FirmaMuh\Firmalar\"+gonderilecekveri+@"\";
                string path2= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + a+ @"\";
                DirectoryInfo f1 = new DirectoryInfo(path1);
                DirectoryInfo f2 = new DirectoryInfo(path2);
                f1.MoveTo(path2);
                //File.Move(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + gonderilecekveri +@"\" , Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + a +@"\");
                
              
            }
            
        }

        private void yapılanİşlemleriGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verigor verigor = new verigor();
            verigor.Show();
            this.Hide();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (verigor.FormAc==true)
            {
                verigor verigor = new verigor();
                verigor.Show();
            }
        }
    }
}
