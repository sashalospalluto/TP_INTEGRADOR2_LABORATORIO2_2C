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
    public partial class FrmNuevaMascota : Form
    {
        GuardiaVeterinaria frmPrincipal;
        bool mostrarMensaje;
        public FrmNuevaMascota(GuardiaVeterinaria frmVeterinaria)
        {
            InitializeComponent();
            frmPrincipal = frmVeterinaria;
            mostrarMensaje = true;
            cmbTipoMascota.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNuevaMascota_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreMascota.Text.Length == 0 || txtNombreTutor.Text.Length == 0 || txtDniTutor.Text.Length == 0 || txtEdad.Text.Length == 0 || txtPeso.Text.Length == 0)
                {
                    MessageBox.Show("Todos los campos son obligatorios, vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    string nombre = txtNombreMascota.Text;
                    string nombre_tutor = txtNombreTutor.Text;
                    int dni_tutor = int.Parse(txtDniTutor.Text);
                    int edad = int.Parse(txtEdad.Text);
                    ETipoMascota tipo = (Mascota.ETipoMascota)Enum.Parse(typeof(Mascota.ETipoMascota), cmbTipoMascota.SelectedItem.ToString());
                    string peso = txtPeso.Text;

                    Mascota mascotaNueva = Mascota.NuevaMascota(nombre, nombre_tutor, edad, tipo, dni_tutor, peso);
                    //frmPrincipal.todasLasMascotas.Add(mascotaNueva);
                    if(GestorSql.GetIdMascota(mascotaNueva) == -1)
                    {
                        if (GestorSql.GuardarMascota(mascotaNueva))
                        {
                            MessageBox.Show("¡Todo se ha cargado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mostrarMensaje = false;
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar la mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una mascota con ese dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmNuevaMascota_Load(object sender, EventArgs e)
        {
            this.cmbTipoMascota.DataSource = new List<string>
            {
                "Perro",
                "Gato"
            };
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmPrincipal.SoloNumeros(sender, e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmPrincipal.SoloNumeros(sender, e);
        }

        private void txtDniTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmPrincipal.SoloNumeros(sender,e);
        }

        
    }
}
