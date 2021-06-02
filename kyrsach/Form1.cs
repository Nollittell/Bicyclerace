using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsach
{
    public partial class Form1 : Form
    {
        private const string V = "Страны";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IFED.Visible = true;
            eas.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void button1_Click_1(object sender, EventArgs e)
        {
            KolSB.Enabled = false;
            KolAB.Enabled = false;
            NStran.Visible = true;
            ENDV.Visible = true;
            Vodst.Visible = true;
            KolA.Enabled = false;
            KolS.Enabled = false;
            Vodst.ColumnCount = 2;
            Program. s = int.Parse(KolS.Text);
            Program. n = int.Parse(KolA.Text);
            Vodst.RowCount = Program.s + 1;
            Vodst[1, 0].Value= "Страна";
            Vodst[1, 0].ReadOnly = true ;
            for (int i = 1; i < Vodst.Rows.Count; i++)
            {
                Vodst[0, i].Value = i;
                Vodst[0, i].ReadOnly = true;

            }
            
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void KollSB_Click(object sender, EventArgs e)
        {
            KOLAL.Visible = true;
            KolA.Visible = true;
            KolAB.Visible = true;
        }

        private void ENDV_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            dal2.Visible = true;
            ENDV.Enabled = false;
            Program.stran = new Sportsmen[Program.s];
            for (int i = 0; i < Program.s; i++)
               
            { 
                Program.stran[i] = new Sportsmen();
                Program.stran[i].chas1 = new int[Program.n];
                Program.stran[i].min1 = new int[Program.n];
                Program.stran[i].sek1 = new int[Program.n];
                Program.stran[i].chas2 = new int[Program.n];
                Program.stran[i].min2 = new int[Program.n];
                Program.stran[i].sek2 = new int[Program.n];
                Program.stran[i].chas3 = new int[Program.n];
                Program.stran[i].min3 = new int[Program.n];
                Program.stran[i].sek3 = new int[Program.n];
                Program.stran[i].chas4 = new int[Program.n];
                Program.stran[i].min4 = new int[Program.n];
                Program.stran[i].sek4 = new int[Program.n];
                Program.stran[i].summabrs = new int[4];
                Program.stran[i].summabrm = new int[4];
                Program.stran[i].summabrc = new int[4];
                Program.stran[i].summabrych = new int[4];
                Program.stran[i].pesultsatapov = new int[Program.n,3];
                Program.stran[i].Name = (string)Vodst[1,i+1].Value;
                Program.znachen = new int[Program.s,Program.n*2];
                Program.stran[i].resutssek = new int[Program.n];
                Program.stran[i].minimum = new int[Program.n];
                Program.stran[i].vrych = new int[4, Program.n];
                Program.stran[i].mesta = new int[Program.n];
                Program.mestasort = new int[Program.s, 2];

            }


            tabControl1.SelectedIndex++;
            Vodat.Visible = true;
            Vodat.RowCount = Program.s *4+1;
            Vodat.ColumnCount =Program.n*4+2;

           // Vodat[3, 1] = new DataGridViewComboBoxCell();
           for (int i=2; i< Program.n * 4 + 2; i=i+4)
                for(int j=1; j< Program.s * 4 + 1; j++)
                {
                    Vodat[i+1, j] = new DataGridViewComboBoxCell();
                    (Vodat[i + 1, j] as DataGridViewComboBoxCell).Items.AddRange("0", "1", "2","3" , "4", "5", "6", "7", "8", "9" , "10","11", "12", "13", "14", "15", "16", "17", "18","19", "20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59"  );
                     Vodat[i+2, j] = new DataGridViewComboBoxCell();
                    (Vodat[i + 2, j] as DataGridViewComboBoxCell).Items.AddRange("00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59");
                    Vodat[i + 3, j] = new DataGridViewComboBoxCell();
                    (Vodat[i + 3, j] as DataGridViewComboBoxCell).Items.AddRange("00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59");
                }
                          
            //dataGridView3[i, j] = new DataGridViewComboBoxCell();
            //(dataGridView3[i, j] as DataGridViewComboBoxCell).Items.Add("test");

            //Vodat.ColumnCount = 3;
            //Vodat.Columns.Add(new DataGridViewComboBoxColumn());
            //for (int i = 4; i < Program.n * 4 + 2; i++)
            //    Vodat.Columns.Add("test" + i.ToString(), "test" + i.ToString());
            Vodat[0, 0].Value = "Страна";
            Vodat[0, 0].ReadOnly = true;
            Vodat[1, 0].Value = "Участник";
            Vodat[1, 0].ReadOnly = true;
            for (int i = 1; i < Program.s*4+1; i = i + 1)
            {
                Vodat[1 , i].Value = i;
                Vodat[1, i].ReadOnly = true;
            }
            for (int i=2;i<Vodat.Columns.Count; i=i+4)
            {
                Vodat[i, 0].Value = "Этап";
                Vodat[i, 0].ReadOnly = true;
                Vodat[i+1, 0].Value = "Часов";
                Vodat[i + 1, 0].ReadOnly = true;
                Vodat[i+2, 0].Value = "Минут";
                Vodat[i + 2, 0].ReadOnly = true;
                Vodat[i+3, 0].Value = "Секунд";
                Vodat[i + 3, 0].ReadOnly = true;
            }
            int k = 0;
            for (int i = 2; i < Vodat.Columns.Count; i = i + 4)
            {
                k = k + 1;
                for (int j = 1; j < Program.s * 4 + 1; j++)
                    Vodat[i, j].Value = k;
            }
            int f = 0;
            for (int i = 1; i < Vodat.Rows.Count; i = i + 4)
            { Vodat[0, i].Value = Program.stran[f].Name;
               f++; 
              }
        }




        private void button1_Click_2(object sender, EventArgs e)
        {
            dal2.Enabled = false;
            button1.Visible = true;
            int at = 0; 
            for (int i = 2; i < Program.n * 4 + 2; i = i + 4)
            {
              int r = 0;
                    for (int j = 1; j < Program.s * 4 + 1; j = j + 4)
                    {
                        Program.stran[r].chas1[at] = int.Parse((string)Vodat[i + 1, j].Value);
                        Program.stran[r].chas2[at] = int.Parse((string)Vodat[i + 1, j + 1].Value);
                        Program.stran[r].chas3[at] = int.Parse((string)Vodat[i + 1, j + 2].Value);
                        Program.stran[r].chas4[at] = int.Parse((string)Vodat[i + 1, j + 3].Value);
                        Program.stran[r].min1[at] = int.Parse((string)Vodat[i + 2, j].Value);
                        Program.stran[r].min2[at] = int.Parse((string)Vodat[i + 2, j + 1].Value);
                        Program.stran[r].min3[at] = int.Parse((string)Vodat[i + 2, j + 2].Value);
                        Program.stran[r].min4[at] = int.Parse((string)Vodat[i + 2, j + 3].Value);
                        Program.stran[r].sek1[at] = int.Parse((string)Vodat[i + 3, j].Value);
                        Program.stran[r].sek2[at] = int.Parse((string)Vodat[i + 3, j + 1].Value);
                        Program.stran[r].sek3[at] = int.Parse((string)Vodat[i + 3, j + 2].Value);
                        Program.stran[r].sek4[at] = int.Parse((string)Vodat[i + 3, j + 3].Value);
                    r++;

                    }
                at++;
            }
            for (int i = 0; i < Program.s; i++)
            {

                Program.stran[i].Calc1();
                Program.stran[i].Calc2();
                Program.stran[i].Calc3();
                Program.stran[i].Calc4();
                Program.stran[i].Calc5();
                Program.stran[i].Calc6();
                Program.stran[i].Calc7();
                
            }
            for (int i = 0; i < Program.s; i++)
            {
                for (int k = 2; k < Program.n * 2; k = k + 2)
                {
                    Program.znachen[i, 0] = i;
                    Program.znachen[i, 1] = Program.stran[i].resutssek[0];
                    Program.znachen[i, k] = i;
                    Program.znachen[i, k + 1] = Program.stran[i].resutssek[k-1];
                }
            }

            for (int i = 0; i < Program.s; i++)
            {
                Program.stran[i].Calc8();
            }

                tabControl1.SelectedIndex++;


            attaps.ColumnCount = Program.n * 6;
            attaps.RowCount = Program.s + 1;
            int ata = 1;
            for (int i = 0; i < Program.n * 6; i = i + 6)
            {
                for (int j = 1; j < Program.s + 1; j++)
                {
                    attaps[i, 0].Value = "Этап";
                    attaps[i, 0].ReadOnly = true;
                    attaps[i + 1, 0].Value = "Место";
                    attaps[i + 1, 0].ReadOnly = true;
                    attaps[i + 2, 0].Value = "Страна";
                    attaps[i + 1, 0].ReadOnly = true;
                    attaps[i + 3, 0].Value = "Часы";
                    attaps[i + 3, 0].ReadOnly = true;
                    attaps[i + 4, 0].Value = "Минуты";
                    attaps[i + 4, 0].ReadOnly = true;
                    attaps[i + 5, 0].Value = "Секунды";
                    attaps[i + 5, 0].ReadOnly = true;
                    attaps[i, j].Value = ata;
                    attaps[i, j].ReadOnly = true;
                }
                ata++;
            }
            for (int i = 0; i < Program.n * 6; i = i + 6)
                for (int j = 1; j < Program.s + 1; j++)
                    attaps[i + 1, j].Value = j;
            
                    int help = 0; int u = 0;
            for (int i = 0; i < Program.n * 6; i = i + 6)
            {
                for (int j = 1; j < Program.s + 1; j++)
                {
                    attaps[i + 2, j].Value = Program.stran[Program.znachen[j - 1, u ]].Name;
                    attaps[i + 3, j].Value = Program.stran[Program.znachen[j - 1, u ]].pesultsatapov[help , 0];
                    attaps[i + 4, j].Value = Program.stran[Program.znachen[j - 1, u ]].pesultsatapov[help , 1];
                    attaps[i + 5, j].Value = Program.stran[Program.znachen[j - 1, u ]].pesultsatapov[help , 2];
                    Program.stran[Program.znachen[j - 1, u]].mesta[help] = j-1;
                }
                help++;
                u = u + 2;
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            tabControl1.SelectedIndex++;
            for (int i = 0; i < Program.s; i++)
            {
                Program.stran[i].Calc9();

            }
            for (int i = 0; i < Program.s; i++)
            {
                Program.mestasort[i, 0] = i;
                Program.mestasort[i, 1] = Program.stran[i].Zummamest;

            }
            for (int i = 0; i < Program.s; i++)
            {
                Program.stran[i].Calc11();
                Program.stran[i].Calc10();
            }

            itprot.RowCount = Program.s + 1;
            itprot.ColumnCount = 3;
            //for (int i = 1; i < Program.s + 1; i++)
                //itprot[0, i].Value = i;
            itprot[0, 0].Value = "Место";
            for (int i = 1; i < Program.s + 1; i++)
            itprot[0, i].Value = i;
            itprot[1, 0].Value = "Страна";
            itprot[2, 0].Value = "Сумма мест";
            for (int i = 1; i < 2; i++)
             for (int j = 1; j < Program.s + 1; j++)
               {
                   itprot[i, j].Value = Program.stran[Program.mestasort[j - 1, 0 ]].Name;
                   itprot[i+1, j].Value = Program.stran[Program.mestasort[j - 1, 0 ]].Zummamest;
                }
         
        }
    }
}
