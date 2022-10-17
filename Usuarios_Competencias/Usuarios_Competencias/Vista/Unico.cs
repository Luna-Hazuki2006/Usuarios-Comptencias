using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuarios_Competencias.Modelo;

namespace Usuarios_Competencias.Vista
{
    public partial class Unico : Form
    {
        public Form? Origen = null;
        public Empleado? persona = null;
        public Unico()
        {
            InitializeComponent();
        }

        public void Inicio(Form? i = null, Empleado? e = null)
        {
            dateTimePickerFecha.MaxDate = DateTime.Today;
            Origen = i;
            persona = e;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Origen?.Show();
            Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCedula.Clear();
            textBoxNombres.Clear();
            textBoxApellidos.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            textBoxEmail.Clear();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
