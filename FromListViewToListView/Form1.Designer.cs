namespace FromListViewToListView
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKennzeichen = new System.Windows.Forms.TextBox();
            this.txtMarke = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtFarbe = new System.Windows.Forms.TextBox();
            this.txtPS = new System.Windows.Forms.TextBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.cbNeu = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbListe = new System.Windows.Forms.RadioButton();
            this.rbDatenbank = new System.Windows.Forms.RadioButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListeLesen = new System.Windows.Forms.Button();
            this.btnListeSpeichern = new System.Windows.Forms.Button();
            this.btnLv1Clear = new System.Windows.Forms.Button();
            this.btnLv1ItemClear = new System.Windows.Forms.Button();
            this.btnLv2ItemClear = new System.Windows.Forms.Button();
            this.btnLv2Clear = new System.Windows.Forms.Button();
            this.btnDBSpeichern = new System.Windows.Forms.Button();
            this.btnDBLesen = new System.Windows.Forms.Button();
            this.btnEinsRechts = new System.Windows.Forms.Button();
            this.btnEinsLinks = new System.Windows.Forms.Button();
            this.btnAlleRechts = new System.Windows.Forms.Button();
            this.btnAlleLinks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Khaki;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(401, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 333);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kennzeichen";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Marke";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Farbe";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kennzeichen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Farbe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "PS";
            // 
            // txtKennzeichen
            // 
            this.txtKennzeichen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKennzeichen.Location = new System.Drawing.Point(163, 89);
            this.txtKennzeichen.Name = "txtKennzeichen";
            this.txtKennzeichen.Size = new System.Drawing.Size(198, 27);
            this.txtKennzeichen.TabIndex = 6;
            // 
            // txtMarke
            // 
            this.txtMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarke.Location = new System.Drawing.Point(163, 133);
            this.txtMarke.Name = "txtMarke";
            this.txtMarke.Size = new System.Drawing.Size(198, 27);
            this.txtMarke.TabIndex = 7;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(163, 176);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(198, 27);
            this.txtType.TabIndex = 8;
            // 
            // txtFarbe
            // 
            this.txtFarbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFarbe.Location = new System.Drawing.Point(163, 227);
            this.txtFarbe.Name = "txtFarbe";
            this.txtFarbe.Size = new System.Drawing.Size(198, 27);
            this.txtFarbe.TabIndex = 9;
            // 
            // txtPS
            // 
            this.txtPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPS.Location = new System.Drawing.Point(163, 277);
            this.txtPS.Name = "txtPS";
            this.txtPS.Size = new System.Drawing.Size(198, 27);
            this.txtPS.TabIndex = 10;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(245, 462);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(116, 52);
            this.btnSpeichern.TabIndex = 11;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // cbNeu
            // 
            this.cbNeu.AutoSize = true;
            this.cbNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNeu.Location = new System.Drawing.Point(58, 482);
            this.cbNeu.Name = "cbNeu";
            this.cbNeu.Size = new System.Drawing.Size(61, 24);
            this.cbNeu.TabIndex = 12;
            this.cbNeu.Text = "Neu";
            this.cbNeu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDatenbank);
            this.groupBox1.Controls.Add(this.rbListe);
            this.groupBox1.Location = new System.Drawing.Point(52, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 118);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rbListe
            // 
            this.rbListe.AutoSize = true;
            this.rbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbListe.Location = new System.Drawing.Point(38, 25);
            this.rbListe.Name = "rbListe";
            this.rbListe.Size = new System.Drawing.Size(155, 24);
            this.rbListe.TabIndex = 0;
            this.rbListe.TabStop = true;
            this.rbListe.Text = "Liste/XML Autos";
            this.rbListe.UseVisualStyleBackColor = true;
            // 
            // rbDatenbank
            // 
            this.rbDatenbank.AutoSize = true;
            this.rbDatenbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDatenbank.Location = new System.Drawing.Point(38, 65);
            this.rbDatenbank.Name = "rbDatenbank";
            this.rbDatenbank.Size = new System.Drawing.Size(158, 24);
            this.rbDatenbank.TabIndex = 1;
            this.rbDatenbank.TabStop = true;
            this.rbDatenbank.Text = "Datenbank Autos";
            this.rbDatenbank.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.DarkSalmon;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(1005, 89);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(511, 333);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kennzeichen";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Marke";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Type";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Farbe";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "PS";
            // 
            // btnListeLesen
            // 
            this.btnListeLesen.BackColor = System.Drawing.Color.Khaki;
            this.btnListeLesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeLesen.Location = new System.Drawing.Point(401, 462);
            this.btnListeLesen.Name = "btnListeLesen";
            this.btnListeLesen.Size = new System.Drawing.Size(156, 52);
            this.btnListeLesen.TabIndex = 15;
            this.btnListeLesen.Text = "Aus Liste/XML Lesen";
            this.btnListeLesen.UseVisualStyleBackColor = false;
            // 
            // btnListeSpeichern
            // 
            this.btnListeSpeichern.BackColor = System.Drawing.Color.Khaki;
            this.btnListeSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeSpeichern.Location = new System.Drawing.Point(580, 462);
            this.btnListeSpeichern.Name = "btnListeSpeichern";
            this.btnListeSpeichern.Size = new System.Drawing.Size(156, 52);
            this.btnListeSpeichern.TabIndex = 16;
            this.btnListeSpeichern.Text = "In Liste/XML speichern";
            this.btnListeSpeichern.UseVisualStyleBackColor = false;
            // 
            // btnLv1Clear
            // 
            this.btnLv1Clear.BackColor = System.Drawing.Color.Khaki;
            this.btnLv1Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLv1Clear.Location = new System.Drawing.Point(756, 462);
            this.btnLv1Clear.Name = "btnLv1Clear";
            this.btnLv1Clear.Size = new System.Drawing.Size(156, 52);
            this.btnLv1Clear.TabIndex = 17;
            this.btnLv1Clear.Text = "LV Clear";
            this.btnLv1Clear.UseVisualStyleBackColor = false;
            // 
            // btnLv1ItemClear
            // 
            this.btnLv1ItemClear.BackColor = System.Drawing.Color.Khaki;
            this.btnLv1ItemClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLv1ItemClear.Location = new System.Drawing.Point(756, 536);
            this.btnLv1ItemClear.Name = "btnLv1ItemClear";
            this.btnLv1ItemClear.Size = new System.Drawing.Size(156, 52);
            this.btnLv1ItemClear.TabIndex = 18;
            this.btnLv1ItemClear.Text = "LvItem Clear";
            this.btnLv1ItemClear.UseVisualStyleBackColor = false;
            // 
            // btnLv2ItemClear
            // 
            this.btnLv2ItemClear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLv2ItemClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLv2ItemClear.Location = new System.Drawing.Point(1365, 536);
            this.btnLv2ItemClear.Name = "btnLv2ItemClear";
            this.btnLv2ItemClear.Size = new System.Drawing.Size(156, 52);
            this.btnLv2ItemClear.TabIndex = 22;
            this.btnLv2ItemClear.Text = "LvItem Clear";
            this.btnLv2ItemClear.UseVisualStyleBackColor = false;
            // 
            // btnLv2Clear
            // 
            this.btnLv2Clear.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLv2Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLv2Clear.Location = new System.Drawing.Point(1365, 462);
            this.btnLv2Clear.Name = "btnLv2Clear";
            this.btnLv2Clear.Size = new System.Drawing.Size(156, 52);
            this.btnLv2Clear.TabIndex = 21;
            this.btnLv2Clear.Text = "LV Clear";
            this.btnLv2Clear.UseVisualStyleBackColor = false;
            // 
            // btnDBSpeichern
            // 
            this.btnDBSpeichern.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDBSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBSpeichern.Location = new System.Drawing.Point(1189, 462);
            this.btnDBSpeichern.Name = "btnDBSpeichern";
            this.btnDBSpeichern.Size = new System.Drawing.Size(156, 52);
            this.btnDBSpeichern.TabIndex = 20;
            this.btnDBSpeichern.Text = "In Datenbank speichern";
            this.btnDBSpeichern.UseVisualStyleBackColor = false;
            // 
            // btnDBLesen
            // 
            this.btnDBLesen.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDBLesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBLesen.Location = new System.Drawing.Point(1010, 462);
            this.btnDBLesen.Name = "btnDBLesen";
            this.btnDBLesen.Size = new System.Drawing.Size(156, 52);
            this.btnDBLesen.TabIndex = 19;
            this.btnDBLesen.Text = "Aus Datenbank Lesen";
            this.btnDBLesen.UseVisualStyleBackColor = false;
            // 
            // btnEinsRechts
            // 
            this.btnEinsRechts.BackColor = System.Drawing.Color.LightGreen;
            this.btnEinsRechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinsRechts.Location = new System.Drawing.Point(918, 149);
            this.btnEinsRechts.Name = "btnEinsRechts";
            this.btnEinsRechts.Size = new System.Drawing.Size(78, 52);
            this.btnEinsRechts.TabIndex = 23;
            this.btnEinsRechts.Text = ">";
            this.btnEinsRechts.UseVisualStyleBackColor = false;
            // 
            // btnEinsLinks
            // 
            this.btnEinsLinks.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEinsLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinsLinks.Location = new System.Drawing.Point(918, 211);
            this.btnEinsLinks.Name = "btnEinsLinks";
            this.btnEinsLinks.Size = new System.Drawing.Size(78, 52);
            this.btnEinsLinks.TabIndex = 24;
            this.btnEinsLinks.Text = "<";
            this.btnEinsLinks.UseVisualStyleBackColor = false;
            // 
            // btnAlleRechts
            // 
            this.btnAlleRechts.BackColor = System.Drawing.Color.LightGreen;
            this.btnAlleRechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlleRechts.Location = new System.Drawing.Point(921, 269);
            this.btnAlleRechts.Name = "btnAlleRechts";
            this.btnAlleRechts.Size = new System.Drawing.Size(78, 52);
            this.btnAlleRechts.TabIndex = 25;
            this.btnAlleRechts.Text = ">>";
            this.btnAlleRechts.UseVisualStyleBackColor = false;
            // 
            // btnAlleLinks
            // 
            this.btnAlleLinks.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAlleLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlleLinks.Location = new System.Drawing.Point(921, 328);
            this.btnAlleLinks.Name = "btnAlleLinks";
            this.btnAlleLinks.Size = new System.Drawing.Size(78, 52);
            this.btnAlleLinks.TabIndex = 26;
            this.btnAlleLinks.Text = "<<";
            this.btnAlleLinks.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 657);
            this.Controls.Add(this.btnAlleLinks);
            this.Controls.Add(this.btnAlleRechts);
            this.Controls.Add(this.btnEinsLinks);
            this.Controls.Add(this.btnEinsRechts);
            this.Controls.Add(this.btnLv2ItemClear);
            this.Controls.Add(this.btnLv2Clear);
            this.Controls.Add(this.btnDBSpeichern);
            this.Controls.Add(this.btnDBLesen);
            this.Controls.Add(this.btnLv1ItemClear);
            this.Controls.Add(this.btnLv1Clear);
            this.Controls.Add(this.btnListeSpeichern);
            this.Controls.Add(this.btnListeLesen);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNeu);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtPS);
            this.Controls.Add(this.txtFarbe);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtMarke);
            this.Controls.Add(this.txtKennzeichen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "From ListView to ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKennzeichen;
        private System.Windows.Forms.TextBox txtMarke;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtFarbe;
        private System.Windows.Forms.TextBox txtPS;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.CheckBox cbNeu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDatenbank;
        private System.Windows.Forms.RadioButton rbListe;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnListeLesen;
        private System.Windows.Forms.Button btnListeSpeichern;
        private System.Windows.Forms.Button btnLv1Clear;
        private System.Windows.Forms.Button btnLv1ItemClear;
        private System.Windows.Forms.Button btnLv2ItemClear;
        private System.Windows.Forms.Button btnLv2Clear;
        private System.Windows.Forms.Button btnDBSpeichern;
        private System.Windows.Forms.Button btnDBLesen;
        private System.Windows.Forms.Button btnEinsRechts;
        private System.Windows.Forms.Button btnEinsLinks;
        private System.Windows.Forms.Button btnAlleRechts;
        private System.Windows.Forms.Button btnAlleLinks;
    }
}

