using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Lanterna
{
    public partial class Lanterna : Form
    {
        public Lanterna()
        {
            InitializeComponent();
        }
        private void Ligado_Click(object sender, EventArgs e)
        {
            this.Ligado.BackColor = Color.ForestGreen;
            this.Desligado.BackColor = Color.White;
            this.Status.Text = "LIGADO";
            this.Status.BackColor = Color.ForestGreen;
            this.Status.Padding = new System.Windows.Forms.Padding(58, 10, 60, 20);
        }
        private void Desligado_Click(object sender, EventArgs e)
        {
            this.Ligado.BackColor = Color.White;
            this.Desligado.BackColor = Color.Red;
            this.Status.Text = "DESLIGADO";
            this.Status.BackColor = Color.Red;
            this.Status.Padding = new System.Windows.Forms.Padding(28, 10, 10, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Status.Text != "DESLIGADO" && Bateria.Value != 0)
            {
                this.Bateria.Value -= 1;
                this.PercentualBateria.Text = Bateria.Value.ToString() + "%";
            }
            if (Bateria.Value ==0)
            {
                this.Ligado.BackColor = Color.White;
                this.Desligado.BackColor = Color.Red;
                this.Status.Text = "DESLIGADO";
                this.Status.BackColor = Color.Red;
                this.Status.Padding = new System.Windows.Forms.Padding(28, 10, 10, 20);
            }
        }

        private void TocarBateria_Click(object sender, EventArgs e)
        {
            this.Bateria.Value = 100;
            this.PercentualBateria.Text = Bateria.Value.ToString() + "%";
        }
    }
}
