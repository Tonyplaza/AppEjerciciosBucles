using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjerciciosBucles
{
    public partial class VentanaExamen : Form
    {
        public VentanaExamen()
        {
            InitializeComponent();
        }

        private void VentanaExamen_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int limite = 0, suma = 0;
            limite = int.Parse(this.txtLimite.Text);
            suma = Examen.sumatoria(limite);
            this.txtSumatoria.Text = suma.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
