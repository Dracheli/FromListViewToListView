using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Xml.Serialization;

namespace FromListViewToListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variablen
        Datenbank db;
        OleDbDataReader dr;
        string sql;

        ListViewItem lvItem;

        XmlSerializer serializer;
        List<Auto> autos;

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            serializer = new XmlSerializer(typeof(List<Auto>));
            autos = new List<Auto>();
            db = new Datenbank();

            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
        }

        #region Methoden
        private void einsRechts()
        {
           if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Kein Auto ausgewählt!");
                return;
            }
            lvItem = listView1.SelectedItems[0];
            int inde = lvItem.Index;
            listView1.Items.RemoveAt(inde);
            listView2.Items.Add(lvItem);
        }

        private void einsLinks()
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Kein Auto ausgewählt!");
                return;
            }
            lvItem = listView2.SelectedItems[0];
            int inde = lvItem.Index;
            listView2.Items.RemoveAt(inde);
            listView1.Items.Add(lvItem);
        }

        private void alleRechts()
        {
            int anzahl = listView1.Items.Count;
            for(int i = 0; i<anzahl; i++)
            {
                lvItem = listView1.Items[0]; // 1 Item wird lvitem übergeben
                listView1.Items.RemoveAt(0);    // erstes/ausgewähltes Item wird gelöscht
                listView2.Items.Add(lvItem);    // lvItem wird bei lv2 hinzugefügt
            }
        }

        private void alleLinks()
        {
            int anzahl = listView2.Items.Count;
            for (int i = 0; i < anzahl; i++)
            {
                lvItem = listView2.Items[0]; // 1 Item wird lvitem übergeben
                listView2.Items.RemoveAt(0);        // erstes/ausgewähltes Item wird gelöscht
                listView1.Items.Add(lvItem);     // lvItem wird bei lv2 hinzugefügt
            }
        }
        #endregion

        private void btnDBLesen_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            sql = "Select * from Auto;";
            dr = db.einlesen(sql);
            while(dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());   // liest jede zeile - data reader 0 ist erste spalte
                lvItem.SubItems.Add(dr[1].ToString());
                lvItem.SubItems.Add(dr[2].ToString());
                lvItem.SubItems.Add(dr[3].ToString());
                lvItem.SubItems.Add(dr[4].ToString());
                listView2.Items.Add(lvItem);
            }
        }

        private void btnLv2Clear_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }

        private void btnLv2ItemClear_Click(object sender, EventArgs e)
        {
            if(listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie einen Eintrag aus!");
                return;
            }

            int anz = listView2.Items.Count;
            for (int i=0; i<anz;i++)
            {
                if(listView2.Items[i].Selected == true)
                {
                    listView2.Items.RemoveAt(i);
                    anz--;
                    i--;
                }
            }
        }

        private void btnDBSpeichern_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView2.Items.Count; i++)
            {
                lvItem = listView2.Items[i];
                string kennz = lvItem.SubItems[0].Text; //item hernehmen, zerlegen und dann sql befehl
                string marke = lvItem.SubItems[1].Text;
                string type = lvItem.SubItems[2].Text;
                string farbe = lvItem.SubItems[3].Text;
                int ps = Convert.ToInt32(lvItem.SubItems[4].Text);

                sql = "INSERT INTO Auto (Kennzeichen, Marke, Type, Farbe, PS) " +
                    " values ('"+kennz+"', '"+marke+"', '"+type+"', '"+farbe+"', "+ps+");";
                db.ausfuehren(sql);
            }

            MessageBox.Show("Speichern erfolgreich!");
            listView2.Items.Clear();
            //oder alternativ neu einlesen
        }

        #region Links/Rechts
        private void btnEinsRechts_Click(object sender, EventArgs e)
        {
            einsRechts();
        }

        private void btnEinsLinks_Click(object sender, EventArgs e)
        {
            einsLinks();
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            einsLinks();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            einsRechts();
        }

        private void btnAlleRechts_Click(object sender, EventArgs e)
        {
            alleRechts();
        }

        private void btnAlleLinks_Click(object sender, EventArgs e)
        {
            alleLinks();
        }
        #endregion

        private void btnLv1Clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnLv1ItemClear_Click(object sender, EventArgs e)
        {
            // auch möglich
            for(int i = listView1.SelectedIndices.Count - 1; i>= 0; i--)
            {
                int item = listView1.SelectedIndices[i];
                listView1.Items.RemoveAt(item);
            }

            //if (listView1.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Bitte wählen Sie einen Eintrag aus!");
            //    return;
            //}

            //int anz = listView1.Items.Count;
            //for (int i = 0; i < anz; i++)
            //{
            //    if (listView1.Items[i].Selected == true)
            //    {
            //        listView1.Items.RemoveAt(i);
            //        anz--;
            //        i--;
            //    }
            //}
        }

        private void btnListeSpeichern_Click(object sender, EventArgs e)
        {
            autos.Clear();
            Auto a = new Auto();
            for(int i = 0; i<listView1.Items.Count; i++)
            {
                lvItem = listView1.Items[i];
                a.Kennzeichen = lvItem.SubItems[0].Text;
                a.Marke = lvItem.SubItems[1].Text;
                a.Type = lvItem.SubItems[2].Text;
                a.Farbe = lvItem.SubItems[3].Text;
                a.PS = Convert.ToInt32(lvItem.SubItems[4].Text);
                autos.Add(a);
            }

            try
            {
                FileStream fs = new FileStream(Application.StartupPath + "\\autos.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializer.Serialize(fs, autos);
                fs.Close();
                MessageBox.Show("Speichern erfolgreich!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListeLesen_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(Application.StartupPath + "\\autos.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                autos = (List<Auto>)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach(Auto a in autos)
            {
                lvItem = new ListViewItem(a.Kennzeichen);
                lvItem.SubItems.Add(a.Marke);
                lvItem.SubItems.Add(a.Type);
                lvItem.SubItems.Add(a.Farbe);
                lvItem.SubItems.Add(a.PS.ToString());
                listView1.Items.Add(lvItem);
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(txtKennzeichen.Text.Equals("") || txtMarke.Text.Equals("")|| txtType.Text.Equals(""))
            {
                MessageBox.Show("Bitte füle Sie sowohl Kennzeichen, Marke und Type aus!");
                return;
            }
            if(txtFarbe.Text.Equals("") || txtPS.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie sowohl Farbe als auch PS aus!");
                return;
            }

            int ps = 0;
            try
            {
                 ps = Convert.ToInt32(txtPS.Text);
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie bei PS nur eine Ganzzshl ein!");
            }
            

            if(rbDatenbank.Checked)
            {
                if(cbNeu.Checked)
                {
                    sql = "INSERT INTO Auto (Kennzeichen, Marke, Type, Farbe, PS) " +
                                " values ('" + txtKennzeichen.Text + "', '" + txtMarke.Text + "', '" + txtType.Text + 
                                     "', '" + txtFarbe.Text + "', " + ps + ");";

                    db.ausfuehren(sql);
                }
            }
            if(rbListe.Checked)
            {

            }
        }
    }
}
