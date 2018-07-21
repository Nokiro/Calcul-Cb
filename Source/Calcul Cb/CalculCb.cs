using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Calcul_Cb
{
    public partial class CalculCb : Form
    {
        public CalculCb()
        {
            InitializeComponent();
        }

        private void CalculCb_Load(object sender, EventArgs e)
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

        // Fonction calcul Cb //
        private void CbCalculer_button_Click(object sender, EventArgs e)
        {
            double V1 = 0;
            double Cb1 = 0;
            double V2 = 0;
            double Cb2 = 0;

            if ((TryCheck(errorNumericCalculCb_label, V1_number.Text, out V1)) &&
               (TryCheck(errorNumericCalculCb_label, Cb1_number.Text, out Cb1)) &&
               (TryCheck(errorNumericCalculCb_label, V2_number.Text, out V2)) &&
               (TryCheck(errorNumericCalculCb_label, Cb2_number.Text, out Cb2)))
            {

                double cbFinale = Math.Round(((V1 * Cb1) + (V2 * Cb2)) / (V1 + V2), 1); // Calcul de la Cb finale arrondie à 1 chiffre
                cbFinaleValeur_label.Text = Convert.ToString(cbFinale);
                cbFinaleValeur_label.Visible = true;
                cbFinale_label.Visible = true;
                CbFinaleUnite_label.Visible = true;
                double vFinale = Math.Round(V1 + V2, 1); // Calcul du volume final arrondie à 1 chiffre
                vFinalValeur_label.Text = Convert.ToString(vFinale);
                vFinalValeur_label.Visible = true;
                vFinal_label.Visible = true;
                VFinalUnite_label.Visible = true;
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
