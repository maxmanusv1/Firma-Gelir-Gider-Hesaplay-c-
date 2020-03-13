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
using System.Drawing.Imaging;
using System.Threading;

namespace MuhOdemeApp
{
    public partial class verigir : Form
    {
        public verigir()
        {
            InitializeComponent();
        }

        private void verigir_Load(object sender, EventArgs e)
        {
            this.Text = firmagoruntule.gonderilecekveri;
        }
        public static string DosyaYolu;
        Bitmap image;
        string base64Text;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Resim dosyası |*.jpg;";
            openFile.Title = "Belgeyi seçiniz";
            openFile.ShowDialog();
            DosyaYolu = openFile.FileName;
            openFile.CheckFileExists = true;
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFile.FileName);
            pictureBox1.Image = (Image)image;

            byte[] imageArray = System.IO.File.ReadAllBytes(openFile.FileName);
            base64Text = Convert.ToBase64String(imageArray);
          
          }
        }
       /*
            public static string convertImageToBase64(string filenamewithpath)
            {
                var image = new Bitmap(filenamewithpath);
                Bitmap bm = new Bitmap(image);
                MemoryStream ms = new MemoryStream();
                bm.Save(ms, ImageFormat.Jpeg);
         
               return Convert.ToBase64String(ms.ToArray());
           
            }

            public static string convertBase64ToImage(string base64String, string filenamewithpath)
            {
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64String));
                Bitmap bm = new Bitmap(ms);
                bm.Save(filenamewithpath);

                return filenamewithpath;
            }*/
        

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\" + "Veri1.txt";
            FileStream fileStream = new FileStream(path,FileMode.Append,FileAccess.Write);
            StreamWriter stream = new StreamWriter(fileStream);

            stream.WriteLine(textBox1.Text+"*"+textBox2.Text+"*"+dateTimePicker1.Value.ToShortDateString()+"*"+DateTime.Now.Day+"."+DateTime.Now.Month+"."+DateTime.Now.Year+"*"+textBox3.Text);
            stream.Close();
            fileStream.Close();
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\Resimler\"+textBox3.Text+".txt" ;
            FileStream file = new FileStream(path2,FileMode.Create,FileAccess.Write);
            StreamWriter stream1 = new StreamWriter(file);
            stream1.Write(base64Text);
            stream1.Close();
            file.Close();
            this.Close();
            verigor verigor = new verigor();
            verigor.Show();
            MessageBox.Show("Başarılı");
        }
    }
}
