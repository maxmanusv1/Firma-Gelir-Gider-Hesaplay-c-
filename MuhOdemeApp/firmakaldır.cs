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
namespace MuhOdemeApp
{
    public partial class firmakaldir : Form
    {
        public firmakaldir()
        {
            InitializeComponent();
        }

        private void firmakaldir_Load(object sender, EventArgs e)
        {
            
                string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\";
                DirectoryInfo di = new DirectoryInfo(path2);
                DirectoryInfo[] dirs = di.GetDirectories();
                foreach (DirectoryInfo diNext in dirs)
                {
                    dataGridView1.Rows.Add(diNext.ToString());
                }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string  a = dataGridView1.CurrentCell.Value.ToString();
            DialogResult dialog = new DialogResult();
          dialog = MessageBox.Show(a+" Firmasını silmek istediginizden emin misiniz","Firma sil",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string path3 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\"+a;
                DirectoryInfo directory = new DirectoryInfo(path3);
                directory.Delete(true);
                MessageBox.Show("Firma kaldırıldı");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("İşlem iptal ediliyor");
            }
        }
    }
}
