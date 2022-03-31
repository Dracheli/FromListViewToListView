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

namespace FromListViewToListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Datenbank db;
        OleDbDataReader dr;
        string sql;

        ListViewItem lvItem;

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Datenbank();
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
        }

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

        }
    }
}
