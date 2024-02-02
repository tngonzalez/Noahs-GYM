using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Capa.Entidades.Entidades;
using log4net;
using Capa.UI.Rutinas;

namespace Capa.UI.Clientes
{
    public partial class FrmCorreoTo : Form
    {
        private static readonly ILog GYMEventos = log4net.LogManager.GetLogger("NoahGYMEventos");

        public FrmCorreoTo()
        {
            InitializeComponent();
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
           if(dlg.ShowDialog() == DialogResult.OK)
            {
                lblAsunto.Text = dlg.FileName; 
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string EmailOrigen = "noahsgym3@gmail.com";
                string EmailDestino = txtPara.Text;
                string Contra = "irxkojxgmxfljkjm";
                string Asunto = txtAsunto.Text;
                string Mensaje = rtxtMensaje.Text;
                string path = lblAsunto.Text;

                MailMessage oMailMessage = new MailMessage(EmailOrigen, EmailDestino, Asunto, Mensaje);
                oMailMessage.Attachments.Add(new Attachment(path));

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Contra);

                smtpClient.Send(oMailMessage);
                smtpClient.Dispose();

                MessageBox.Show("El mensaje se ha enviado de forma exitosa! :)");

                //Limpiar
                txtPara.Clear();
                txtAsunto.Clear();
                rtxtMensaje.Clear();
                lblAsunto.Text = ""; 

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

        private void FrmCorreoTo_Load(object sender, EventArgs e)
        {
        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close(); 
        }
    }
}
