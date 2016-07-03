using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using ModelProjekt;

namespace DLL
{
    public class DTO : IDTO
    {
        OleDbConnection con = null;
        List<Benutzer> ben = null;

        
        public DTO()
        {

         
            OleDbConnectionStringBuilder bld = new OleDbConnectionStringBuilder();
            bld.Provider = "Microsoft.ACE.OLEDB.12.0";
            bld.DataSource = Properties.Settings.Default.DbPath;
            con = new OleDbConnection(bld.ConnectionString);
           
        }

        public bool BenutzerAnlegen()
        {
            throw new NotImplementedException();
        }

        public List<Benutzer> BenutzerAuslesen()
        {

            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Benutzerlsite";
          
            OleDbDataReader dr = cmd.ExecuteReader();

            ben = new List<Benutzer>();

                while (dr.Read())
                {
                try
                {
                    Benutzer utzer = mcBen(dr);
                    ben.Add(utzer);

                }
                catch (Exception) { }
                }

            con.Close();

            return ben;

           
        }

        public bool BenutzerÄndern()
        {
            throw new NotImplementedException();
        }

        public bool KartenAnzeigen()
        {
            throw new NotImplementedException();
        }

        public bool SetAnlegen()
        {
            throw new NotImplementedException();
        }

        public Benutzer mcBen(OleDbDataReader dr)
        {
            Benutzer utzer = new Benutzer();
            int i = 0;
            utzer.ID = dr.GetInt32(i++);
            utzer.Benutzername = dr.GetString(i++);
            utzer.Passwort = dr.GetString(i++);
            utzer.Punkte = dr.GetInt32(i++);
            return utzer;
        }
    }
 }

