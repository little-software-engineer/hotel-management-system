﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_dashboard.Height;
            panel_slide.Top = button_dashboard.Top;
        }

        private void button_guest_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_guest.Height;
            panel_slide.Top = button_guest.Top;

        }

        private void button_reception_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_reception.Height;
            panel_slide.Top = button_reception.Top;
        }

        private void button_room_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_room.Height;
            panel_slide.Top = button_room.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_logout.Height;
            panel_slide.Top = button_logout.Top;
        }
    }
}
