using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future_Real_Estate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Panel p = new Panel();
        //Se muestra el panel negro abajo de los botones
        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(0, 0, 0);
            p.Size = new Size(150, 8);
            p.Location = new 
                Point(btn.Location.X, btn.Location.Y+55);
        }
        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p); //Se deja de mostrar el panel negro
        }
        //Se muestran los botones "Venta de Propiedades" y "Alquiler de Propiedades"
        private void btnProperty_Click(object sender, EventArgs e)
        {
            if (!pVyA.Visible)
            {
                pVyA.Visible = true; 
            }
            else
            {
                pVyA.Visible = false;
            }
        }
    }
}
