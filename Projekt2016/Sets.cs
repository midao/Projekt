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
using System.Resources;
using Projekt2016.Properties;

namespace Projekt2016
{
    public partial class Sets : Form
    {

        DTO dto = null;
        List<Kartenset> ks = new List<Kartenset>();


        

        public Sets()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            dto = new DTO();


            ks = dto.mkSet(dto.KartenAuslesen());

            PictureBox[] bildArray = new PictureBox[ks.Count];

            var ResourceManager =
    new System.Resources.ResourceManager(
        "YourAssembly.Properties.Resources",
        typeof(Resources).Assembly);
            int i = 0;

            while(i < ks.Count)
            {
                

                object obj = ResourceManager.GetObject(ks.ElementAt(i).bild);

                bildArray[i].Image = ((System.Drawing.Bitmap)(obj));


                
                i++;

            }

        }
    }
}
