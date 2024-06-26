﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                // Espera 2 segundos para iniciar o sistema
                System.Threading.Thread.Sleep(5000);

                Invoke(new Action(() =>
                {
                    // Abre a tela Inicial
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    Hide();
                }));
            });

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void splash_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
