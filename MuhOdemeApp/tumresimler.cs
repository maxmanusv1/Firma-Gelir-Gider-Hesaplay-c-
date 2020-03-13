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
    public partial class tumresimler : Form
    {
        public tumresimler()
        {
            InitializeComponent();
        }

        private void tumresimler_Load(object sender, EventArgs e)
        {
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\";
            DirectoryInfo di = new DirectoryInfo(path2);
            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo diNext in dirs)
            {
                dataGridView1.Rows.Add(diNext.ToString());
            }
            string path23 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + dataGridView1.CurrentCell.Value + @"\Resimler\";
            DirectoryInfo directoryInfo = new DirectoryInfo(path23);
            foreach (FileInfo item in directoryInfo.GetFiles())
            {
                string a = item.ToString();
                dataGridView2.Rows.Add(a.Remove(a.Length - 4));//sondaki dosya uzantısını siler
            }
            string base64String = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + dataGridView1.CurrentCell.Value + @"\Resimler\" + dataGridView2.CurrentCell.Value + ".txt");
            byte[] imgBytes = Convert.FromBase64String(base64String);

            using (var imageFile = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + dataGridView1.CurrentCell.Value + @"\Resimler\" + dataGridView2.CurrentCell.Value + ".jpg", FileMode.Create))
            {
                imageFile.Write(imgBytes, 0, imgBytes.Length);
                imageFile.Flush();
            }
            pictureBox1.ImageLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + dataGridView1.CurrentCell.Value + @"\Resimler\" + dataGridView2.CurrentCell.Value + ".jpg";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ClearSelection();
            string path23 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + dataGridView1.CurrentCell.Value + @"\Resimler\";
            DirectoryInfo directoryInfo = new DirectoryInfo(path23);
            dataGridView2.Rows.Clear();
            foreach (FileInfo item in directoryInfo.GetFiles("*.txt"))
            {
                string a = item.ToString();
              
                dataGridView2.Rows.Add(a.Remove(a.Length - 4));//sondaki dosya uzantısını siler
            }
             string[] files = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + dataGridView1.CurrentCell.Value+ @"\Resimler\", "*.jpg");

            foreach (string file in files)
            {
                System.IO.File.Delete(file);
            }
            pictureBox1.Image = null;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string base64String = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + dataGridView1.CurrentCell.Value + @"\Resimler\" + dataGridView2.CurrentCell.Value + ".txt");
            byte[] imgBytes = Convert.FromBase64String(base64String);

            using (var imageFile = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + dataGridView1.CurrentCell.Value + @"\Resimler\" + dataGridView2.CurrentCell.Value + ".jpg", FileMode.Create))
            {
                imageFile.Write(imgBytes, 0, imgBytes.Length);
                imageFile.Flush();
            }
            pictureBox1.ImageLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + dataGridView1.CurrentCell.Value + @"\Resimler\" + dataGridView2.CurrentCell.Value + ".jpg";
        }

        private void tumresimler_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i <dataGridView1.RowCount; i++)
            {
                string[] files = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" +dataGridView1.Rows[i].Cells[0].Value +@"\Resimler\", "*.jpg");

                foreach (string file in files)
                {
                    System.IO.File.Delete(file);
                }
            }
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
