using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;
using ModelProjekt;

namespace Projekt2016
{
    public partial class Sets : Form
    {

        DTO dto = null;
        List<Kartenset> ks = null;
        

        public Sets()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            dto = new DTO();

            
           ks =  dto.mkSet(dto.KartenAuslesen());

            PictureBox[] bildArray = new PictureBox[ks.Count];

            int i = 0;

            while(i < ks.Count)
            {
               

                String s = Properties.Settings.Default.BilderPfad + ks.ElementAt(i).bild;
                bildArray[i].Image = Image.FromFile(s);

            }

        }
    }
}
