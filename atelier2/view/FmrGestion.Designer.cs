﻿
namespace atelier2.view
{
    partial class FmrGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxPros = new System.Windows.Forms.GroupBox();
            this.btnProModifier = new System.Windows.Forms.Button();
            this.btnProSuprimer = new System.Windows.Forms.Button();
            this.dgvPerso = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxProSelect = new System.Windows.Forms.GroupBox();
            this.btnProAnnuler = new System.Windows.Forms.Button();
            this.btnProEnregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxService = new System.Windows.Forms.ComboBox();
            this.txtProTel = new System.Windows.Forms.TextBox();
            this.txtProMail = new System.Windows.Forms.TextBox();
            this.txtProPrenom = new System.Windows.Forms.TextBox();
            this.txtProNom = new System.Windows.Forms.TextBox();
            this.bntafficher = new System.Windows.Forms.Button();
            this.gbxAbsences = new System.Windows.Forms.GroupBox();
            this.btnAbsSuprimer = new System.Windows.Forms.Button();
            this.btnAbsModifier = new System.Windows.Forms.Button();
            this.dgvAbs = new System.Windows.Forms.DataGridView();
            this.gbxAbs = new System.Windows.Forms.GroupBox();
            this.btnAbsAnnuler = new System.Windows.Forms.Button();
            this.btnAbsEnregistrer = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.gbxPros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerso)).BeginInit();
            this.gbxProSelect.SuspendLayout();
            this.gbxAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbs)).BeginInit();
            this.gbxAbs.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPros
            // 
            this.gbxPros.Controls.Add(this.btnProModifier);
            this.gbxPros.Controls.Add(this.btnProSuprimer);
            this.gbxPros.Controls.Add(this.dgvPerso);
            this.gbxPros.Location = new System.Drawing.Point(29, 21);
            this.gbxPros.Name = "gbxPros";
            this.gbxPros.Size = new System.Drawing.Size(536, 357);
            this.gbxPros.TabIndex = 0;
            this.gbxPros.TabStop = false;
            this.gbxPros.Text = "le personnel";
            // 
            // btnProModifier
            // 
            this.btnProModifier.Location = new System.Drawing.Point(21, 307);
            this.btnProModifier.Name = "btnProModifier";
            this.btnProModifier.Size = new System.Drawing.Size(75, 23);
            this.btnProModifier.TabIndex = 3;
            this.btnProModifier.Text = "modifier";
            this.btnProModifier.UseVisualStyleBackColor = true;
            this.btnProModifier.Click += new System.EventHandler(this.BtnProModifier_Click_1);
            // 
            // btnProSuprimer
            // 
            this.btnProSuprimer.Location = new System.Drawing.Point(193, 307);
            this.btnProSuprimer.Name = "btnProSuprimer";
            this.btnProSuprimer.Size = new System.Drawing.Size(75, 23);
            this.btnProSuprimer.TabIndex = 2;
            this.btnProSuprimer.Text = "suprimer";
            this.btnProSuprimer.UseVisualStyleBackColor = true;
            this.btnProSuprimer.Click += new System.EventHandler(this.BtnProSuprimer_Click);
            // 
            // dgvPerso
            // 
            this.dgvPerso.AllowUserToAddRows = false;
            this.dgvPerso.AllowUserToDeleteRows = false;
            this.dgvPerso.AllowUserToResizeRows = false;
            this.dgvPerso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerso.Location = new System.Drawing.Point(6, 19);
            this.dgvPerso.MultiSelect = false;
            this.dgvPerso.Name = "dgvPerso";
            this.dgvPerso.RowHeadersVisible = false;
            this.dgvPerso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerso.Size = new System.Drawing.Size(524, 257);
            this.dgvPerso.TabIndex = 0;
            // 
            // gbxProSelect
            // 
            this.gbxProSelect.Controls.Add(this.btnProAnnuler);
            this.gbxProSelect.Controls.Add(this.btnProEnregistrer);
            this.gbxProSelect.Controls.Add(this.label5);
            this.gbxProSelect.Controls.Add(this.label4);
            this.gbxProSelect.Controls.Add(this.label3);
            this.gbxProSelect.Controls.Add(this.label2);
            this.gbxProSelect.Controls.Add(this.label1);
            this.gbxProSelect.Controls.Add(this.cbxService);
            this.gbxProSelect.Controls.Add(this.txtProTel);
            this.gbxProSelect.Controls.Add(this.txtProMail);
            this.gbxProSelect.Controls.Add(this.txtProPrenom);
            this.gbxProSelect.Controls.Add(this.txtProNom);
            this.gbxProSelect.Location = new System.Drawing.Point(29, 419);
            this.gbxProSelect.Name = "gbxProSelect";
            this.gbxProSelect.Size = new System.Drawing.Size(601, 219);
            this.gbxProSelect.TabIndex = 1;
            this.gbxProSelect.TabStop = false;
            this.gbxProSelect.Text = "ajouter un personnel";
            // 
            // btnProAnnuler
            // 
            this.btnProAnnuler.Location = new System.Drawing.Point(128, 172);
            this.btnProAnnuler.Name = "btnProAnnuler";
            this.btnProAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnProAnnuler.TabIndex = 11;
            this.btnProAnnuler.Text = "annuler";
            this.btnProAnnuler.UseVisualStyleBackColor = true;
            this.btnProAnnuler.Click += new System.EventHandler(this.BtnProAnnuler_Click);
            // 
            // btnProEnregistrer
            // 
            this.btnProEnregistrer.Location = new System.Drawing.Point(21, 172);
            this.btnProEnregistrer.Name = "btnProEnregistrer";
            this.btnProEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnProEnregistrer.TabIndex = 10;
            this.btnProEnregistrer.Text = "enregistrer";
            this.btnProEnregistrer.UseVisualStyleBackColor = true;
            this.btnProEnregistrer.Click += new System.EventHandler(this.BtnProEnregistrer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "nom";
            // 
            // cbxService
            // 
            this.cbxService.FormattingEnabled = true;
            this.cbxService.Location = new System.Drawing.Point(397, 147);
            this.cbxService.Name = "cbxService";
            this.cbxService.Size = new System.Drawing.Size(156, 21);
            this.cbxService.TabIndex = 4;
            // 
            // txtProTel
            // 
            this.txtProTel.Location = new System.Drawing.Point(397, 95);
            this.txtProTel.Name = "txtProTel";
            this.txtProTel.Size = new System.Drawing.Size(156, 20);
            this.txtProTel.TabIndex = 3;
            // 
            // txtProMail
            // 
            this.txtProMail.Location = new System.Drawing.Point(397, 53);
            this.txtProMail.Name = "txtProMail";
            this.txtProMail.Size = new System.Drawing.Size(156, 20);
            this.txtProMail.TabIndex = 2;
            // 
            // txtProPrenom
            // 
            this.txtProPrenom.Location = new System.Drawing.Point(98, 102);
            this.txtProPrenom.Name = "txtProPrenom";
            this.txtProPrenom.Size = new System.Drawing.Size(170, 20);
            this.txtProPrenom.TabIndex = 1;
            // 
            // txtProNom
            // 
            this.txtProNom.Location = new System.Drawing.Point(98, 53);
            this.txtProNom.Name = "txtProNom";
            this.txtProNom.Size = new System.Drawing.Size(170, 20);
            this.txtProNom.TabIndex = 0;
            // 
            // bntafficher
            // 
            this.bntafficher.Location = new System.Drawing.Point(600, 102);
            this.bntafficher.Name = "bntafficher";
            this.bntafficher.Size = new System.Drawing.Size(75, 110);
            this.bntafficher.TabIndex = 3;
            this.bntafficher.Text = "afficher absence(s)";
            this.bntafficher.UseVisualStyleBackColor = true;
            this.bntafficher.Click += new System.EventHandler(this.Bntafficher_Click);
            // 
            // gbxAbsences
            // 
            this.gbxAbsences.Controls.Add(this.btnAbsSuprimer);
            this.gbxAbsences.Controls.Add(this.btnAbsModifier);
            this.gbxAbsences.Controls.Add(this.dgvAbs);
            this.gbxAbsences.Location = new System.Drawing.Point(714, 21);
            this.gbxAbsences.Name = "gbxAbsences";
            this.gbxAbsences.Size = new System.Drawing.Size(412, 357);
            this.gbxAbsences.TabIndex = 5;
            this.gbxAbsences.TabStop = false;
            this.gbxAbsences.Text = "absences";
            // 
            // btnAbsSuprimer
            // 
            this.btnAbsSuprimer.Location = new System.Drawing.Point(282, 307);
            this.btnAbsSuprimer.Name = "btnAbsSuprimer";
            this.btnAbsSuprimer.Size = new System.Drawing.Size(75, 23);
            this.btnAbsSuprimer.TabIndex = 3;
            this.btnAbsSuprimer.Text = "suprimer";
            this.btnAbsSuprimer.UseVisualStyleBackColor = true;
            this.btnAbsSuprimer.Click += new System.EventHandler(this.BtnAbsSuprimer_Click);
            // 
            // btnAbsModifier
            // 
            this.btnAbsModifier.Location = new System.Drawing.Point(44, 307);
            this.btnAbsModifier.Name = "btnAbsModifier";
            this.btnAbsModifier.Size = new System.Drawing.Size(75, 23);
            this.btnAbsModifier.TabIndex = 2;
            this.btnAbsModifier.Text = "modifier";
            this.btnAbsModifier.UseVisualStyleBackColor = true;
            this.btnAbsModifier.Click += new System.EventHandler(this.BtnAbsModifier_Click);
            // 
            // dgvAbs
            // 
            this.dgvAbs.AllowUserToAddRows = false;
            this.dgvAbs.AllowUserToDeleteRows = false;
            this.dgvAbs.AllowUserToResizeRows = false;
            this.dgvAbs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbs.Location = new System.Drawing.Point(6, 19);
            this.dgvAbs.MultiSelect = false;
            this.dgvAbs.Name = "dgvAbs";
            this.dgvAbs.RowHeadersVisible = false;
            this.dgvAbs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbs.Size = new System.Drawing.Size(400, 248);
            this.dgvAbs.TabIndex = 0;
            // 
            // gbxAbs
            // 
            this.gbxAbs.Controls.Add(this.btnAbsAnnuler);
            this.gbxAbs.Controls.Add(this.btnAbsEnregistrer);
            this.gbxAbs.Controls.Add(this.dateTimePicker2);
            this.gbxAbs.Controls.Add(this.dateTimePicker1);
            this.gbxAbs.Controls.Add(this.label8);
            this.gbxAbs.Controls.Add(this.label7);
            this.gbxAbs.Controls.Add(this.label6);
            this.gbxAbs.Controls.Add(this.cbxMotif);
            this.gbxAbs.Location = new System.Drawing.Point(714, 419);
            this.gbxAbs.Name = "gbxAbs";
            this.gbxAbs.Size = new System.Drawing.Size(412, 219);
            this.gbxAbs.TabIndex = 6;
            this.gbxAbs.TabStop = false;
            this.gbxAbs.Text = "ajouter une absence";
            // 
            // btnAbsAnnuler
            // 
            this.btnAbsAnnuler.Location = new System.Drawing.Point(168, 172);
            this.btnAbsAnnuler.Name = "btnAbsAnnuler";
            this.btnAbsAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAbsAnnuler.TabIndex = 10;
            this.btnAbsAnnuler.Text = "annuler";
            this.btnAbsAnnuler.UseVisualStyleBackColor = true;
            this.btnAbsAnnuler.Click += new System.EventHandler(this.BtnAbsAnnuler_Click);
            // 
            // btnAbsEnregistrer
            // 
            this.btnAbsEnregistrer.Location = new System.Drawing.Point(49, 172);
            this.btnAbsEnregistrer.Name = "btnAbsEnregistrer";
            this.btnAbsEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnAbsEnregistrer.TabIndex = 9;
            this.btnAbsEnregistrer.Text = "enregistrer";
            this.btnAbsEnregistrer.UseVisualStyleBackColor = true;
            this.btnAbsEnregistrer.Click += new System.EventHandler(this.BtnAbsEnregistrer_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(145, 82);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "motif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "date de fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "date de debut";
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(144, 124);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(200, 21);
            this.cbxMotif.TabIndex = 2;
            // 
            // FmrGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1176, 686);
            this.Controls.Add(this.gbxAbs);
            this.Controls.Add(this.gbxAbsences);
            this.Controls.Add(this.bntafficher);
            this.Controls.Add(this.gbxProSelect);
            this.Controls.Add(this.gbxPros);
            this.Name = "FmrGestion";
            this.Text = "Gestionnaire personnel et absence";
            this.gbxPros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerso)).EndInit();
            this.gbxProSelect.ResumeLayout(false);
            this.gbxProSelect.PerformLayout();
            this.gbxAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbs)).EndInit();
            this.gbxAbs.ResumeLayout(false);
            this.gbxAbs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPros;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnProModifier;
        private System.Windows.Forms.Button btnProSuprimer;
        private System.Windows.Forms.DataGridView dgvPerso;
        private System.Windows.Forms.GroupBox gbxProSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxService;
        private System.Windows.Forms.TextBox txtProTel;
        private System.Windows.Forms.TextBox txtProMail;
        private System.Windows.Forms.TextBox txtProPrenom;
        private System.Windows.Forms.TextBox txtProNom;
        private System.Windows.Forms.Button bntafficher;
        private System.Windows.Forms.GroupBox gbxAbsences;
        private System.Windows.Forms.Button btnAbsSuprimer;
        private System.Windows.Forms.Button btnAbsModifier;
        private System.Windows.Forms.DataGridView dgvAbs;
        private System.Windows.Forms.GroupBox gbxAbs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnProAnnuler;
        private System.Windows.Forms.Button btnProEnregistrer;
        private System.Windows.Forms.Button btnAbsAnnuler;
        private System.Windows.Forms.Button btnAbsEnregistrer;
    }
}