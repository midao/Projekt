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
    public partial class Profil : Form
    {
        private Benutzer utzi;

        public Profil(Benutzer utzi)
        {
            InitializeComponent();
            this.utzi = utzi;
        }

    }
}
