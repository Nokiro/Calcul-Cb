using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Calcul_Cb
{
    public partial class PtrKDilution : Form
    {
        public PtrKDilution()
        {
            InitializeComponent();
        }

        private void PtrKDilution_Load(object sender, EventArgs e)
        {
            // Afficher la date au chargement du Form
            dateRedacteur_Label.Text = DateTime.Now.ToShortDateString();
            dateVerificateur_Label.Text = DateTime.Now.ToShortDateString();
        }
        
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
                DocumentName = "Calcul CB PTR K"
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

        // Fonction calcul volumes //
        private void CalculVolume(double niveauPiscine)
        {
            double volumePiscine = (niveauPiscine - 12.3) * 140; //Volume piscine seule en m3
            volumePiscine_label.Text = "(" + niveauPiscine + " - 12.3) * 140 = " + Math.Round(volumePiscine, 1) +" m3";
            volumePiscine_label.Visible = true;

            if (chateauDePlomb.Checked)
            {
                double volumeChateau = (niveauPiscine - 11.15) * 19.18; // Volume du chateau de plomb en m3
                volumeChateau_label.Text = "(" + niveauPiscine + " - 11.15) * 19.18 = " + Math.Round(volumeChateau, 1) + " m3";
                volumeChateau_label.Visible = true;
            }
            else
            {
                volumeChateau_label.Text = "0 m3";
                volumeChateau_label.Visible = true;
            }

            if (compartimentTransfert.Checked)
            {
                double volumeTransfert = (niveauPiscine - 12.3) * 20; // Volume du transfert en m3
                volumeTransfert_label.Text = "(" + niveauPiscine + " - 12.3) * 20 = " + Math.Round(volumeTransfert, 1) + " m3";
                volumeTransfert_label.Visible = true;
            }
            else
            {
                volumeTransfert_label.Text = "0 m3";
                volumeTransfert_label.Visible = true;
            }
        }
        // ----------------------- //

        // Fonction calcul de dilution //
        private void DilutionCalculer_button_Click(object sender, EventArgs e)
        {
            int cbInitiale = 0;
            double niveauPiscine = 0;
            double dilution = 0;

            if ((TryCheck(errorNumericDil_label, cbPTRK_number.Text, out cbInitiale)) &&
                (TryCheck(errorNumericDil_label, niveauPiscine_number.Text, out niveauPiscine)) &&
                (TryCheck(errorNumericDil_label, valeurDilution.Text, out dilution)))
            {
                double volumePiscine = (niveauPiscine - 12.3) * 140; //Volume piscine seule en m3
                CalculVolume(niveauPiscine); //Affichage des volumes

                if (chateauDePlomb.Checked)
                {
                    volumePiscine = volumePiscine + (niveauPiscine - 11.15) * 19.18; // Ajout du chateau de plomb
                }

                if (compartimentTransfert.Checked)
                {
                    volumePiscine = volumePiscine + (niveauPiscine - 12.3) * 20; // Ajout du compartiment transfert
                }

                double cbFinaleDilMax = Math.Round((volumePiscine * cbInitiale) / (volumePiscine + 5), 1); // Calcul de la Cb finale de dilution max arrondie à 1 chiffre
                cbFinaleDilMaxValeur_label.Text = Convert.ToString(cbFinaleDilMax);
                cbFinaleDilMax_label.Visible = true;
                cbFinaleDilMaxValeur_label.Visible = true;

                double cbFinaleDil = Math.Round((volumePiscine * cbInitiale) / (volumePiscine + dilution), 1); // Calcul de la Cb finale de dilution arrondie à 1 chiffre
                dil_groupbox.Text = "Dilution de " + dilution + " m3";
                cbFinaleDilValeur_label.Text = Convert.ToString(cbFinaleDil);
                cbFinaleDil_label.Visible = true;
                cbFinaleDilValeur_label.Visible = true;
            }
        }
        // --------------------------- //

        private bool TryCheck(Label toSetIfWrong, string toCheck, out int toSet)
        {
            if (int.TryParse(toCheck, out toSet))
            {
                toSetIfWrong.Visible = false;
                return true;
            }
            else
                toSetIfWrong.Visible = true;
            return false;
        }

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
