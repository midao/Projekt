using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProjekt
{
   public  class Nummer
    {

        public int ziffer { get; set; }

  
        public bool status { get; set; }

        public Nummer (int ziffer, bool status)

        {

            this.ziffer = ziffer;
            this.status = status;

        }


    }
}
