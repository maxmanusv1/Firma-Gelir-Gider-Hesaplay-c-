using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace MuhOdemeApp
{
    public partial class resimlerForm : Form
    {
        public resimlerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Base64ToImage(textBox1.Text);
          
        }

        private void resimlerForm_Load(object sender, EventArgs e)
        {
            this.Text= firmagoruntule.gonderilecekveri;
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\"+this.Text+@"\Resimler\";
            DirectoryInfo directoryInfo = new DirectoryInfo(path2);
            foreach (FileInfo item in directoryInfo.GetFiles())
            {
                string a = item.ToString();
                dataGridView1.Rows.Add(a.Remove(a.Length-4));//sondaki dosya uzantısını siler
            }
            string base64String = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\Resimler\" + dataGridView1.CurrentCell.Value + ".txt");
            byte[] imgBytes = Convert.FromBase64String(base64String);

            using (var imageFile = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\Resimler\" + dataGridView1.CurrentCell.Value + ".jpg", FileMode.Create))
            {
                imageFile.Write(imgBytes, 0, imgBytes.Length);
                imageFile.Flush();
            }
            pictureBox1.ImageLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\Resimler\" + dataGridView1.CurrentCell.Value + ".jpg";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void resimlerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] files = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\Resimler\", "*.jpg");

            foreach (string file in files)
            {
                System.IO.File.Delete(file);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string base64String = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\Resimler\" + dataGridView1.CurrentCell.Value + ".txt");
            byte[] imgBytes = Convert.FromBase64String(base64String);

            using (var imageFile = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\Resimler\" + dataGridView1.CurrentCell.Value + ".jpg", FileMode.Create))
            {
                imageFile.Write(imgBytes, 0, imgBytes.Length);
                imageFile.Flush();
            }
            pictureBox1.ImageLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\Resimler\" + dataGridView1.CurrentCell.Value + ".jpg";
        }

        /* public Image Base64ToImage(string base64String)
         {
             // Convert base 64 string to byte[]
             byte[] imageBytes = Convert.FromBase64String(base64String);
             // Convert byte[] to Image
             using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
             {
                 Image image = Image.FromStream(ms, true);
                 pictureBox1.Image = image;
                  return image;
             }
         }*/
    }
}
