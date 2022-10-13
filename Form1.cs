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

namespace souboryBin06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool JePrvocislo(int a)
        {
            bool jePrvocislo = false;
            for(int i = 3; i<=a/2&&!jePrvocislo;i++)
            {
                if(a%i==0)
                {
                    jePrvocislo = true;
                }
            }
            return jePrvocislo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                //FileStream fs1 = new FileStream(saveFileDialog1.FileName, FileMode.Open, FileAccess.Write);
                BinaryReader br = new BinaryReader(fs);
                //BinaryWriter bw = new BinaryWriter(fs1);
                while (br.BaseStream.Position < br.BaseStream.Length)
                {
                    int cislo = br.ReadInt32();
                    listBox1.Items.Add(cislo);
                }
            }
        }
    }
}
