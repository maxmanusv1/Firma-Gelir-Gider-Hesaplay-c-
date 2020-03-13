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
using System.Threading;
namespace MuhOdemeApp
{
    public partial class firmaekle : Form
    {
        public firmaekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + textBox1.Text + @"\";
            string path3 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + textBox1.Text + @"\Resimler";
            string path4 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + textBox1.Text+@"\G1.txt";
            string path5 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + textBox1.Text + @"\Borc.txt";
            string path6 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + textBox1.Text + @"\Odenmis.txt";
            string path7 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\SonOdemeler.txt";
            DirectoryInfo directory1 = new DirectoryInfo(path3);
            /*   string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + textBox1.Text+".txt";
               File.Create(path).Close();*/
            DirectoryInfo directory = new DirectoryInfo(path2);
           
            directory.Create();
            File.Create(path4).Close();
            File.Create(path5).Close();
            File.Create(path6).Close();
          //  File.Create(path7).Close();
            directory1.Create();
            MessageBox.Show("eklendi");
        }
    }
}
