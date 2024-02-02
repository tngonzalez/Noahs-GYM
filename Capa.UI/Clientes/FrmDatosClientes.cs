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
using Capa.Entidades.Entidades;
using Capa.Entidades;
using Capa.BLL;
using System.IO;

namespace Capa.UI.Clientes
{
    public partial class FrmDatosClientes : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmDatosClientes()
        {
            InitializeComponent();
        }
        public Cliente oCliente { get; set; }

        #region Metodos variados 
        private void Validaciones()
        {
            erp.Clear();

            try
            {
               
                //Nombre
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Digite su nombre"); return;
                }

                //Apellidos 
                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    erp.SetError(txtApellidos, "Digite ambos apellidos"); return;
                }

                //Genero 
                if (cmbGenero.SelectedIndex == -1)
                {
                    erp.SetError(cmbGenero, "Seleccione el genero correspondiente"); return;
                }

                //Fecha
                if(dtpFechaNacimiento.Value == DateTime.Now)
                {
                    erp.SetError(dtpFechaNacimiento, "Seleccione su fecha de nacimiento"); return;

                }
                //Clave 
                if (string.IsNullOrEmpty(txtContra.Text))
                {
                    erp.SetError(txtContra, "Digite su nueva contraseña"); return;
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

        private void CargarDatos()
        {
            //Cargar Combo
            cmbGenero.DataSource = GeneroBLL.ObtenerTodos();
            cmbGenero.DisplayMember = "Nombre";
            cmbGenero.ValueMember = "ID"; 

            txtID.Text = oCliente.ID.ToString();
            txtNombre.Text = oCliente.Nombre;
            txtApellidos.Text = oCliente.Apellidos;
            cmbGenero.SelectedValue = oCliente.IdGenero;
            cmbGenero.SelectedItem = oCliente.Genero;
            mskTelefono.Text = oCliente.Telefono;
            dtpFechaNacimiento.Value = (DateTime)oCliente.FechaNacimiento;
            txtContra.Text = oCliente.Clave;
            txtCorreo.Text = oCliente.Correo;

            //Conver Imagen
            ImageConverter img = new ImageConverter();
            pictureBoxCircular1.Image = (Bitmap)img.ConvertFrom(oCliente.Foto);
        }
        #endregion

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            cmbGenero.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtContra.Enabled = true;
            mskTelefono.Enabled = true;

            btnGuardar.Visible = true;
            btnSeleccionFoto.Visible = true;  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();

                Cliente oCli = new Cliente();

                oCli.ID = Convert.ToInt32(txtID.Text);
                oCli.Nombre = txtNombre.Text;

                oCli.Telefono = mskTelefono.Text;
                oCli.IdGenero = (int)cmbGenero.SelectedValue;
                oCli.Genero = cmbGenero.SelectedItem as Genero;
                oCli.Clave = txtContra.Text;
                oCli.Apellidos = txtApellidos.Text;
                oCli.Foto = (byte[])pictureBoxCircular1.Tag;
                oCli.FechaNacimiento = dtpFechaNacimiento.Value;
                oCli.Correo = txtCorreo.Text;

                ClienteBLL oBLL = new ClienteBLL();
                oBLL.Guardar(oCli);

                MessageBox.Show("La modificación se realizó exitosamente! :) ", "Noah´s GYM", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Limpiar
                txtNombre.Enabled = false;
                txtApellidos.Enabled = false;
                cmbGenero.Enabled = false;
                dtpFechaNacimiento.Enabled = false;
                txtContra.Enabled = false;
                mskTelefono.Enabled = false;

                btnGuardar.Visible = false;
                btnSeleccionFoto.Visible = false;
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

        private void btnSeleccionFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Seleccione la nueva foto de perfil";
                openFile.SupportMultiDottedExtensions = true; //soporte para varias extensiones
                openFile.DefaultExt = "*.png";
                openFile.Filter = "Archivos de Imagenes (*.png;*.jpeg)|*.png;*.jpeg| All files (*.*)|*.*";
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
                openFile.FileName = "";
                if (openFile.ShowDialog(this) == DialogResult.OK)
                {

                    try
                    {
                        pictureBoxCircular1.ImageLocation = openFile.FileName;
                        pictureBoxCircular1.SizeMode = PictureBoxSizeMode.StretchImage;
                        //convertir la imagen en bytes
                        byte[] cadenaByte = File.ReadAllBytes(openFile.FileName);
                        //almacenamos los bytes en el tag del picture
                        pictureBoxCircular1.Tag = (byte[])cadenaByte;
                    }

                    catch (Exception er) { MessageBox.Show("Error: " + er.Message); }
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

        private void FrmDatosClientes_Load(object sender, EventArgs e)
        {
            CargarDatos(); 
        }
    }
}
