using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProjekt;
using System.Data.OleDb;

namespace DLL
{
    public interface IDTO
    {
        List<Benutzer> BenutzerAuslesen();
        bool BenutzerAnlegen();
        bool BenutzerÄndern();
        List<Kartenset> SetsAnzeigen();
        bool KartenAnzeigen();
        Benutzer mcBen(OleDbDataReader dr);
    }
}
