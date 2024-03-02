﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthMate_UI.Screens
{
    public partial class Calories_Tracker : Form
    {
        public Calories_Tracker()
        {
            InitializeComponent();
        }

        private void Calories_Tracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_MenuEN main_menuEN = new Main_MenuEN();
            main_menuEN.Show();
        }

        private void Breakfast_Click(object sender, EventArgs e)
        {
            Breakfast breakfast = new Breakfast();
            breakfast.Show();
        }
    }
}
