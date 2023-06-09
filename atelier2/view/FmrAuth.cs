﻿using atelier2.controller;
using System;
using System.Windows.Forms;

namespace atelier2
{
    /// <summary>
    /// Fenêtre de connection
    /// </summary>
    public partial class FmrAuth : Form
    {
        private FmrAuthController controller;

        /// <summary>
        /// construction des composants graphiques 
        /// </summary>
        public FmrAuth()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            txtLogin.Text = "";
            txtPwd.Text = "";
            controller = new FmrAuthController();
        }

        /// <summary>
        /// Demande de connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnec_Click(object sender, EventArgs e)
        {
            if (controller.GetLaConnection(txtLogin.Text, txtPwd.Text))
                this.Visible = false;
            lblconnec.Text = "Mauvais mot de passe ou login utilisateur";
            txtLogin.Text = "";
            txtPwd.Text = "";
        }
    }
}
