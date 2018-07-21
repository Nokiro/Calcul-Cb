using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Calcul_Cb
{
    public partial class RcvReglagePlatine : Form
    {
        public RcvReglagePlatine()
        {
            InitializeComponent();
        }

        private void RCVReglagePlatine_Load(object sender, EventArgs e)
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

        // Basculer sur RCV - Borication //
        private void RcvBorication_Click(object sender, EventArgs e)
        {
            System.Threading.Thread rcvboricationThread = new System.Threading.Thread(new System.Threading.ThreadStart(OuvrirRcvBorication));
            rcvboricationThread.Start();
            this.Close();
        }

        public static void OuvrirRcvBorication()
        {
            Application.Run(new RCVBorication());
        }
        // ------------------------ //

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

        // Fonction remplacement . par , //
        private void Decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
        }
        // ----------------------------- //

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

        // Fonction Reglage d'appoint //
        private void ReglageAppointCalculer_button_Click(object sender, EventArgs e)
        {
            double Cba = 0;
            double CbREA = 0;
            double Vinjection = 0;

            if ((TryCheck(errorNumericReglagePlatine_label, cbAppoint_number.Text, out Cba)) &&
               (TryCheck(errorNumericReglagePlatine_label, cbREABore_number.Text, out CbREA)) &&
               (TryCheck(errorNumericReglagePlatine_label, volumeInjection_number.Text, out Vinjection)))
            {

                double qb = Math.Round(33 * (Cba / CbREA), 1); // Calcul du débit bore arrondie à 1 chiffre
                qbValeur_label.Text = Convert.ToString(qb);

                double vb = Math.Round(((qb / 33) * Vinjection) * 1000, 0); // Calcul du volume bore arrondie à l'unité
                vbValeur_label.Text = Convert.ToString(vb);

                double qe = Math.Round(33 - qb, 1); // Calcul du débit eau arrondie à 1 chiffre
                qeValeur_label.Text = Convert.ToString(qe);

                double ve = Math.Round(((qe / 33) * Vinjection) * 1000, 0); // Calcul du volume eau arrondie à l'unité
                veValeur_label.Text = Convert.ToString(ve);

                reglageBore_groupbox.Visible = true;
                reglageEau_groupbox.Visible = true;
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
