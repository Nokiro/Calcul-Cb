using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Calcul_Cb
{
    public partial class PtrKAppointSED : Form
    {
        public PtrKAppointSED()
        {
            InitializeComponent();
        }

        private void PtrkKAppointSED_Load(object sender, EventArgs e)
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

        // Fonction calcul volumes //
        private void CalculVolume(double niveauPiscine)
        {
            double volumePiscine = (niveauPiscine - 12.3) * 140; //Volume piscine seule en m3
            volumePiscine_label.Text = "(" + niveauPiscine + " - 12.3) * 140 = " + Math.Round(volumePiscine, 1) + " m3";
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

        // Fonction calcul d'appoint en SED //
        private void AppointCalculer_button_Click(object sender, EventArgs e)
        {
            int cbInitiale = 0;
            double niveauPiscine = 0;
            double niveauSouhaite = 0;

            if ((TryCheck(errorNumericAppoint_label, cbPTRK_number.Text, out cbInitiale)) &&
               (TryCheck(errorNumericAppoint_label, niveauPiscine_number.Text, out niveauPiscine)) &&
               (TryCheck(errorNumericAppoint_label, valeurNiveauSouhaite.Text, out niveauSouhaite)))
            {
                if (niveauSouhaite >= niveauPiscine)
                {
                    double volumePiscine = (niveauPiscine - 12.3) * 140; //Volume piscine seule en m3
                    double volumePiscineAppoint = (niveauSouhaite - niveauPiscine) * 140;
                    double volumePiscineAppointMax = (26.05 - niveauPiscine) * 140;
                    CalculVolume(niveauPiscine); //Affichage des volumes

                    if (chateauDePlomb.Checked)
                    {
                        volumePiscine = volumePiscine + (niveauPiscine - 11.15) * 19.18; // Ajout du chateau de plomb
                        volumePiscineAppoint = volumePiscineAppoint + (niveauSouhaite - niveauPiscine) * 19.18;
                        volumePiscineAppointMax = volumePiscineAppointMax + (26.05 - niveauPiscine) * 19.18;
                    }

                    if (compartimentTransfert.Checked)
                    {
                        volumePiscine = volumePiscine + (niveauPiscine - 12.3) * 20; // Ajout du compartiment transfert
                        volumePiscineAppoint = volumePiscineAppoint + (niveauSouhaite - niveauPiscine) * 20;
                        volumePiscineAppointMax = volumePiscineAppointMax + (26.05 - niveauPiscine) * 20;
                    }

                    double cbFinaleAppointMax = Math.Round((volumePiscine * cbInitiale) / (volumePiscine + volumePiscineAppointMax), 1); // Calcul de la Cb finale d'appoint max arrondie à 1 chiffre
                    cbFinaleAppointMaxValeur_label.Text = Convert.ToString(cbFinaleAppointMax);
                    cbFinaleAppointMax_label.Visible = true;
                    cbFinaleAppointMaxValeur_label.Visible = true;

                    double cbFinaleAppoint = Math.Round((volumePiscine * cbInitiale) / (volumePiscine + volumePiscineAppoint), 1); // Calcul de la Cb finale d'appoint arrondie à 1 chiffre
                    niveau_groupbox.Text = "Niveau à " + niveauSouhaite + " m";
                    cbFinaleAppointValeur_label.Text = Convert.ToString(cbFinaleAppoint);
                    cbFinaleAppoint_label.Visible = true;
                    cbFinaleAppointValeur_label.Visible = true;
                }
                else
                {
                    errorNumericAppoint_label.Text = "Valeur inférieur au niveau actuel";
                    errorNumericAppoint_label.Visible = true;
                    cbFinaleAppointMax_label.Visible = false;
                    cbFinaleAppointMaxValeur_label.Visible = false;
                    cbFinaleAppoint_label.Visible = false;
                    cbFinaleAppointValeur_label.Visible = false;
                }
            }
        }
        // -------------------------------- //

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
