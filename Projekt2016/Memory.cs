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

namespace Projekt2016
{
    public partial class Memory : Form
    {
        private Benutzer utzi;
        Random loc = new Random();
        List<Point> location = new List<Point>(); // Speichert X und Y Werte
        PictureBox pic1, pic2; //Speichert ausgewählte Karten

        public Memory(Benutzer utzi)
        {
            InitializeComponent();

            this.utzi = utzi;
        }

        private void Memory_Load(object sender, EventArgs e)
        {
            foreach(PictureBox picture in panel1.Controls)
            {
               
                location.Add(picture.Location);
            }
            foreach (PictureBox picture in panel1.Controls) //Random location der Karten
            {
                int next = loc.Next(location.Count);
                Point p = location[next];
                picture.Location = p;
                location.Remove(p);
            }

            timer1.Start(); //Karten der Location zuweisen
            karte1.Image = Properties.Resources._57UKydQS;
            dupKarte1.Image = Properties.Resources._57UKydQS;
            Karte2.Image = Properties.Resources.google_dk_flat;
            dupKarte2.Image = Properties.Resources.google_dk_flat;
            Karte3.Image = Properties.Resources.huawei_logo_A8D49F5E99_seeklogo_com;
            dupKarte3.Image = Properties.Resources.huawei_logo_A8D49F5E99_seeklogo_com;
            Karte4.Image = Properties.Resources.motorola_logo_old_main;
            dupKarte4.Image = Properties.Resources.motorola_logo_old_main;
            Karte5.Image = Properties.Resources.Samsung_Logo;
            dupKarte5.Image = Properties.Resources.Samsung_Logo;
            Karte6.Image = Properties.Resources.Silhouette;
            dupKarte6.Image = Properties.Resources.Silhouette;
            Karte7.Image = Properties.Resources.sony_logo_amber;
            dupKarte7.Image = Properties.Resources.sony_logo_amber;
            Karte8.Image = Properties.Resources.unnamed;
            dupKarte8.Image = Properties.Resources.unnamed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox picture in panel1.Controls)
            {
                
                picture.Cursor = Cursors.Hand;
                timer1.Stop();
                picture.Image = Properties.Resources.rück;
            }
           
        }
        //Karten aufdecken und disable
        #region Karten
        private void karte1_Click(object sender, EventArgs e)
        {
            karte1.Image = Properties.Resources._57UKydQS;
            if(pic1 == null)
            {
                pic1 = karte1;
            }else if(pic1 != null && pic2 == null)
            {
                pic2 = karte1;
            }if(pic1 != null && pic2 != null)
            {
                if(pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    karte1.Enabled = false;
                    dupKarte1.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            
            }
        }

        private void dupKarte1_Click(object sender, EventArgs e)
        {
            dupKarte1.Image = Properties.Resources._57UKydQS;
            if (pic1 == null)
            {
                pic1 = dupKarte1;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = dupKarte1;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    karte1.Enabled = false;
                    dupKarte1.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
               
            }
        }

        private void Karte2_Click(object sender, EventArgs e)
        {
            Karte2.Image = Properties.Resources.google_dk_flat;
            if (pic1 == null)
            {
                pic1 = Karte2;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = Karte2;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte2.Enabled = false;
                    dupKarte2.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
           
            }
        }
    

        private void dupKarte2_Click(object sender, EventArgs e)
        {
            dupKarte2.Image = Properties.Resources.google_dk_flat;
            if (pic1 == null)
            {
                pic1 = dupKarte2;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = dupKarte2;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte2.Enabled = false;
                    dupKarte2.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
                
            }
        }


        private void Karte3_Click(object sender, EventArgs e)
        {
            Karte3.Image = Properties.Resources.huawei_logo_A8D49F5E99_seeklogo_com;
            if (pic1 == null)
            {
                pic1 = Karte3;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = Karte3;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte3.Enabled = false;
                    dupKarte3.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void dupKarte3_Click(object sender, EventArgs e)
        {
            dupKarte3.Image = Properties.Resources.huawei_logo_A8D49F5E99_seeklogo_com;
            if (pic1 == null)
            {
                pic1 = dupKarte3;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = dupKarte3;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte3.Enabled = false;
                    dupKarte3.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void Karte4_Click(object sender, EventArgs e)
        {
            Karte4.Image = Properties.Resources.motorola_logo_old_main;
            if (pic1 == null)
            {
                pic1 = Karte4;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = Karte4;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte4.Enabled = false;
                    dupKarte4.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void dupKarte4_Click(object sender, EventArgs e)
        {
            dupKarte4.Image = Properties.Resources.motorola_logo_old_main;
            if (pic1 == null)
            {
                pic1 = dupKarte4;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = dupKarte4;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte4.Enabled = false;
                    dupKarte4.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void Karte5_Click(object sender, EventArgs e)
        {
            Karte5.Image = Properties.Resources.Samsung_Logo;
            if (pic1 == null)
            {
                pic1 = Karte5;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = Karte5;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte5.Enabled = false;
                    dupKarte5.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void dupKarte5_Click(object sender, EventArgs e)
        {
            dupKarte5.Image = Properties.Resources.Samsung_Logo;
            if (pic1 == null)
            {
                pic1 = dupKarte5;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = dupKarte5;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte5.Enabled = false;
                    dupKarte5.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void Karte6_Click(object sender, EventArgs e)
        {
            Karte6.Image = Properties.Resources.Silhouette;
            if (pic1 == null)
            {
                pic1 = Karte6;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = Karte6;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte6.Enabled = false;
                    dupKarte6.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void dupKarte6_Click(object sender, EventArgs e)
        {
            dupKarte6.Image = Properties.Resources.Silhouette;
            if (pic1 == null)
            {
                pic1 = dupKarte6;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = dupKarte6;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte6.Enabled = false;
                    dupKarte6.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void Karte7_Click(object sender, EventArgs e)
        {
            Karte7.Image = Properties.Resources.sony_logo_amber;
            if (pic1 == null)
            {
                pic1 = Karte7;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = Karte7;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte7.Enabled = false;
                    dupKarte7.Enabled = false;

                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void dupKarte7_Click(object sender, EventArgs e)
        {
            dupKarte7.Image = Properties.Resources.sony_logo_amber;
            if (pic1 == null)
            {
                pic1 = dupKarte7;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = dupKarte7;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte7.Enabled = false;
                    dupKarte7.Enabled = false;

                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void Karte8_Click(object sender, EventArgs e)
        {
            Karte8.Image = Properties.Resources.unnamed;
            if (pic1 == null)
            {
                pic1 = Karte8;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = Karte8;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte8.Enabled = false;
                    dupKarte8.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }

        private void dupKarte8_Click(object sender, EventArgs e)
        {
            dupKarte8.Image = Properties.Resources.unnamed;
            if (pic1 == null)
            {
                pic1 = dupKarte8;
            }
            else if (pic1 != null && pic2 == null)
            {
                pic2 = dupKarte8;
            }
            if (pic1 != null && pic2 != null)
            {
                if (pic1.Tag == pic2.Tag)
                {
                    pic1 = null;
                    pic2 = null;
                    Karte8.Enabled = false;
                    dupKarte8.Enabled = false;
                }
                else
                {
                    timer2.Start();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            pic1.Image = Properties.Resources.rück;
            pic2.Image = Properties.Resources.rück;
            pic1 = null;
            pic2 = null;
        }
        #endregion
    }
}
