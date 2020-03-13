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
namespace MuhOdemeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resimleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tumresimler tumresimler = new tumresimler();
            tumresimler.Show();
          /*  resimlerForm resimlerForm = new resimlerForm();
            resimlerForm.Show();*/
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
           
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\FirmaMuh";
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar";
            string path11 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\FirmaMuh\SonOdemeler.txt";
            this.Text = Environment.MachineName+" - "+Environment.UserName;
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo directory1 = new DirectoryInfo(path2);
            FileInfo file = new FileInfo(path11);
            ArrayList list = new ArrayList();

            //FileStream fileStream = new FileStream(path, FileMode.Create,FileAccess.ReadWrite);
            int sayac = 0;
            if (!File.Exists(path)) 
            {
                /*  StreamWriter stream = new StreamWriter(fileStream);
                  stream.Close();
                  fileStream.Close();*/
                directory.Create();
              // file.Create().Close();
                directory1.Create();
                
            }
        
            
              string path3 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\";
                DirectoryInfo di = new DirectoryInfo(path3);
                DirectoryInfo[] dirs = di.GetDirectories();
                foreach (DirectoryInfo diNext in dirs)
                {
                list.Add(diNext.ToString());
                    
            

                }
            for (int i = 0; i < list.Count; i++)
            {
                string path4 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\"+list[i]+@"\G1.txt";
                string path5 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + list[i] + @"\Borc.txt";
                string path6 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + list[i] + @"\Odenmis.txt";
                dataGridView1.Rows.Add(list[i].ToString(),File.ReadAllText(path5).ToString(),File.ReadAllText(path6).ToString(),File.ReadAllText(path4).ToString());
            }
          
   

            //  fileStream.Close();

        }

        private void firmaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firmaekle firmaekle = new firmaekle();
            firmaekle.Show();
        }

        private void firmalarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firmagoruntule firmagoruntule = new firmagoruntule();
            firmagoruntule.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void firmaKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firmakaldir firmakaldir = new firmakaldir();
            firmakaldir.Show();

        }

        private void ayarlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sonOdemeler sonOdemeler = new sonOdemeler();
            sonOdemeler.Show();
        }
    }
}
