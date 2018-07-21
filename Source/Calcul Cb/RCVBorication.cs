using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Calcul_Cb
{
    public partial class RCVBorication : Form
    {
        public RCVBorication()
        {
            InitializeComponent();
        }

        private void RCVBorication_Load(object sender, EventArgs e)
        {
            // Afficher la date au chargement du Form
            dateRedacteur_Label.Text = DateTime.Now.ToShortDateString();
            dateVerificateur_Label.Text = DateTime.Now.ToShortDateString();
        }

        // Basculer sur PTR K - Dilution //
        private void PtrKDilution_Click(object sender, EventArgs e)
        {
            System.Threading.Thread ptrkdilutionThread = new System.Threading.Thread(new System.Threading.ThreadStart(OuvrirPtrKDilution));
            ptrkdilutionThread.Start();
            this.Close();
        }

        public static void OuvrirPtrKDilution()
        {
            Application.Run(new PtrKDilution());
        }
        // --------------------- //

        // Basculer sur PTR K - Appoint SED //
        private void PtrKAppointSED_Click(object sender, EventArgs e)
        {
            System.Threading.Thread ptrkappointThread = new System.Threading.Thread(new System.Threading.ThreadStart(OuvrirPtrKAppointSED));
            ptrkappointThread.Start();
            this.Close();
        }

        public static void OuvrirPtrKAppointSED()
        {
            Application.Run(new PtrKAppointSED());
        }
        // ------------------------ //

        // Basculer sur RCV - Réglage platine //
        private void RcvReglagePlatine_Click(object sender, EventArgs e)
        {
            System.Threading.Thread rcvreglageplatineThread = new System.Threading.Thread(new System.Threading.ThreadStart(OuvrirRcvReglagePlatine));
            rcvreglageplatineThread.Start();
            this.Close();
        }

        public static void OuvrirRcvReglagePlatine()
        {
            Application.Run(new RcvReglagePlatine());
        }
        // ------------------------ //

        // Basculer sur Calcul Cb //
        private void CalculCb_Click(object sender, EventArgs e)
        {
            System.Threading.Thread CalculCbThread = new System.Threading.Thread(new System.Threading.ThreadStart(OuvrirCalculCb));
            CalculCbThread.Start();
            this.Close();
        }

        public static void OuvrirCalculCb()
        {
            Application.Run(new CalculCb());
        }
        // --------------------- //

        // Basculer sur RCV - Dilution //
        private void RcvDilution_Click(object sender, EventArgs e)
        {
            System.Threading.Thread rcvdilutionThread = new System.Threading.Thread(new System.Threading.ThreadStart(OuvrirRcvDilution));
            rcvdilutionThread.Start();
            this.Close();
        }

        public static void OuvrirRcvDilution()
        {
            Application.Run(new RCVDilution());
        }
        // ------------------------ //

        // Fonction selection texte //
        private void SelectAll_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectAll();
            }
            else if (sender is NumericUpDown)
            {
                ((NumericUpDown)sender).Select(0, 9999);
            }
        }
        // ----------------------------- //

        // Fonction impression //
        private void ButtonClickImprimer(object sender, EventArgs e)
        {
            PrintDocument Calculprint = new PrintDocument()
            {
                DocumentName = "Calcul CB"
            };
            Calculprint.DefaultPageSettings.Landscape = true;
            Calculprint.DefaultPageSettings.Color = true;
            Calculprint.PrintPage += CalculPrintPage;
            Calculprint.Print();
        }

        private void CalculPrintPage(object o, PrintPageEventArgs e)
        {
            Rectangle rectForm = this.Bounds;
            Bitmap bmp = null;

            using (Bitmap bitmap = new Bitmap(rectForm.Width, rectForm.Height))
            {
                using (Graphics graphic = Graphics.FromImage(bitmap))
                {

                    graphic.CopyFromScreen(rectForm.Location, Point.Empty, rectForm.Size);
                }
                bmp = new Bitmap(bitmap);
            }
            Rectangle destRect = new Rectangle(10, 10, rectForm.Width, rectForm.Height);
            int x = 0;
            int y = 0;
            int width = rectForm.Width;
            int height = rectForm.Height;
            GraphicsUnit units = GraphicsUnit.Pixel;
            e.Graphics.DrawImage((Image)bmp, destRect, x, y, width, height, units);
        }
        // ------------------- //

        // Fonction calcul borication //
        private void BoricationCalculer_button_Click(object sender, EventArgs e)
        {
            double Cbprim = 0;
            double CbREA = 0;
            double Cbsouhaite = 0;

            if ((TryCheck(errorNumericBorication_label, cbPrimaire_number.Text, out Cbprim)) &&
               (TryCheck(errorNumericBorication_label, cbREABore_number.Text, out CbREA)) &&
               (TryCheck(errorNumericBorication_label, cbPrimaireSouhaite_number.Text, out Cbsouhaite)))
            {
                if (Cbsouhaite < Cbprim)
                {
                    vbValeur_label.Text = "Il vous faut diluer";
                    vbValeur_label.Visible = true;
                    vb_label.Visible = false;
                    vbUnite_label.Visible = false;
                } else
                {
                    double vinj = Math.Round((290 * Math.Log((CbREA - Cbprim) / (CbREA - Cbsouhaite))) * 1000, 0); // Calcul du volume à injecter arrondie à l'unité
                    vbValeur_label.Text = Convert.ToString(vinj);
                    vb_label.Visible = true;
                    vbValeur_label.Visible = true;
                    vbUnite_label.Visible = true;
                }
            }
        }
        // -------------------------------- //

        private bool TryCheck(Label toSetIfWrong, string toCheck, out double toSet)
        {
            if (double.TryParse(toCheck, out toSet))
            {
                toSetIfWrong.Visible = false;
                return true;
            }
            else
                toSetIfWrong.Visible = true;
            return false;
        }
    }
}
