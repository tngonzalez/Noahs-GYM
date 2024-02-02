using System;
using log4net; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa.BLL;
using Capa.Entidades.Entidades;

namespace Capa.UI.Registros
{
    public partial class FrmMedidas : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmMedidas()
        {
            InitializeComponent();
        }

        public Cliente Cliente { get; set; }

        #region Metodos Variados 

        private void Refrescar()
        {
            dgvMedidas.DataSource = MedidasBLL.SeleccionarXID(Convert.ToInt32(Cliente.ID));

            //Limpiar

            mskAltura.Clear();
            txtIMC.Clear();
            txtMetaBasal.Clear();
            txtPeso.Clear();
            dtpFechaMedidas.Value = DateTime.Now;

        }
        private void Validaciones()
        {
            erp.Clear();

            try
            {  

                //Peso
                if (string.IsNullOrEmpty(txtPeso.Text))
                {
                    erp.SetError(txtPeso, "Digite el peso del usuario"); return;
                }

                if (!int.TryParse(txtPeso.Text, out int co))
                {
                    erp.SetError(txtPeso, "Este campo solo permite datos numéricos"); return;
                }

                //Altura 
                if (string.IsNullOrEmpty(mskAltura.Text))
                {
                    erp.SetError(mskAltura, "Digite  la altura del usuario"); return;
                }

                //IMC
                if (string.IsNullOrEmpty(txtIMC.Text))
                {
                    erp.SetError(txtIMC, "Debe seleccionar el botón 'Realizar calculos' "); 
                }

                //MetaBasal
                if (string.IsNullOrEmpty(txtMetaBasal.Text))
                {
                    erp.SetError(txtMetaBasal, "Debe seleccionar el botón 'Realizar calculos' ");
                }
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }

        private void AsignarValores()
        {
            txtID.Text = Cliente.ID.ToString();
            txtNombre.Text = Cliente.Nombre;
            txtApellidos.Text = Cliente.Apellidos;
            txtGenero.Text = Cliente.Genero.Nombre;

            txtEdad.Text = (DateTime.Now.Year - Cliente.FechaNacimiento.Year).ToString(); 

            //Conver Imagen
            ImageConverter img = new ImageConverter();
            pcbFoto.Image = (Bitmap)img.ConvertFrom(Cliente.Foto);

        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                   Validaciones();

                    Medidas oMed = new Medidas();

                    oMed.IDCliente = Convert.ToInt32(txtID.Text); 
                    oMed.Peso = Convert.ToDouble(txtPeso.Text);
                    oMed.Altura = Convert.ToDouble(mskAltura.Text);
                    oMed.IMC = Convert.ToDouble(txtIMC.Text);
                    oMed.MetaBasal = Convert.ToDouble(txtMetaBasal.Text);
                    oMed.FechaMedida = (DateTime)dtpFechaMedidas.Value;
                    oMed.Estado = txtEstado.Text; 

                    MedidasBLL oBLL = new MedidasBLL();
                    oBLL.Guardar(oMed);
                    Refrescar();


                //Limpiar

                mskAltura.Clear();
                txtIMC.Clear();
                txtMetaBasal.Clear();
                txtPeso.Clear();
                dtpFechaMedidas.Value = DateTime.Now;

                MessageBox.Show("Ejercicio registrado exitosamente! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }

        private void btnCalculos_Click(object sender, EventArgs e)
        {

            try
            {
                btnGuardar.Enabled = true; 

                if (!string.IsNullOrEmpty(txtPeso.Text))
                {
                    txtIMC.Text = (Convert.ToDouble(txtPeso.Text) / (Convert.ToDouble(mskAltura.Text) * 2)).ToString("#.00");
 
                    //Llenar Estado Corporal
                    if (Convert.ToDouble(txtIMC.Text) < 18.5)
                    {
                        txtEstado.Text = "Peso inferior a lo normal";
                    }

                    if (Convert.ToDouble(txtIMC.Text) <= 24.9 && Convert.ToDouble(txtIMC.Text) > 19)
                    {
                        txtEstado.Text = "Normal";
                    }

                    if (Convert.ToDouble(txtIMC.Text) > 25  && Convert.ToDouble(txtIMC.Text) <= 30 )
                    {
                        txtEstado.Text = "Sobrepeso";
                    }

                    //Calculo MetaBasal

                    if (txtGenero.Text.Equals("Femenino", StringComparison.CurrentCultureIgnoreCase))
                    {
                        txtMetaBasal.Text = ((10 * Convert.ToDouble(txtPeso.Text)) +
                                           (6.25 * Convert.ToDouble(mskAltura.Text)) -
                                           (5 * Convert.ToInt32(txtEdad.Text) - 161)).ToString();
                    }
                    if (txtGenero.Text.Equals("Masculino", StringComparison.CurrentCultureIgnoreCase))
                    {
                        txtMetaBasal.Text = ((10 * Convert.ToDouble(txtPeso.Text)) +
                                            (6.25 * Convert.ToDouble(mskAltura.Text)) -
                                            (5 * Convert.ToInt32(txtEdad.Text) + 5)).ToString();
                    }
                    if (txtGenero.Text.Equals("No aplica", StringComparison.CurrentCultureIgnoreCase))
                    {
                        txtMetaBasal.Text = ((10 * Convert.ToDouble(txtPeso.Text)) +
                                             (6.25 * Convert.ToDouble(mskAltura.Text)) -
                                             (5 * Convert.ToInt32(txtEdad.Text))).ToString();
                    }
                }
                else
                    {
                        MessageBox.Show("Ingrese los datos solicitados", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPeso.Focus();
                    }
                
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedidas.SelectedRows.Count > 0)
                {
                    var Pregunta = MessageBox.Show("¿Esta seguro que desea eliminar las medidas seleccionadas?", "Eliminación permanente",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Pregunta == DialogResult.Yes)
                    {
                        MedidasBLL oBLL = new MedidasBLL();
                        oBLL.Eliminar(Convert.ToInt32(txtID.Text));
                        Refrescar();

                        MessageBox.Show("Las medidas se han eliminado de manera exitosa! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Para poder eliminar las medidas, primero debe seleccionarlas", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }

        private void btnBuscarMedidasCliente_Click(object sender, EventArgs e)
        {

         
        }

        private void dgvMedidas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btnGuardar.Enabled = false; 

                if (dgvMedidas.SelectedRows.Count > 0)
                {
                    var oMe = (Medidas)dgvMedidas.SelectedRows[0].DataBoundItem;
                    txtID.Text = oMe.IDCliente.ToString(); 
                }
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("\r\nMessage        {0}\n", error.Message);
                msg.AppendFormat("Source         {0}\n", error.Source);
                msg.AppendFormat("StackTrace     {0}\n", error.StackTrace);
                msg.AppendFormat("Data           {0}\n", error.Data);

                GYMEventos.Error(msg.ToString());

                MessageBox.Show("Se ha producido un error :" + error.Message, "Error");
            }
        }

        private void FrmMedidas_Load(object sender, EventArgs e)
        {
            Refrescar();
            AsignarValores();
            dgvMedidas.ClearSelection(); 
        }

        private void btnSal_Click(object sender, EventArgs e)
        {
    

        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
