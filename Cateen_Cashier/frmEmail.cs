using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cateen_Cashier
{
    public partial class frmEmail : Form
    {
        String imagePath = "";
        int t = 0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
     (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse

     );

        OpenFileDialog ofdAttachment;
        String fileName = "";
        bool frmEmail_isValid = false;

        public frmEmail(String path)
        {
            InitializeComponent();
            fileName = path;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

        }

        private void btnBrowseFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "File(.jpg,.png)|*.png;*.jpg;|Pdf Files|*.pdf";
                if (ofdAttachment.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdAttachment.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Thread t = new Thread(new ThreadStart(ThreadProc));

        private void btn_sendEmail_Click_1(object sender, EventArgs e)
        {
            if (frmEmail_isValid)
            {
                sendEmail();
            }
            else
            {
                MessageBox.Show("Please enter a valid email.");
            }
        }

        void sendEmail()
        {
            try
            {
                //Smpt Client Details
                //gmail >> smtp server : smtp.gmail.com, port : 587 , ssl required
                //yahoo >> smtp server : smtp.mail.yahoo.com, port : 587 , ssl required
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32("587");
                clientDetails.Host = "smtp.gmail.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential("email", "password");

                Thread t = new Thread(delegate ()
                {
                    //Message Details
                    MailMessage mailDetails = new MailMessage();
                    mailDetails.From = new MailAddress("email");
                    mailDetails.To.Add(txtEmail.Texts);

                    mailDetails.Subject = txt_Title.Texts;
                    mailDetails.IsBodyHtml = false;
                    mailDetails.Body = txtbody.Texts;


                    //file attachment
                    if (fileName.Length > 0)
                    {
                        Attachment attachment = new Attachment(fileName);
                        mailDetails.Attachments.Add(attachment);
                    }
                    clientDetails.Send(mailDetails);
                    MessageBox.Show("Your mail has been sent.");
                    fileName = "";


                });

                t.Start();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmEmail_Load(object sender, EventArgs e)
        {
            lblAttached.Text = fileName;
        }

        private void pic_Name_Validate_Click(object sender, EventArgs e)
        {
            if(txtEmail.Texts != "")
            {
                txtEmail.Texts = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_Title.Texts != "")
            {
                txt_Title.Texts = "";
            }
        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {
            frmEmail_isValid = Validation.validateCustEmail(txtEmail.Texts);
            if (frmEmail_isValid)
            {
                pic_Name_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\Yes.ico");
            }
            else
            {
                pic_Name_Validate.Image = new Bitmap(@"C:\Users\LOPI\Desktop\C#_Customize_Design\Cateen_Cashier\Cateen_Cashier\icons\No.ico");
            }
        }

        private void frmEmail_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
