using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelProjekt;
using DLL;

namespace Projekt2016
{
    public partial class Zahlenraten : Form

    {
        DTO dto = new DTO();

        TextBox[,] boxArray = new TextBox[10, 4];

        Nummer[] nummernArray = new Nummer[4];

     //   int[] nummernArray = new int[4];

        Label[,] labelArray = new Label[10,4];

        int a = 0;
        int c = 0;
        private Benutzer utzi;

        public Zahlenraten(Benutzer utzi)
        {
            InitializeComponent();
            Initialize();

            this.utzi = utzi;
        }

       

        private void Initialize()
        {
            // Generieren von 4 Random zahlen 
            Random r = new Random();


            for (int i = 0; i < 4; i++)

            {
                int ra = r.Next(1, 9);

            /*    while (nummernArray.Contains(ra))
                {
                     ra = r.Next(1, 9);

                }
*/
                nummernArray[i] = new Nummer( ra, false) ;

  


            }

        

            //Generieren der Textboxen + Label die Richtigkeit anzeigen


            for (int z = 0; z < 10; z++)

            {
                for (int s = 0; s < 4; s++)

                {
                    TextBox b = new TextBox();
                    b.Size = new System.Drawing.Size(50, 50);
                    Font f = new System.Drawing.Font("Microsoft Sans Serif", 30F);
                    b.MaxLength = 1;
                    if (z != 0)

                    { b.Enabled = false; }
                    
                     tableLayoutPanel1.Controls.Add(b, s, z);

                    Label l = new Label();

                    tableLayoutPanel2.Controls.Add(l, s, z);
                    boxArray[z, s] = b;
                    labelArray[z, s] = l;

                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(texBoxCheck()) { 
            vergleichen();



                if (korrekt())
                {
                    MessageBox.Show("Glückwunsch! Du hast Gewonnen!");


                    for (int t = 0; t < 4; t++)
                    {
                        boxArray[a, t].Enabled = false;

                        dto.KarteVergeben(utzi);

                    }



                }

                else { 
                for (int t = 0; t < 4; t++)
                {


                    

                   

                        if (a < 9)
                        {
                            boxArray[a, t].Enabled = false;
                            boxArray[a + 1, t].Enabled = true;



                        }



                        else {

                            MessageBox.Show("Pech gehabt! Du hast verloren.");
                        }

                    }
                }


            a++;
            c = 0;


            }
        }

        private bool korrekt()
        {
            int x = 0;

            for (int i = 0; i < 4; i++)
            {

                if (nummernArray[i].status == true)
                {

                    x++;
                    nummernArray[i].status = false;
                }

                


            }

            if (x == 4)
            {

                

                return true;
            }

            else
                return false;
        }

        private bool texBoxCheck()
        {

            for(int i = 0; i < 4; i++)
            {

               if (String.IsNullOrEmpty(boxArray[a, i].Text))
                {
                    MessageBox.Show("Geben sie in jedes Feld eine Zahl ein!");

                    return false;

                }
            }

            return true;
           
        }

        private void vergleichen()
        {
            for (int j = 0; j < 4; j++)
            {



                if (boxArray[a, j].Text == nummernArray[j].ziffer.ToString())
                {
                    labelArray[a, c].Text = "■";
                    labelArray[a, c].ForeColor = Color.Red;
                    c++;

                    nummernArray[j].status = true;


                }

            }

            for (int j = 0; j < 4; j++)

            {

                for (int z = 0; z < 4; z++)
                {

                    if ((boxArray[a, j].Text == nummernArray[z].ziffer.ToString()) && (nummernArray[z].status == false))
                    {
                        labelArray[a, c].Text = "■";
                        labelArray[a, c].ForeColor = Color.Gray;
                        c++;

                    }

                }


            }
        }
    }
    }

