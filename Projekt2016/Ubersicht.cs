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
    public partial class Ubersicht : Form
    {
        private Benutzer utzi;


        public Ubersicht(Benutzer utzi)
        {
            InitializeComponent();
            this.utzi = utzi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profil p = new Profil(utzi);
            p.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sets s = new Sets();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zahlenraten z = new Zahlenraten(utzi);
            z.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Memory m = new Memory(utzi);
            m.Show();
        }
    }
}
