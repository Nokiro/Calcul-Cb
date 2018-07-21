namespace Calcul_Cb
{
    partial class PtrKAppointSED
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PtrKAppointSED));
            this.logoEDF = new System.Windows.Forms.PictureBox();
            this.printButton = new System.Windows.Forms.Button();
            this.cbPTRK_label = new System.Windows.Forms.Label();
            this.niveauPiscine_number = new System.Windows.Forms.NumericUpDown();
            this.compartimentTransfert = new System.Windows.Forms.CheckBox();
            this.niveauPiscineUnite_label = new System.Windows.Forms.Label();
            this.batardeau_label = new System.Windows.Forms.Label();
            this.chateauDePlomb = new System.Windows.Forms.CheckBox();
            this.niveauPiscine_label = new System.Windows.Forms.Label();
            this.cbPTRK_number = new System.Windows.Forms.NumericUpDown();
            this.cbPTRKUnite_label = new System.Windows.Forms.Label();
            this.appoint_groupbox = new System.Windows.Forms.GroupBox();
            this.niveau_groupbox = new System.Windows.Forms.GroupBox();
            this.cbFinaleAppoint_label = new System.Windows.Forms.Label();
            this.cbFinaleAppointValeur_label = new System.Windows.Forms.Label();
            this.niveauSouhaite_label = new System.Windows.Forms.Label();
            this.niveauMax_groupbox = new System.Windows.Forms.GroupBox();
            this.cbFinaleAppointMax_label = new System.Windows.Forms.Label();
            this.cbFinaleAppointMaxValeur_label = new System.Windows.Forms.Label();
            this.errorNumericAppoint_label = new System.Windows.Forms.Label();
            this.valeurNiveauSouhaite = new System.Windows.Forms.NumericUpDown();
            this.niveauSouhaiteUnite = new System.Windows.Forms.Label();
            this.appointCalculer_button = new System.Windows.Forms.Button();
            this.verificateur_groupBox = new System.Windows.Forms.GroupBox();
            this.dateVerificateur_Label = new System.Windows.Forms.Label();
            this.nomVerificateur_Label = new System.Windows.Forms.Label();
            this.redacteur_groupBox = new System.Windows.Forms.GroupBox();
            this.dateRedacteur_Label = new System.Windows.Forms.Label();
            this.nomRedacteur_Label = new System.Windows.Forms.Label();
            this.ptrkDilution_button = new System.Windows.Forms.Button();
            this.ptrkAppointSED_label = new System.Windows.Forms.Label();
            this.volumeTransfert_groupbox = new System.Windows.Forms.GroupBox();
            this.volumeTransfert_label = new System.Windows.Forms.Label();
            this.volumeChateau_groupbox = new System.Windows.Forms.GroupBox();
            this.volumeChateau_label = new System.Windows.Forms.Label();
            this.volumePiscine_groupbox = new System.Windows.Forms.GroupBox();
            this.volumePiscine_label = new System.Windows.Forms.Label();
            this.formule_label = new System.Windows.Forms.Label();
            this.calculCb_button = new System.Windows.Forms.Button();
            this.buttonPiscine_groupBox = new System.Windows.Forms.GroupBox();
            this.buttonRCV_groupBox = new System.Windows.Forms.GroupBox();
            this.rcvPlatine_button = new System.Windows.Forms.Button();
            this.rcvDilution_button = new System.Windows.Forms.Button();
            this.rcvBorication_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoEDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauPiscine_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPTRK_number)).BeginInit();
            this.appoint_groupbox.SuspendLayout();
            this.niveau_groupbox.SuspendLayout();
            this.niveauMax_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valeurNiveauSouhaite)).BeginInit();
            this.verificateur_groupBox.SuspendLayout();
            this.redacteur_groupBox.SuspendLayout();
            this.volumeTransfert_groupbox.SuspendLayout();
            this.volumeChateau_groupbox.SuspendLayout();
            this.volumePiscine_groupbox.SuspendLayout();
            this.buttonPiscine_groupBox.SuspendLayout();
            this.buttonRCV_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoEDF
            // 
            this.logoEDF.Image = ((System.Drawing.Image)(resources.GetObject("logoEDF.Image")));
            this.logoEDF.Location = new System.Drawing.Point(12, 12);
            this.logoEDF.Name = "logoEDF";
            this.logoEDF.Size = new System.Drawing.Size(145, 67);
            this.logoEDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoEDF.TabIndex = 12;
            this.logoEDF.TabStop = false;
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(780, 12);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(80, 36);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Imprimer";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.ButtonClickImprimer);
            this.printButton.Enter += new System.EventHandler(this.AppointCalculer_button_Click);
            // 
            // cbPTRK_label
            // 
            this.cbPTRK_label.AutoSize = true;
            this.cbPTRK_label.CausesValidation = false;
            this.cbPTRK_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPTRK_label.Location = new System.Drawing.Point(217, 17);
            this.cbPTRK_label.Name = "cbPTRK_label";
            this.cbPTRK_label.Size = new System.Drawing.Size(120, 19);
            this.cbPTRK_label.TabIndex = 13;
            this.cbPTRK_label.Text = "Cb de la piscine :";
            // 
            // niveauPiscine_number
            // 
            this.niveauPiscine_number.DecimalPlaces = 2;
            this.niveauPiscine_number.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveauPiscine_number.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.niveauPiscine_number.Location = new System.Drawing.Point(343, 48);
            this.niveauPiscine_number.Maximum = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.niveauPiscine_number.Name = "niveauPiscine_number";
            this.niveauPiscine_number.Size = new System.Drawing.Size(79, 27);
            this.niveauPiscine_number.TabIndex = 2;
            this.niveauPiscine_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.niveauPiscine_number.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.niveauPiscine_number.Enter += new System.EventHandler(this.SelectAll_Enter);
            this.niveauPiscine_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // compartimentTransfert
            // 
            this.compartimentTransfert.AutoSize = true;
            this.compartimentTransfert.CausesValidation = false;
            this.compartimentTransfert.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compartimentTransfert.Location = new System.Drawing.Point(343, 112);
            this.compartimentTransfert.Name = "compartimentTransfert";
            this.compartimentTransfert.Size = new System.Drawing.Size(180, 23);
            this.compartimentTransfert.TabIndex = 4;
            this.compartimentTransfert.Text = "Compartiment transfert";
            this.compartimentTransfert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.compartimentTransfert.UseVisualStyleBackColor = true;
            // 
            // niveauPiscineUnite_label
            // 
            this.niveauPiscineUnite_label.AutoSize = true;
            this.niveauPiscineUnite_label.CausesValidation = false;
            this.niveauPiscineUnite_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveauPiscineUnite_label.Location = new System.Drawing.Point(428, 50);
            this.niveauPiscineUnite_label.Name = "niveauPiscineUnite_label";
            this.niveauPiscineUnite_label.Size = new System.Drawing.Size(21, 19);
            this.niveauPiscineUnite_label.TabIndex = 14;
            this.niveauPiscineUnite_label.Text = "m";
            // 
            // batardeau_label
            // 
            this.batardeau_label.AutoSize = true;
            this.batardeau_label.CausesValidation = false;
            this.batardeau_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batardeau_label.Location = new System.Drawing.Point(208, 98);
            this.batardeau_label.Name = "batardeau_label";
            this.batardeau_label.Size = new System.Drawing.Size(129, 19);
            this.batardeau_label.TabIndex = 15;
            this.batardeau_label.Text = "Batardeau ouvert :";
            // 
            // chateauDePlomb
            // 
            this.chateauDePlomb.AutoSize = true;
            this.chateauDePlomb.CausesValidation = false;
            this.chateauDePlomb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chateauDePlomb.Location = new System.Drawing.Point(343, 83);
            this.chateauDePlomb.Name = "chateauDePlomb";
            this.chateauDePlomb.Size = new System.Drawing.Size(146, 23);
            this.chateauDePlomb.TabIndex = 3;
            this.chateauDePlomb.Text = "Chateau de plomb";
            this.chateauDePlomb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chateauDePlomb.UseVisualStyleBackColor = true;
            // 
            // niveauPiscine_label
            // 
            this.niveauPiscine_label.AutoSize = true;
            this.niveauPiscine_label.CausesValidation = false;
            this.niveauPiscine_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveauPiscine_label.Location = new System.Drawing.Point(189, 50);
            this.niveauPiscine_label.Name = "niveauPiscine_label";
            this.niveauPiscine_label.Size = new System.Drawing.Size(148, 19);
            this.niveauPiscine_label.TabIndex = 16;
            this.niveauPiscine_label.Text = "Niveau de la piscine :";
            // 
            // cbPTRK_number
            // 
            this.cbPTRK_number.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPTRK_number.Location = new System.Drawing.Point(343, 15);
            this.cbPTRK_number.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.cbPTRK_number.Name = "cbPTRK_number";
            this.cbPTRK_number.Size = new System.Drawing.Size(79, 27);
            this.cbPTRK_number.TabIndex = 1;
            this.cbPTRK_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbPTRK_number.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.cbPTRK_number.Enter += new System.EventHandler(this.SelectAll_Enter);
            // 
            // cbPTRKUnite_label
            // 
            this.cbPTRKUnite_label.AutoSize = true;
            this.cbPTRKUnite_label.CausesValidation = false;
            this.cbPTRKUnite_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPTRKUnite_label.Location = new System.Drawing.Point(428, 17);
            this.cbPTRKUnite_label.Name = "cbPTRKUnite_label";
            this.cbPTRKUnite_label.Size = new System.Drawing.Size(37, 19);
            this.cbPTRKUnite_label.TabIndex = 17;
            this.cbPTRKUnite_label.Text = "ppm";
            // 
            // appoint_groupbox
            // 
            this.appoint_groupbox.Controls.Add(this.niveau_groupbox);
            this.appoint_groupbox.Controls.Add(this.niveauSouhaite_label);
            this.appoint_groupbox.Controls.Add(this.niveauMax_groupbox);
            this.appoint_groupbox.Controls.Add(this.errorNumericAppoint_label);
            this.appoint_groupbox.Controls.Add(this.valeurNiveauSouhaite);
            this.appoint_groupbox.Controls.Add(this.niveauSouhaiteUnite);
            this.appoint_groupbox.Controls.Add(this.appointCalculer_button);
            this.appoint_groupbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoint_groupbox.Location = new System.Drawing.Point(160, 141);
            this.appoint_groupbox.Name = "appoint_groupbox";
            this.appoint_groupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.appoint_groupbox.Size = new System.Drawing.Size(445, 220);
            this.appoint_groupbox.TabIndex = 5;
            this.appoint_groupbox.TabStop = false;
            this.appoint_groupbox.Text = "Appoint en SED";
            // 
            // niveau_groupbox
            // 
            this.niveau_groupbox.CausesValidation = false;
            this.niveau_groupbox.Controls.Add(this.cbFinaleAppoint_label);
            this.niveau_groupbox.Controls.Add(this.cbFinaleAppointValeur_label);
            this.niveau_groupbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveau_groupbox.Location = new System.Drawing.Point(226, 121);
            this.niveau_groupbox.Name = "niveau_groupbox";
            this.niveau_groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.niveau_groupbox.Size = new System.Drawing.Size(200, 85);
            this.niveau_groupbox.TabIndex = 0;
            this.niveau_groupbox.TabStop = false;
            this.niveau_groupbox.Text = "Niveau à 0 m";
            // 
            // cbFinaleAppoint_label
            // 
            this.cbFinaleAppoint_label.AutoSize = true;
            this.cbFinaleAppoint_label.CausesValidation = false;
            this.cbFinaleAppoint_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinaleAppoint_label.Location = new System.Drawing.Point(11, 39);
            this.cbFinaleAppoint_label.Name = "cbFinaleAppoint_label";
            this.cbFinaleAppoint_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbFinaleAppoint_label.Size = new System.Drawing.Size(74, 19);
            this.cbFinaleAppoint_label.TabIndex = 0;
            this.cbFinaleAppoint_label.Text = "Cb finale :";
            this.cbFinaleAppoint_label.Visible = false;
            // 
            // cbFinaleAppointValeur_label
            // 
            this.cbFinaleAppointValeur_label.AutoSize = true;
            this.cbFinaleAppointValeur_label.CausesValidation = false;
            this.cbFinaleAppointValeur_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinaleAppointValeur_label.ForeColor = System.Drawing.Color.Red;
            this.cbFinaleAppointValeur_label.Location = new System.Drawing.Point(101, 39);
            this.cbFinaleAppointValeur_label.Name = "cbFinaleAppointValeur_label";
            this.cbFinaleAppointValeur_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbFinaleAppointValeur_label.Size = new System.Drawing.Size(67, 19);
            this.cbFinaleAppointValeur_label.TabIndex = 0;
            this.cbFinaleAppointValeur_label.Text = "valeurCB";
            this.cbFinaleAppointValeur_label.Visible = false;
            // 
            // niveauSouhaite_label
            // 
            this.niveauSouhaite_label.AutoSize = true;
            this.niveauSouhaite_label.CausesValidation = false;
            this.niveauSouhaite_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveauSouhaite_label.Location = new System.Drawing.Point(55, 28);
            this.niveauSouhaite_label.Name = "niveauSouhaite_label";
            this.niveauSouhaite_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.niveauSouhaite_label.Size = new System.Drawing.Size(122, 19);
            this.niveauSouhaite_label.TabIndex = 0;
            this.niveauSouhaite_label.Text = "Niveau souhaité :";
            // 
            // niveauMax_groupbox
            // 
            this.niveauMax_groupbox.CausesValidation = false;
            this.niveauMax_groupbox.Controls.Add(this.cbFinaleAppointMax_label);
            this.niveauMax_groupbox.Controls.Add(this.cbFinaleAppointMaxValeur_label);
            this.niveauMax_groupbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveauMax_groupbox.Location = new System.Drawing.Point(19, 121);
            this.niveauMax_groupbox.Name = "niveauMax_groupbox";
            this.niveauMax_groupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.niveauMax_groupbox.Size = new System.Drawing.Size(200, 85);
            this.niveauMax_groupbox.TabIndex = 0;
            this.niveauMax_groupbox.TabStop = false;
            this.niveauMax_groupbox.Text = "Niveau à 26,05 m";
            // 
            // cbFinaleAppointMax_label
            // 
            this.cbFinaleAppointMax_label.AutoSize = true;
            this.cbFinaleAppointMax_label.CausesValidation = false;
            this.cbFinaleAppointMax_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinaleAppointMax_label.Location = new System.Drawing.Point(11, 39);
            this.cbFinaleAppointMax_label.Name = "cbFinaleAppointMax_label";
            this.cbFinaleAppointMax_label.Size = new System.Drawing.Size(74, 19);
            this.cbFinaleAppointMax_label.TabIndex = 0;
            this.cbFinaleAppointMax_label.Text = "Cb finale :";
            this.cbFinaleAppointMax_label.Visible = false;
            // 
            // cbFinaleAppointMaxValeur_label
            // 
            this.cbFinaleAppointMaxValeur_label.AutoSize = true;
            this.cbFinaleAppointMaxValeur_label.CausesValidation = false;
            this.cbFinaleAppointMaxValeur_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinaleAppointMaxValeur_label.ForeColor = System.Drawing.Color.Red;
            this.cbFinaleAppointMaxValeur_label.Location = new System.Drawing.Point(101, 39);
            this.cbFinaleAppointMaxValeur_label.Name = "cbFinaleAppointMaxValeur_label";
            this.cbFinaleAppointMaxValeur_label.Size = new System.Drawing.Size(67, 19);
            this.cbFinaleAppointMaxValeur_label.TabIndex = 0;
            this.cbFinaleAppointMaxValeur_label.Text = "valeurCB";
            this.cbFinaleAppointMaxValeur_label.Visible = false;
            // 
            // errorNumericAppoint_label
            // 
            this.errorNumericAppoint_label.AutoSize = true;
            this.errorNumericAppoint_label.CausesValidation = false;
            this.errorNumericAppoint_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNumericAppoint_label.ForeColor = System.Drawing.Color.Red;
            this.errorNumericAppoint_label.Location = new System.Drawing.Point(146, 99);
            this.errorNumericAppoint_label.Name = "errorNumericAppoint_label";
            this.errorNumericAppoint_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorNumericAppoint_label.Size = new System.Drawing.Size(151, 19);
            this.errorNumericAppoint_label.TabIndex = 0;
            this.errorNumericAppoint_label.Text = "Valeur non numérique";
            this.errorNumericAppoint_label.Visible = false;
            // 
            // valeurNiveauSouhaite
            // 
            this.valeurNiveauSouhaite.CausesValidation = false;
            this.valeurNiveauSouhaite.DecimalPlaces = 2;
            this.valeurNiveauSouhaite.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valeurNiveauSouhaite.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.valeurNiveauSouhaite.Location = new System.Drawing.Point(183, 26);
            this.valeurNiveauSouhaite.Maximum = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.valeurNiveauSouhaite.Name = "valeurNiveauSouhaite";
            this.valeurNiveauSouhaite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.valeurNiveauSouhaite.Size = new System.Drawing.Size(79, 27);
            this.valeurNiveauSouhaite.TabIndex = 6;
            this.valeurNiveauSouhaite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valeurNiveauSouhaite.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.valeurNiveauSouhaite.Enter += new System.EventHandler(this.SelectAll_Enter);
            this.valeurNiveauSouhaite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
            // 
            // niveauSouhaiteUnite
            // 
            this.niveauSouhaiteUnite.AutoSize = true;
            this.niveauSouhaiteUnite.CausesValidation = false;
            this.niveauSouhaiteUnite.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveauSouhaiteUnite.Location = new System.Drawing.Point(268, 28);
            this.niveauSouhaiteUnite.Name = "niveauSouhaiteUnite";
            this.niveauSouhaiteUnite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.niveauSouhaiteUnite.Size = new System.Drawing.Size(21, 19);
            this.niveauSouhaiteUnite.TabIndex = 0;
            this.niveauSouhaiteUnite.Text = "m";
            // 
            // appointCalculer_button
            // 
            this.appointCalculer_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointCalculer_button.Location = new System.Drawing.Point(175, 59);
            this.appointCalculer_button.Name = "appointCalculer_button";
            this.appointCalculer_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.appointCalculer_button.Size = new System.Drawing.Size(94, 26);
            this.appointCalculer_button.TabIndex = 7;
            this.appointCalculer_button.Text = "Calculer";
            this.appointCalculer_button.UseVisualStyleBackColor = true;
            this.appointCalculer_button.Click += new System.EventHandler(this.AppointCalculer_button_Click);
            // 
            // verificateur_groupBox
            // 
            this.verificateur_groupBox.CausesValidation = false;
            this.verificateur_groupBox.Controls.Add(this.dateVerificateur_Label);
            this.verificateur_groupBox.Controls.Add(this.nomVerificateur_Label);
            this.verificateur_groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificateur_groupBox.Location = new System.Drawing.Point(386, 427);
            this.verificateur_groupBox.Name = "verificateur_groupBox";
            this.verificateur_groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.verificateur_groupBox.Size = new System.Drawing.Size(371, 138);
            this.verificateur_groupBox.TabIndex = 24;
            this.verificateur_groupBox.TabStop = false;
            this.verificateur_groupBox.Text = "Vérificateur";
            // 
            // dateVerificateur_Label
            // 
            this.dateVerificateur_Label.AutoSize = true;
            this.dateVerificateur_Label.CausesValidation = false;
            this.dateVerificateur_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateVerificateur_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateVerificateur_Label.Location = new System.Drawing.Point(126, 31);
            this.dateVerificateur_Label.Name = "dateVerificateur_Label";
            this.dateVerificateur_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateVerificateur_Label.Size = new System.Drawing.Size(92, 19);
            this.dateVerificateur_Label.TabIndex = 0;
            this.dateVerificateur_Label.Text = "Date Du Jour";
            // 
            // nomVerificateur_Label
            // 
            this.nomVerificateur_Label.AutoSize = true;
            this.nomVerificateur_Label.CausesValidation = false;
            this.nomVerificateur_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomVerificateur_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nomVerificateur_Label.Location = new System.Drawing.Point(20, 72);
            this.nomVerificateur_Label.Name = "nomVerificateur_Label";
            this.nomVerificateur_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nomVerificateur_Label.Size = new System.Drawing.Size(129, 19);
            this.nomVerificateur_Label.TabIndex = 0;
            this.nomVerificateur_Label.Text = "Nom et signature :";
            // 
            // redacteur_groupBox
            // 
            this.redacteur_groupBox.CausesValidation = false;
            this.redacteur_groupBox.Controls.Add(this.dateRedacteur_Label);
            this.redacteur_groupBox.Controls.Add(this.nomRedacteur_Label);
            this.redacteur_groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redacteur_groupBox.Location = new System.Drawing.Point(8, 427);
            this.redacteur_groupBox.Name = "redacteur_groupBox";
            this.redacteur_groupBox.Size = new System.Drawing.Size(371, 138);
            this.redacteur_groupBox.TabIndex = 25;
            this.redacteur_groupBox.TabStop = false;
            this.redacteur_groupBox.Text = "Rédacteur";
            // 
            // dateRedacteur_Label
            // 
            this.dateRedacteur_Label.AutoSize = true;
            this.dateRedacteur_Label.CausesValidation = false;
            this.dateRedacteur_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRedacteur_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateRedacteur_Label.Location = new System.Drawing.Point(126, 31);
            this.dateRedacteur_Label.Name = "dateRedacteur_Label";
            this.dateRedacteur_Label.Size = new System.Drawing.Size(92, 19);
            this.dateRedacteur_Label.TabIndex = 0;
            this.dateRedacteur_Label.Text = "Date Du Jour";
            // 
            // nomRedacteur_Label
            // 
            this.nomRedacteur_Label.AutoSize = true;
            this.nomRedacteur_Label.CausesValidation = false;
            this.nomRedacteur_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomRedacteur_Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nomRedacteur_Label.Location = new System.Drawing.Point(15, 72);
            this.nomRedacteur_Label.Name = "nomRedacteur_Label";
            this.nomRedacteur_Label.Size = new System.Drawing.Size(129, 19);
            this.nomRedacteur_Label.TabIndex = 0;
            this.nomRedacteur_Label.Text = "Nom et signature :";
            // 
            // ptrkDilution_button
            // 
            this.ptrkDilution_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptrkDilution_button.Location = new System.Drawing.Point(6, 69);
            this.ptrkDilution_button.Name = "ptrkDilution_button";
            this.ptrkDilution_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ptrkDilution_button.Size = new System.Drawing.Size(130, 37);
            this.ptrkDilution_button.TabIndex = 10;
            this.ptrkDilution_button.Text = "Dilution";
            this.ptrkDilution_button.UseVisualStyleBackColor = true;
            this.ptrkDilution_button.Click += new System.EventHandler(this.PtrKDilution_Click);
            // 
            // ptrkAppointSED_label
            // 
            this.ptrkAppointSED_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptrkAppointSED_label.CausesValidation = false;
            this.ptrkAppointSED_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptrkAppointSED_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ptrkAppointSED_label.Location = new System.Drawing.Point(6, 26);
            this.ptrkAppointSED_label.Name = "ptrkAppointSED_label";
            this.ptrkAppointSED_label.Size = new System.Drawing.Size(130, 37);
            this.ptrkAppointSED_label.TabIndex = 26;
            this.ptrkAppointSED_label.Text = "Appoint SED";
            this.ptrkAppointSED_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeTransfert_groupbox
            // 
            this.volumeTransfert_groupbox.CausesValidation = false;
            this.volumeTransfert_groupbox.Controls.Add(this.volumeTransfert_label);
            this.volumeTransfert_groupbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeTransfert_groupbox.Location = new System.Drawing.Point(611, 192);
            this.volumeTransfert_groupbox.Name = "volumeTransfert_groupbox";
            this.volumeTransfert_groupbox.Size = new System.Drawing.Size(249, 63);
            this.volumeTransfert_groupbox.TabIndex = 27;
            this.volumeTransfert_groupbox.TabStop = false;
            this.volumeTransfert_groupbox.Text = "Volume Comp. Transfert";
            // 
            // volumeTransfert_label
            // 
            this.volumeTransfert_label.AutoSize = true;
            this.volumeTransfert_label.CausesValidation = false;
            this.volumeTransfert_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeTransfert_label.Location = new System.Drawing.Point(6, 30);
            this.volumeTransfert_label.Name = "volumeTransfert_label";
            this.volumeTransfert_label.Size = new System.Drawing.Size(114, 19);
            this.volumeTransfert_label.TabIndex = 0;
            this.volumeTransfert_label.Text = "volumeTransfert";
            this.volumeTransfert_label.Visible = false;
            // 
            // volumeChateau_groupbox
            // 
            this.volumeChateau_groupbox.CausesValidation = false;
            this.volumeChateau_groupbox.Controls.Add(this.volumeChateau_label);
            this.volumeChateau_groupbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeChateau_groupbox.Location = new System.Drawing.Point(611, 123);
            this.volumeChateau_groupbox.Name = "volumeChateau_groupbox";
            this.volumeChateau_groupbox.Size = new System.Drawing.Size(249, 63);
            this.volumeChateau_groupbox.TabIndex = 28;
            this.volumeChateau_groupbox.TabStop = false;
            this.volumeChateau_groupbox.Text = "Volume Chateau de plomb";
            // 
            // volumeChateau_label
            // 
            this.volumeChateau_label.AutoSize = true;
            this.volumeChateau_label.CausesValidation = false;
            this.volumeChateau_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeChateau_label.Location = new System.Drawing.Point(6, 30);
            this.volumeChateau_label.Name = "volumeChateau_label";
            this.volumeChateau_label.Size = new System.Drawing.Size(110, 19);
            this.volumeChateau_label.TabIndex = 0;
            this.volumeChateau_label.Text = "volumeChateau";
            this.volumeChateau_label.Visible = false;
            // 
            // volumePiscine_groupbox
            // 
            this.volumePiscine_groupbox.CausesValidation = false;
            this.volumePiscine_groupbox.Controls.Add(this.volumePiscine_label);
            this.volumePiscine_groupbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumePiscine_groupbox.Location = new System.Drawing.Point(611, 54);
            this.volumePiscine_groupbox.Name = "volumePiscine_groupbox";
            this.volumePiscine_groupbox.Size = new System.Drawing.Size(249, 63);
            this.volumePiscine_groupbox.TabIndex = 29;
            this.volumePiscine_groupbox.TabStop = false;
            this.volumePiscine_groupbox.Text = "Volume Piscine";
            // 
            // volumePiscine_label
            // 
            this.volumePiscine_label.AutoSize = true;
            this.volumePiscine_label.CausesValidation = false;
            this.volumePiscine_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumePiscine_label.Location = new System.Drawing.Point(6, 30);
            this.volumePiscine_label.Name = "volumePiscine_label";
            this.volumePiscine_label.Size = new System.Drawing.Size(102, 19);
            this.volumePiscine_label.TabIndex = 0;
            this.volumePiscine_label.Text = "volumePiscine";
            this.volumePiscine_label.Visible = false;
            // 
            // formule_label
            // 
            this.formule_label.AutoSize = true;
            this.formule_label.CausesValidation = false;
            this.formule_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formule_label.Location = new System.Drawing.Point(165, 387);
            this.formule_label.Name = "formule_label";
            this.formule_label.Size = new System.Drawing.Size(445, 19);
            this.formule_label.TabIndex = 30;
            this.formule_label.Text = "(Volume total * Cb) / (Volume total + Volume d\'appoint) = Cb Finale";
            // 
            // calculCb_button
            // 
            this.calculCb_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculCb_button.Location = new System.Drawing.Point(18, 89);
            this.calculCb_button.Name = "calculCb_button";
            this.calculCb_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculCb_button.Size = new System.Drawing.Size(130, 37);
            this.calculCb_button.TabIndex = 9;
            this.calculCb_button.Text = "Calcul Cb";
            this.calculCb_button.UseVisualStyleBackColor = true;
            this.calculCb_button.Click += new System.EventHandler(this.CalculCb_Click);
            // 
            // buttonPiscine_groupBox
            // 
            this.buttonPiscine_groupBox.CausesValidation = false;
            this.buttonPiscine_groupBox.Controls.Add(this.ptrkAppointSED_label);
            this.buttonPiscine_groupBox.Controls.Add(this.ptrkDilution_button);
            this.buttonPiscine_groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPiscine_groupBox.Location = new System.Drawing.Point(12, 134);
            this.buttonPiscine_groupBox.Name = "buttonPiscine_groupBox";
            this.buttonPiscine_groupBox.Size = new System.Drawing.Size(145, 118);
            this.buttonPiscine_groupBox.TabIndex = 29;
            this.buttonPiscine_groupBox.TabStop = false;
            this.buttonPiscine_groupBox.Text = "Piscine PTR";
            // 
            // buttonRCV_groupBox
            // 
            this.buttonRCV_groupBox.Controls.Add(this.rcvPlatine_button);
            this.buttonRCV_groupBox.Controls.Add(this.rcvDilution_button);
            this.buttonRCV_groupBox.Controls.Add(this.rcvBorication_button);
            this.buttonRCV_groupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRCV_groupBox.Location = new System.Drawing.Point(12, 258);
            this.buttonRCV_groupBox.Name = "buttonRCV_groupBox";
            this.buttonRCV_groupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRCV_groupBox.Size = new System.Drawing.Size(145, 163);
            this.buttonRCV_groupBox.TabIndex = 31;
            this.buttonRCV_groupBox.TabStop = false;
            this.buttonRCV_groupBox.Text = "RCV";
            // 
            // rcvPlatine_button
            // 
            this.rcvPlatine_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcvPlatine_button.Location = new System.Drawing.Point(6, 26);
            this.rcvPlatine_button.Name = "rcvPlatine_button";
            this.rcvPlatine_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rcvPlatine_button.Size = new System.Drawing.Size(130, 37);
            this.rcvPlatine_button.TabIndex = 11;
            this.rcvPlatine_button.Text = "Réglage platine";
            this.rcvPlatine_button.UseVisualStyleBackColor = true;
            this.rcvPlatine_button.Click += new System.EventHandler(this.RcvReglagePlatine_Click);
            // 
            // rcvDilution_button
            // 
            this.rcvDilution_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcvDilution_button.Location = new System.Drawing.Point(6, 112);
            this.rcvDilution_button.Name = "rcvDilution_button";
            this.rcvDilution_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rcvDilution_button.Size = new System.Drawing.Size(130, 37);
            this.rcvDilution_button.TabIndex = 13;
            this.rcvDilution_button.Text = "Dilution";
            this.rcvDilution_button.UseVisualStyleBackColor = true;
            this.rcvDilution_button.Click += new System.EventHandler(this.RcvDilution_Click);
            // 
            // rcvBorication_button
            // 
            this.rcvBorication_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcvBorication_button.Location = new System.Drawing.Point(6, 69);
            this.rcvBorication_button.Name = "rcvBorication_button";
            this.rcvBorication_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rcvBorication_button.Size = new System.Drawing.Size(130, 37);
            this.rcvBorication_button.TabIndex = 12;
            this.rcvBorication_button.Text = "Borication";
            this.rcvBorication_button.UseVisualStyleBackColor = true;
            this.rcvBorication_button.Click += new System.EventHandler(this.RcvBorication_Click);
            // 
            // PtrKAppointSED
            // 
            this.AcceptButton = this.appointCalculer_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(872, 577);
            this.Controls.Add(this.buttonRCV_groupBox);
            this.Controls.Add(this.formule_label);
            this.Controls.Add(this.volumeTransfert_groupbox);
            this.Controls.Add(this.volumeChateau_groupbox);
            this.Controls.Add(this.buttonPiscine_groupBox);
            this.Controls.Add(this.volumePiscine_groupbox);
            this.Controls.Add(this.verificateur_groupBox);
            this.Controls.Add(this.redacteur_groupBox);
            this.Controls.Add(this.appoint_groupbox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.cbPTRK_label);
            this.Controls.Add(this.niveauPiscine_number);
            this.Controls.Add(this.calculCb_button);
            this.Controls.Add(this.compartimentTransfert);
            this.Controls.Add(this.niveauPiscineUnite_label);
            this.Controls.Add(this.batardeau_label);
            this.Controls.Add(this.chateauDePlomb);
            this.Controls.Add(this.niveauPiscine_label);
            this.Controls.Add(this.cbPTRK_number);
            this.Controls.Add(this.cbPTRKUnite_label);
            this.Controls.Add(this.logoEDF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PtrKAppointSED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul de Cb";
            this.Load += new System.EventHandler(this.PtrkKAppointSED_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoEDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveauPiscine_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPTRK_number)).EndInit();
            this.appoint_groupbox.ResumeLayout(false);
            this.appoint_groupbox.PerformLayout();
            this.niveau_groupbox.ResumeLayout(false);
            this.niveau_groupbox.PerformLayout();
            this.niveauMax_groupbox.ResumeLayout(false);
            this.niveauMax_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valeurNiveauSouhaite)).EndInit();
            this.verificateur_groupBox.ResumeLayout(false);
            this.verificateur_groupBox.PerformLayout();
            this.redacteur_groupBox.ResumeLayout(false);
            this.redacteur_groupBox.PerformLayout();
            this.volumeTransfert_groupbox.ResumeLayout(false);
            this.volumeTransfert_groupbox.PerformLayout();
            this.volumeChateau_groupbox.ResumeLayout(false);
            this.volumeChateau_groupbox.PerformLayout();
            this.volumePiscine_groupbox.ResumeLayout(false);
            this.volumePiscine_groupbox.PerformLayout();
            this.buttonPiscine_groupBox.ResumeLayout(false);
            this.buttonRCV_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoEDF;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label cbPTRK_label;
        private System.Windows.Forms.NumericUpDown niveauPiscine_number;
        private System.Windows.Forms.CheckBox compartimentTransfert;
        private System.Windows.Forms.Label niveauPiscineUnite_label;
        private System.Windows.Forms.Label batardeau_label;
        private System.Windows.Forms.CheckBox chateauDePlomb;
        private System.Windows.Forms.Label niveauPiscine_label;
        private System.Windows.Forms.NumericUpDown cbPTRK_number;
        private System.Windows.Forms.Label cbPTRKUnite_label;
        private System.Windows.Forms.GroupBox appoint_groupbox;
        private System.Windows.Forms.GroupBox niveau_groupbox;
        private System.Windows.Forms.Label cbFinaleAppoint_label;
        private System.Windows.Forms.Label cbFinaleAppointValeur_label;
        private System.Windows.Forms.Label niveauSouhaite_label;
        private System.Windows.Forms.GroupBox niveauMax_groupbox;
        private System.Windows.Forms.Label cbFinaleAppointMax_label;
        private System.Windows.Forms.Label cbFinaleAppointMaxValeur_label;
        private System.Windows.Forms.Label errorNumericAppoint_label;
        private System.Windows.Forms.NumericUpDown valeurNiveauSouhaite;
        private System.Windows.Forms.Label niveauSouhaiteUnite;
        private System.Windows.Forms.Button appointCalculer_button;
        private System.Windows.Forms.GroupBox verificateur_groupBox;
        private System.Windows.Forms.Label dateVerificateur_Label;
        private System.Windows.Forms.Label nomVerificateur_Label;
        private System.Windows.Forms.GroupBox redacteur_groupBox;
        private System.Windows.Forms.Label dateRedacteur_Label;
        private System.Windows.Forms.Label nomRedacteur_Label;
        private System.Windows.Forms.Button ptrkDilution_button;
        private System.Windows.Forms.Label ptrkAppointSED_label;
        private System.Windows.Forms.GroupBox volumeTransfert_groupbox;
        private System.Windows.Forms.Label volumeTransfert_label;
        private System.Windows.Forms.GroupBox volumeChateau_groupbox;
        private System.Windows.Forms.Label volumeChateau_label;
        private System.Windows.Forms.GroupBox volumePiscine_groupbox;
        private System.Windows.Forms.Label volumePiscine_label;
        private System.Windows.Forms.Label formule_label;
        private System.Windows.Forms.Button calculCb_button;
        private System.Windows.Forms.GroupBox buttonPiscine_groupBox;
        private System.Windows.Forms.GroupBox buttonRCV_groupBox;
        private System.Windows.Forms.Button rcvPlatine_button;
        private System.Windows.Forms.Button rcvDilution_button;
        private System.Windows.Forms.Button rcvBorication_button;
    }
}