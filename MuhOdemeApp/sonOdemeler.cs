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
    public partial class sonOdemeler : Form
    {
        public sonOdemeler()
        {
            InitializeComponent();
        }

        private void sonOdemeler_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FirmaMuh\SonOdemeler.txt";
            this.Text = "Son Odemeler";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                string[] values;
                if (lines.Length==0)
                {
                    MessageBox.Show("veri bulunamadı");
                }
                else { 
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
                }
            }
           
        }
    }
}
