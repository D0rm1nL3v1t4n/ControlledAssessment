﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class LeagueStats : Form
    {
        public LeagueStats()
        {
            InitializeComponent();
        }

        private void NavHome_Click(object sender, EventArgs e) => NavToHome();

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }
    }
}