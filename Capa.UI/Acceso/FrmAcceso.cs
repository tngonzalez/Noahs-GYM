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
using System.Runtime.InteropServices;
using Capa.BLL;
using Capa.UI.Areas;
using Capa.Entidades.Entidades;
using Capa.UI.Mantenimientos;

namespace Capa.UI.Acceso
{
    public partial class FrmAcceso : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmAcceso()
        {
            InitializeComponent();
        }


        #region Permite mover el formulario, ya que este no tiene encabezado 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int uparam, int lparam);
        #endregion

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void FrmAcceso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedIndex != -1)
                {
                    if (txtUser.Text != "" && txtUser.TextLength > 2)
                    {
                        if (txtContra.Text != "")
                        {

                            //Cliente
                            if (cmbTipo.SelectedIndex == 1)
                            {
                                Cliente oBLL = ClienteBLL.Login(txtUser.Text, txtContra.Text);

                              if(oBLL != null)
                                {
                                    var frm = new FrmMantCliente();
                                    frm.Cliente = (Cliente)oBLL;
                                    frm.ShowDialog();
                                    this.Hide(); 
                                    this.Close();
                                }
                              else
                                {
                                    MessageBox.Show("Datos erróneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtUser.Clear();
                                    txtContra.Clear(); 
                                }
                            }
                           
                            //Admin
                            if (cmbTipo.SelectedIndex == 0)
                            {
                                Administrador oBLL = AdministradorBLL.LoginAdmin(txtUser.Text, txtContra.Text);

                                if (oBLL != null)
                                {
                                    var frm = new FrmAreaAdministrador();
                                    frm.Administrador = (Administrador)oBLL;
                                    frm.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Datos erróneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtUser.Clear();
                                    txtContra.Clear();
                                }
                            }
                         
                            //Instructor 
                            if (cmbTipo.SelectedIndex == 2)
                            {
                                Instructor oBLL = InstructorBLL.LoginInst(txtUser.Text, txtContra.Text);

                                if (oBLL != null)
                                {
                                    var frm = new FrmAreaInstructor();
                                    frm.Instructor = (Instructor)oBLL;
                                    frm.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Datos erróneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtUser.Clear();
                                    txtContra.Clear();
                                }

                            }  

                        }
                        else
                        {
                            msgError("Ingrese la contraseña");
                        }
                    }
                    else
                    {
                        msgError("Ingrese el nombre de usuario");
                    }
                }
                else
                {
                    msgError("Debe seleccionar el tipo de usuario");
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

        private void msgError(string msg)
        {
            lblErrorMensage.Text = " " + msg;
            lblErrorMensage.Visible = true; 
        }
    }
}
