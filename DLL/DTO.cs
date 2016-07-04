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
        List<Karte> karten = null;

        
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

        public List<Karte> KartenAuslesen()
        {
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Karten";

            OleDbDataReader dr = cmd.ExecuteReader();

            karten = new List<Karte>();

            while (dr.Read())
            {
                    Karte k = mkKarte(dr);
                    karten.Add(k);

              
            }

            con.Close();

            return karten;
        }

        private Karte mkKarte(OleDbDataReader dr)
        {
            Karte ka = new Karte();
            int i = 0;

          
        
            ka.ID = dr.GetInt32(i++);
            ka.set = dr.GetString(i++);
            ka.nummer = dr.GetInt32(i++);
            ka.bild = dr.GetString(i++);
            return ka;
        }

        public void KarteVergeben(Benutzer utzi)
        {
            con.Open();

            List<Karte> k = KartenAuslesen();
            Random r = new Random();
            int i = r.Next(1,k.Count);

            while(i%5 == 0)
                i = r.Next(1, k.Count);

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Benutzer_Karten values(null," + utzi.ID + "," + i + ")";
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public List<Kartenset> mkSet(List<Karte> kartenliste)
        {

            List<Kartenset> ks = new List<Kartenset>();
            Kartenset set = new Kartenset();
            int i = 0;

            while (i < kartenliste.Count()) {

                set.karten.Add(kartenliste.ElementAt(i));


                //Die 5. Karte in der Datenbank ist die Setkarte

                if ((i+1) % 5 == 0)
                {
                    set.name = kartenliste.ElementAt(i).set;
                    set.bild = kartenliste.ElementAt(i).bild;

                    ks.Add(set);

                    set = new Kartenset();
                }

                i++;
            }

            return ks;
        }

        public List<Kartenset> SetsAnzeigen()
        {
            throw new NotImplementedException();
        }
    }
 }

