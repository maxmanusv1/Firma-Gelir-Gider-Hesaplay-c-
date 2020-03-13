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
    public partial class verigor : Form
    {
        private int rowIndex = 0;
        private int value2 = 0;
        private int sonuc = 0;
        public verigor()
        {
            InitializeComponent();
        }
        public static bool FormAc = false;
     
        private void verigor_Load(object sender, EventArgs e)
        {
            FormAc = false;
            int sonuc = 0;
            int sonuc2 = 0;
            this.Text = firmagoruntule.gonderilecekveri;
            //   FileStream file = new FileStream(path,FileMode.Open,FileAccess.Read);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\" + "Veri1.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                string[] values;
                for (int i = 0; i < lines.Length; i++)
                {
                    values = lines[i].ToString().Split('*');
                    string[] row = new string[values.Length];

                    for (int d = 0; d < values.Length; d++)
                    {
                        row[d] = values[d].Trim();
                    }
                    dataGridView1.Rows.Add(row);
                }
                ArrayList array = new ArrayList();
                ArrayList array2 = new ArrayList();
                ArrayList array3 = new ArrayList();

                for (int z = 0; z < dataGridView1.RowCount; z++)
                {

                    //int deger1, deger2;
                    array.Add(dataGridView1.Rows[z].Cells[0].Value);

                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    array2.Add(dataGridView1.Rows[i].Cells[1].Value);
                }
                for (int c = 0; c < array.Count; c++)
                {
                    int deger1, deger2;
                    deger1 = Convert.ToInt32(array[c]);
                    deger2 = Convert.ToInt32(array2[c]);
                    sonuc = deger2 - deger1;
                    sonuc2 += sonuc;
                    dataGridView2.Rows.Add((deger2 - deger1).ToString());
                }
                for (int b = 0; b < dataGridView2.RowCount; b++)
                {
                    int value = int.Parse(dataGridView2.Rows[b].Cells[0].Value.ToString());

                    if (value < 0)
                    {
                        dataGridView2.Rows[b].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else if (value > 0)
                    {
                        dataGridView2.Rows[b].DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (value == 0)
                    {
                        dataGridView2.Rows[b].DefaultCellStyle.ForeColor = Color.Blue;
                    }
                }
                dataGridView2.Rows.Add("TOPLAM:");
                dataGridView2.Rows.Add(sonuc2.ToString());
                if (Convert.ToInt32(dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value) < 0)
                {
                    dataGridView2.Rows[dataGridView2.RowCount - 1].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (Convert.ToInt32(dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value) > 0)
                {
                    dataGridView2.Rows[dataGridView2.RowCount - 1].DefaultCellStyle.ForeColor = Color.Green;
                }
                else if (Convert.ToInt32(dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value) == 0)
                {
                    dataGridView2.Rows[dataGridView2.RowCount - 1].DefaultCellStyle.ForeColor = Color.Blue;
                }

                string path4 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\" + "G1.txt";
                FileStream file =new FileStream(path4,FileMode.Create,FileAccess.Write);
                StreamWriter stream1 = new StreamWriter(file);
                stream1.Write(dataGridView2.Rows[dataGridView2.RowCount-1].Cells[0].Value);
                stream1.Close();
                file.Close();
                ArrayList arrayList = new ArrayList();
                string path5 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\" + "Borc.txt";
                FileStream file1 = new FileStream(path5,FileMode.Create,FileAccess.Write);
                StreamWriter stream = new StreamWriter(file1);
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    arrayList.Add(dataGridView1.Rows[i].Cells[0].Value);
                }
                int deger = 0;
                foreach (var item in arrayList)
                {
                    deger +=Convert.ToInt32(item);
                }
                stream.Write(deger);
                stream.Close();
                file1.Close();

                ArrayList arrayList2 = new ArrayList();
                string path6 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\" + "Odenmis.txt";
                FileStream file2 = new FileStream(path6, FileMode.Create, FileAccess.Write);
                StreamWriter stream2 = new StreamWriter(file2);
                for (int a = 0; a < dataGridView1.RowCount; a++)
                {
                    arrayList2.Add(dataGridView1.Rows[a].Cells[1].Value);
                }
                int deger3 = 0;
                foreach (var tt in arrayList2)
                {
                    deger3 += Convert.ToInt32(tt);
                }
                stream2.Write(deger3);
                stream2.Close();
                file2.Close();
            }
            else
            {
                MessageBox.Show("kayıt oluşturun");
            }
            //for (int i = 0; i < dataGridView1.RowCount; i++)
            // {
            // MessageBox.Show(dataGridView1.Rows[i].Cells[i].Value.ToString());
            //MessageBox.Show(dataGridView1.RowCount.ToString());

            //          MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());
            //            MessageBox.Show(dataGridView1.Rows[0].Cells[1].Value.ToString());
            // }
          
           
        /*    for (int h = 0; h < dataGridView2.RowCount; h++)
            {
                array3.Add(dataGridView2.Rows[h].Cells[0].Value);

            }
            array3.Remove("TOPLAM:");
            for (int value22 = 0; value22 < array3.Count; value22++)
            {
                value2 += Convert.ToInt32(array[value22]);
            }
            dataGridView2.Rows.Add(value2.ToString());*/
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resimlerForm resimlerForm = new resimlerForm();
            resimlerForm.Show();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void işlemiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

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


                }
            }
            catch (Exception)
            {

                
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void borçÖdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sonuc2 = 0;
            ArrayList list =new ArrayList();
            string a = Interaction.InputBox("Ödenecek borç miktarını giriniz", "Ödeme", "", -1, -1);
            if (a != "")
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\Firmalar\" + this.Text + @"\" + "Veri1.txt";
                ArrayList oku = new ArrayList();
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    oku.Add(line);
                }
                reader.Close();
                file.Close();
                int b = dataGridView1.CurrentRow.Index;
                string selectedindex = oku[dataGridView1.CurrentCell.RowIndex].ToString();
                string eskivalue = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                string[] trimli = selectedindex.Split('*');
               
                int degis = Convert.ToInt32(a) + Convert.ToInt32(trimli[1]);

                // string son_value = selectedindex.Replace(eskivalue,a);
                //oku[dataGridView1.CurrentCell.RowIndex] = son_value;
                oku[dataGridView1.CurrentCell.RowIndex] = trimli[0] + "*" + degis + "*" + trimli[2] + "*" + trimli[3] + "*" + trimli[4];

                FileStream file2 = new FileStream(path,FileMode.Open,FileAccess.Write);
                StreamWriter writer = new StreamWriter(file2);
                for (int i = 0; i < oku.Count; i++)
                {
                    writer.WriteLine(oku[i]);
                }
                writer.Close();
                file2.Close();        
                this.Close();

                string path11 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\SonOdemeler.txt";
                FileStream fileStream = new FileStream(path11, FileMode.Append, FileAccess.Write);
                StreamWriter stream = new StreamWriter(fileStream);
                string FirmaIsmi = firmagoruntule.gonderilecekveri;
                stream.WriteLine(FirmaIsmi + "*" + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + "*" + a);
                stream.Close();
                fileStream.Close();
                /* string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\SonOdemeler.txt";
                 FileStream file1 = new FileStream(path1,FileMode.Append,FileAccess.Write);
                 StreamWriter stream = new StreamWriter(file1);
                 string FirmaIsmi = firmagoruntule.gonderilecekveri;
                 stream.WriteLine(FirmaIsmi+"*"+DateTime.Now.Day+"."+DateTime.Now.Month+"."+DateTime.Now.Year+"*"+a);
                 stream.Close();
                 file1.Close();*/
                FormAc = true;
                MessageBox.Show("Ödeme başarılı ");
                
            }
            
                       
        }
        Font baslik = new Font("Century Gothic", 25, FontStyle.Bold);
        Font yazi = new Font("Century Gothic",11,FontStyle.Bold);
        Font ic_yazi = new Font("Century Gothic", 10);
        SolidBrush Brush = new SolidBrush(Color.Black);
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string test;
            int sayi = 190;
            int sayi2 = 85;
            ArrayList array = new ArrayList();
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString(this.Text,baslik,Brush,100,50);
            e.Graphics.DrawString("Ödenecek Tutar      Ödenmiş Tutar     Son Öd. Tarihi      Kayıt Tarihi      Başlığı          Kalan",yazi,Brush,85,150);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------",yazi,Brush,85,170);
            for (int S = 0; S < dataGridView1.RowCount; S++)
            {
                for (int i = 0; i < 5; i++)
                {
                    array.Add(dataGridView1.Rows[S].Cells[i].Value.ToString());
                    if (i==4)
                    {
                        int hesapla = Convert.ToInt32(array[1]) - Convert.ToInt32(array[0]);
                        e.Graphics.DrawString(array[0].ToString(),ic_yazi,Brush,85,sayi);
                        e.Graphics.DrawString(array[1].ToString(),ic_yazi,Brush,230,sayi);
                        e.Graphics.DrawString(array[2].ToString(),ic_yazi,Brush,350,sayi);
                        e.Graphics.DrawString(array[3].ToString(),ic_yazi,Brush,480,sayi);
                        e.Graphics.DrawString(array[4].ToString(),ic_yazi,Brush,590,sayi);
                        e.Graphics.DrawString(hesapla.ToString(),ic_yazi,Brush,700,sayi);
                        sayi += 20;
                        /*
                        sayi2 = 85;
                      
                        for (int d = 0; d < array.Count; d++)
                        {
                            
                            e.Graphics.DrawString(array[d].ToString(),ic_yazi,Brush,sayi2,sayi);
                            sayi2 += 130;
                            
                        }
                        sayi += 20;

                        /*   int hesapla;
                           hesapla = Convert.ToInt32(array[0])-Convert.ToInt32(array[1]);
                           test = array[0] + "                             " + array[1] + "                        " + array[2] + "               " + array[3] + "             " + array[4] + "              " + hesapla.ToString(); 
                           e.Graphics.DrawString(test,yazi,Brush,85,sayi);*/
                        array.Clear();
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }
    }
}
