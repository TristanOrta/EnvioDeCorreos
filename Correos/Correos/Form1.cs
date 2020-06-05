using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonEnvar_Click(object sender, EventArgs e)
        {

            string EmailOrigen = "otristan94@gmail.com";
            string EmailDestino = txbPara.Text;
            string Contraseña = "Tu pass";
            //string path = @"C:\turuta\burger.png";
            //string path2 = @"C:\turuta\a.jpg";

            MailMessage oMailMessage = new MailMessage(EmailOrigen, EmailDestino, txbAsunto.Text, TxMensaje.Text);
            //oMailMessage.Attachments.Add(new Attachment(path));
            //oMailMessage.Attachments.Add(new Attachment(path2));

            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpCliente = new SmtpClient("smtp.gmail.com");
            oSmtpCliente.EnableSsl = true;
            oSmtpCliente.UseDefaultCredentials = false;
            oSmtpCliente.Port = 587;
            oSmtpCliente.Credentials = new System.Net.NetworkCredential(EmailOrigen, Contraseña);

            oSmtpCliente.Send(oMailMessage);

            oSmtpCliente.Dispose();
            //
        




        }
    }
}
