using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // erlaubt auf Access zuzugreifen
using System.Data;

namespace FromListViewToListView
{
    public class Datenbank
    {
        private OleDbConnection verbindung;
        private OleDbCommand cmd;
        private string cn;

        public Datenbank()
        {
            cn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Autos.accdb";
            //cn = "Provider = Microsoft.JET.OLEDB.4.0; Data Source = Autos.mdb";
            verbindung = new OleDbConnection(cn);
            verbindung.Open();
        }

        public OleDbDataReader einlesen(string sql)
        {
            try
            {
                cmd = new OleDbCommand(sql, verbindung); // weiß auf welcher VERBINDUNG er den SQL befehlt ausführen soll
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Einlesen: " + ex.Message);
            }
        }

        public void ausfuehren(string sql)
        {
            try
            {
                cmd = new OleDbCommand(sql, verbindung); // weiß auf welcher VERBINDUNG er den SQL befehlt ausführen soll
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Ausführen: " + ex.Message);
            }
        }
    }
}
