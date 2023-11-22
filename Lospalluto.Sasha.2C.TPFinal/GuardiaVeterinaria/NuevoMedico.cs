using proyecto_veterinaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proyecto_veterinaria.Mascota;

namespace GuardiaVeterinaria
{
    public partial class FrmNuevoMedico : Form
    {
        GuardiaVeterinaria frmPrincipal;
        bool mostrarMensaje;
        public FrmNuevoMedico(GuardiaVeterinaria frmVeterinaria)
        {
            InitializeComponent();
            frmPrincipal = frmVeterinaria;
            mostrarMensaje = true;
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtDni.Text.Length == 0)
                {
                    MessageBox.Show("Todos los campos son obligatorios, vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    int dni = int.Parse(txtDni.Text);

                    Medico medico = new Medico(nombre,apellido,dni);

                    if (GestorSql.GuardarMedico(medico))
                    {
                        MessageBox.Show("¡Todo se ha cargado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    mostrarMensaje = false;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNuevoMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mostrarMensaje)
            {
                if (MessageBox.Show("¿Desea cancelar la carga del paciente nuevo?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true; //no deja que se cierre 
                }
                else
                {
                    this.Visible = false;
                }
            }
        }
    }
}
