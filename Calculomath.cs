namespace Calculomath
{
    public partial class Calculomath : Form
    {
        #region Properties
        private Random random = new Random();

        private int reponseCalcul = 0;

        List<Calcul> calculList = new List<Calcul>();
        List<DateOnlyCalculList> dateOnlyCalculList = new List<DateOnlyCalculList>();

        TimeSpan tempsEcoule = TimeSpan.Zero;
        DateTime debutCalcul = DateTime.Now;
        DateTime debutSession = DateTime.Now;
        TimeSpan dureeSession = TimeSpan.Zero;

        bool GoodAnswer = true;

        bool sessionTerminee = false;

        bool premiereErreurSurCalculCourant = false;

        int NombreDeCalcul = 0;

        string typeDeCalculSelectionne = "A";

        string userName = string.Empty;

        private Button? btnArrêt;
        private Button? btnCréerUtilisateur;
        private Button? btnOnCommence;
        private Button? btnRetourAnalyse;
        private Button? btnRetourFinSession;
        private Button? butAnalyse;

        private ComboBox? comboBoxPeriodeAnalyse;
        private ComboBox? comboBoxUtilisateurExistant;

        private Label? lblMaximum;
        private Label? lblMinimum;
        private Label? lblNouvelUtilisateur;
        private Label? lblError;
        private Label? lblPremierNombre;
        private Label? lblDernierNombre;
        private Label? lblUtilisateurExistant;
        private Label? lblLigne;
        private Label? lblASMD;
        private Label? lblCalculPour;
        private Label? lblTime;
        private Label? lblMinutes;
        private Label? lblTimer;
        private Label? lblNombreDeCalcul;
        private Label? lblCalcul;
        private Label? lblTitreConfigure;
        private Label? lblSousTitreConfigure;
        private Label? lblPeriodeAnalyse;
        private Label? lblVisualisationCalcul;

        private NumericUpDown? numericUpDownMax;
        private NumericUpDown? numericUpDownMin;
        private NumericUpDown? numericUpDownCalculXMinutes;

        private Panel? panelConfigure;
        private DoubleBufferedPanel panelCalcul;
        private RadioButton? radioButtonDivision;
        private RadioButton? radioButtonMultiplication;
        private RadioButton? radioButtonSoustraction;
        private RadioButton? radioButtonAddition;

        private TextBox? textBoxCalcul;
        private TextBox? textBoxNouvelUtilisateur;
        private System.ComponentModel.IContainer? components;
        private Label? lblNomDeUtilisateur;
        private Label? lblUtilisateur;
        private Panel? panelAnalyse;
        private Panel? panelGraphiqueAnalyse;
        private Label? lblTitreAnalyse;
        private Label? lblSousTitreAnalyseArchive;
        private Label? lblGrilleCalculsAnalyse;
        private TableLayoutPanel? panelTableauxAnalyse;
        private DoubleBufferedPanel? panelGoodPercentage;
        private DataGridView? dataGridViewAnalyseCalculs;
        private Timer? timerCalcul;
        private const int EspacementCarteTableauAnalyse = 16;
        private const int NombreCartesTableauAnalyse = 4;
        private const int HauteurMessageTableauVide = 120;

        #endregion Properties

        #region Constructors
        public Calculomath()
        {
            InitializeComponent();
            ChargerUtilisateursExistants();
            DockPanelsAndResizeClientWindow();
            InitialiserPanelAnalyse();
        }

        #endregion

        #region Initialization
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelConfigure = new Panel();
            panelAnalyse = new Panel();
            lblSousTitreConfigure = new Label();
            lblTitreConfigure = new Label();
            lblMinutes = new Label();
            numericUpDownCalculXMinutes = new NumericUpDown();
            lblCalculPour = new Label();
            btnOnCommence = new Button();
            numericUpDownMax = new NumericUpDown();
            numericUpDownMin = new NumericUpDown();
            lblMaximum = new Label();
            lblMinimum = new Label();
            radioButtonDivision = new RadioButton();
            radioButtonMultiplication = new RadioButton();
            radioButtonSoustraction = new RadioButton();
            radioButtonAddition = new RadioButton();
            lblUtilisateurExistant = new Label();
            comboBoxUtilisateurExistant = new ComboBox();
            lblNouvelUtilisateur = new Label();
            lblError = new Label();
            btnCréerUtilisateur = new Button();
            textBoxNouvelUtilisateur = new TextBox();
            panelCalcul = new DoubleBufferedPanel();
            butAnalyse = new Button();
            lblNomDeUtilisateur = new Label();
            lblUtilisateur = new Label();
            lblNombreDeCalcul = new Label();
            lblCalcul = new Label();
            lblTimer = new Label();
            lblTime = new Label();
            lblVisualisationCalcul = new Label();
            textBoxCalcul = new TextBox();
            lblLigne = new Label();
            lblASMD = new Label();
            lblDernierNombre = new Label();
            lblPremierNombre = new Label();
            btnRetourFinSession = new Button();
            btnArrêt = new Button();
            timerCalcul = new Timer(components);
            panelGoodPercentage = new DoubleBufferedPanel();
            panelConfigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCalculXMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            panelCalcul.SuspendLayout();
            SuspendLayout();
            // 
            // panelConfigure
            // 
            panelConfigure.BackColor = Color.FromArgb(245, 247, 255);
            panelConfigure.Controls.Add(lblSousTitreConfigure);
            panelConfigure.Controls.Add(lblTitreConfigure);
            panelConfigure.Controls.Add(lblMinutes);
            panelConfigure.Controls.Add(numericUpDownCalculXMinutes);
            panelConfigure.Controls.Add(lblCalculPour);
            panelConfigure.Controls.Add(btnOnCommence);
            panelConfigure.Controls.Add(numericUpDownMax);
            panelConfigure.Controls.Add(numericUpDownMin);
            panelConfigure.Controls.Add(lblMaximum);
            panelConfigure.Controls.Add(lblMinimum);
            panelConfigure.Controls.Add(radioButtonDivision);
            panelConfigure.Controls.Add(radioButtonMultiplication);
            panelConfigure.Controls.Add(radioButtonSoustraction);
            panelConfigure.Controls.Add(radioButtonAddition);
            panelConfigure.Controls.Add(lblUtilisateurExistant);
            panelConfigure.Controls.Add(comboBoxUtilisateurExistant);
            panelConfigure.Controls.Add(lblNouvelUtilisateur);
            panelConfigure.Controls.Add(lblError);
            panelConfigure.Controls.Add(btnCréerUtilisateur);
            panelConfigure.Controls.Add(textBoxNouvelUtilisateur);
            panelConfigure.Location = new Point(0, 0);
            panelConfigure.Name = "panelConfigure";
            panelConfigure.Size = new Size(700, 700);
            panelConfigure.TabIndex = 0;
            // 
            // panelAnalyse
            // 
            panelAnalyse.Location = new Point(193, 706);
            panelAnalyse.Name = "panelAnalyse";
            panelAnalyse.Size = new Size(232, 61);
            panelAnalyse.TabIndex = 31;
            // 
            // lblSousTitreConfigure
            // 
            lblSousTitreConfigure.AutoSize = true;
            lblSousTitreConfigure.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSousTitreConfigure.ForeColor = Color.FromArgb(91, 104, 128);
            lblSousTitreConfigure.Location = new Point(126, 61);
            lblSousTitreConfigure.Name = "lblSousTitreConfigure";
            lblSousTitreConfigure.Size = new Size(275, 21);
            lblSousTitreConfigure.TabIndex = 35;
            lblSousTitreConfigure.Text = "Prépare une nouvelle séance de calcul.";
            // 
            // lblTitreConfigure
            // 
            lblTitreConfigure.AutoSize = true;
            lblTitreConfigure.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitreConfigure.ForeColor = Color.FromArgb(44, 62, 102);
            lblTitreConfigure.Location = new Point(110, 18);
            lblTitreConfigure.Name = "lblTitreConfigure";
            lblTitreConfigure.Size = new Size(315, 45);
            lblTitreConfigure.TabIndex = 34;
            lblTitreConfigure.Text = "Configurer la partie";
            // 
            // lblMinutes
            // 
            lblMinutes.AutoSize = true;
            lblMinutes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinutes.ForeColor = Color.FromArgb(91, 104, 128);
            lblMinutes.Location = new Point(382, 474);
            lblMinutes.Name = "lblMinutes";
            lblMinutes.Size = new Size(84, 25);
            lblMinutes.TabIndex = 33;
            lblMinutes.Text = "Minutes";
            // 
            // numericUpDownCalculXMinutes
            // 
            numericUpDownCalculXMinutes.BackColor = Color.White;
            numericUpDownCalculXMinutes.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownCalculXMinutes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownCalculXMinutes.Location = new Point(234, 474);
            numericUpDownCalculXMinutes.Name = "numericUpDownCalculXMinutes";
            numericUpDownCalculXMinutes.Size = new Size(110, 27);
            numericUpDownCalculXMinutes.TabIndex = 9;
            numericUpDownCalculXMinutes.TextAlign = HorizontalAlignment.Center;
            numericUpDownCalculXMinutes.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblCalculPour
            // 
            lblCalculPour.AutoSize = true;
            lblCalculPour.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblCalculPour.ForeColor = Color.FromArgb(44, 62, 102);
            lblCalculPour.Location = new Point(84, 474);
            lblCalculPour.Name = "lblCalculPour";
            lblCalculPour.Size = new Size(124, 25);
            lblCalculPour.TabIndex = 31;
            lblCalculPour.Text = "Calcul pour :";
            // 
            // btnOnCommence
            // 
            btnOnCommence.BackColor = Color.FromArgb(73, 193, 121);
            btnOnCommence.FlatAppearance.BorderSize = 0;
            btnOnCommence.FlatStyle = FlatStyle.Flat;
            btnOnCommence.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOnCommence.ForeColor = Color.White;
            btnOnCommence.Location = new Point(84, 550);
            btnOnCommence.Name = "btnOnCommence";
            btnOnCommence.Size = new Size(494, 52);
            btnOnCommence.TabIndex = 10;
            btnOnCommence.Text = "On commence";
            btnOnCommence.UseVisualStyleBackColor = false;
            btnOnCommence.Click += btnOnCommence_Click;
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.BackColor = Color.White;
            numericUpDownMax.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownMax.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownMax.Location = new Point(336, 412);
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Size = new Size(146, 27);
            numericUpDownMax.TabIndex = 8;
            numericUpDownMax.TextAlign = HorizontalAlignment.Center;
            numericUpDownMax.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.BackColor = Color.White;
            numericUpDownMin.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownMin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownMin.Location = new Point(84, 412);
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new Size(146, 27);
            numericUpDownMin.TabIndex = 7;
            numericUpDownMin.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMaximum
            // 
            lblMaximum.AutoSize = true;
            lblMaximum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblMaximum.ForeColor = Color.FromArgb(44, 62, 102);
            lblMaximum.Location = new Point(336, 386);
            lblMaximum.Name = "lblMaximum";
            lblMaximum.Size = new Size(102, 25);
            lblMaximum.TabIndex = 26;
            lblMaximum.Text = "Maximum";
            // 
            // lblMinimum
            // 
            lblMinimum.AutoSize = true;
            lblMinimum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblMinimum.ForeColor = Color.FromArgb(44, 62, 102);
            lblMinimum.Location = new Point(84, 386);
            lblMinimum.Name = "lblMinimum";
            lblMinimum.Size = new Size(98, 25);
            lblMinimum.TabIndex = 25;
            lblMinimum.Text = "Minimum";
            // 
            // radioButtonDivision
            // 
            radioButtonDivision.AutoSize = true;
            radioButtonDivision.Font = new Font("Segoe UI", 14.25F);
            radioButtonDivision.ForeColor = Color.FromArgb(52, 73, 94);
            radioButtonDivision.Location = new Point(359, 324);
            radioButtonDivision.Name = "radioButtonDivision";
            radioButtonDivision.Size = new Size(97, 29);
            radioButtonDivision.TabIndex = 6;
            radioButtonDivision.Text = "Division";
            radioButtonDivision.UseVisualStyleBackColor = true;
            radioButtonDivision.CheckedChanged += radioButtonTypeCalcul_CheckedChanged;
            // 
            // radioButtonMultiplication
            // 
            radioButtonMultiplication.AutoSize = true;
            radioButtonMultiplication.Font = new Font("Segoe UI", 14.25F);
            radioButtonMultiplication.ForeColor = Color.FromArgb(52, 73, 94);
            radioButtonMultiplication.Location = new Point(84, 324);
            radioButtonMultiplication.Name = "radioButtonMultiplication";
            radioButtonMultiplication.Size = new Size(147, 29);
            radioButtonMultiplication.TabIndex = 5;
            radioButtonMultiplication.Text = "Multiplication";
            radioButtonMultiplication.UseVisualStyleBackColor = true;
            radioButtonMultiplication.CheckedChanged += radioButtonTypeCalcul_CheckedChanged;
            // 
            // radioButtonSoustraction
            // 
            radioButtonSoustraction.AutoSize = true;
            radioButtonSoustraction.Font = new Font("Segoe UI", 14.25F);
            radioButtonSoustraction.ForeColor = Color.FromArgb(52, 73, 94);
            radioButtonSoustraction.Location = new Point(359, 280);
            radioButtonSoustraction.Name = "radioButtonSoustraction";
            radioButtonSoustraction.Size = new Size(135, 29);
            radioButtonSoustraction.TabIndex = 4;
            radioButtonSoustraction.Text = "Soustraction";
            radioButtonSoustraction.UseVisualStyleBackColor = true;
            radioButtonSoustraction.CheckedChanged += radioButtonTypeCalcul_CheckedChanged;
            // 
            // radioButtonAddition
            // 
            radioButtonAddition.AutoSize = true;
            radioButtonAddition.Checked = true;
            radioButtonAddition.Font = new Font("Segoe UI", 14.25F);
            radioButtonAddition.ForeColor = Color.FromArgb(52, 73, 94);
            radioButtonAddition.Location = new Point(84, 280);
            radioButtonAddition.Name = "radioButtonAddition";
            radioButtonAddition.Size = new Size(102, 29);
            radioButtonAddition.TabIndex = 3;
            radioButtonAddition.TabStop = true;
            radioButtonAddition.Text = "Addition";
            radioButtonAddition.UseVisualStyleBackColor = true;
            radioButtonAddition.CheckedChanged += radioButtonTypeCalcul_CheckedChanged;
            // 
            // lblUtilisateurExistant
            // 
            lblUtilisateurExistant.AutoSize = true;
            lblUtilisateurExistant.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUtilisateurExistant.ForeColor = Color.FromArgb(44, 62, 102);
            lblUtilisateurExistant.Location = new Point(84, 199);
            lblUtilisateurExistant.Name = "lblUtilisateurExistant";
            lblUtilisateurExistant.Size = new Size(162, 21);
            lblUtilisateurExistant.TabIndex = 20;
            lblUtilisateurExistant.Text = "Utilisateurs Existant";
            // 
            // comboBoxUtilisateurExistant
            // 
            comboBoxUtilisateurExistant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUtilisateurExistant.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxUtilisateurExistant.FormattingEnabled = true;
            comboBoxUtilisateurExistant.Location = new Point(84, 221);
            comboBoxUtilisateurExistant.Name = "comboBoxUtilisateurExistant";
            comboBoxUtilisateurExistant.Size = new Size(427, 33);
            comboBoxUtilisateurExistant.TabIndex = 2;
            comboBoxUtilisateurExistant.SelectedValueChanged += comboBoxUtilisateurExistant_SelectedValueChanged;
            // 
            // lblNouvelUtilisateur
            // 
            lblNouvelUtilisateur.AutoSize = true;
            lblNouvelUtilisateur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNouvelUtilisateur.ForeColor = Color.FromArgb(44, 62, 102);
            lblNouvelUtilisateur.Location = new Point(84, 113);
            lblNouvelUtilisateur.Name = "lblNouvelUtilisateur";
            lblNouvelUtilisateur.Size = new Size(148, 21);
            lblNouvelUtilisateur.TabIndex = 18;
            lblNouvelUtilisateur.Text = "Nouvel utilisateur";
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(84, 525);
            lblError.Name = "lblError";
            lblError.Size = new Size(494, 20);
            lblError.TabIndex = 17;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCréerUtilisateur
            // 
            btnCréerUtilisateur.BackColor = Color.FromArgb(72, 133, 237);
            btnCréerUtilisateur.FlatAppearance.BorderSize = 0;
            btnCréerUtilisateur.FlatStyle = FlatStyle.Flat;
            btnCréerUtilisateur.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCréerUtilisateur.ForeColor = Color.White;
            btnCréerUtilisateur.Location = new Point(405, 136);
            btnCréerUtilisateur.Name = "btnCréerUtilisateur";
            btnCréerUtilisateur.Size = new Size(106, 33);
            btnCréerUtilisateur.TabIndex = 1;
            btnCréerUtilisateur.Text = "Créer";
            btnCréerUtilisateur.UseVisualStyleBackColor = true;
            btnCréerUtilisateur.Click += btnCréerUtilisateur_Click;
            // 
            // textBoxNouvelUtilisateur
            // 
            textBoxNouvelUtilisateur.BorderStyle = BorderStyle.FixedSingle;
            textBoxNouvelUtilisateur.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNouvelUtilisateur.Location = new Point(84, 136);
            textBoxNouvelUtilisateur.Name = "textBoxNouvelUtilisateur";
            textBoxNouvelUtilisateur.Size = new Size(224, 33);
            textBoxNouvelUtilisateur.TabIndex = 0;
            // 
            // panelCalcul
            // 
            panelCalcul.BackColor = Color.FromArgb(245, 247, 255);
            panelCalcul.Controls.Add(butAnalyse);
            panelCalcul.Controls.Add(lblNomDeUtilisateur);
            panelCalcul.Controls.Add(lblUtilisateur);
            panelCalcul.Controls.Add(lblNombreDeCalcul);
            panelCalcul.Controls.Add(lblCalcul);
            panelCalcul.Controls.Add(lblTimer);
            panelCalcul.Controls.Add(lblTime);
            panelCalcul.Controls.Add(lblVisualisationCalcul);
            panelCalcul.Controls.Add(textBoxCalcul);
            panelCalcul.Controls.Add(lblLigne);
            panelCalcul.Controls.Add(lblASMD);
            panelCalcul.Controls.Add(lblDernierNombre);
            panelCalcul.Controls.Add(lblPremierNombre);
            panelCalcul.Controls.Add(btnRetourFinSession);
            panelCalcul.Controls.Add(btnArrêt);
            panelCalcul.Location = new Point(733, 18);
            panelCalcul.Name = "panelCalcul";
            panelCalcul.Padding = new Padding(24);
            panelCalcul.Size = new Size(700, 700);
            panelCalcul.TabIndex = 30;
            // 
            // butAnalyse
            // 
            butAnalyse.BackColor = Color.White;
            butAnalyse.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            butAnalyse.FlatStyle = FlatStyle.Flat;
            butAnalyse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            butAnalyse.ForeColor = Color.FromArgb(44, 62, 102);
            butAnalyse.Location = new Point(236, 27);
            butAnalyse.Name = "butAnalyse";
            butAnalyse.Size = new Size(188, 34);
            butAnalyse.TabIndex = 14;
            butAnalyse.Text = "Voir analyse";
            butAnalyse.UseVisualStyleBackColor = false;
            butAnalyse.Click += butAnalyse_Click;
            // 
            // lblNomDeUtilisateur
            // 
            lblNomDeUtilisateur.AutoSize = true;
            lblNomDeUtilisateur.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomDeUtilisateur.ForeColor = Color.FromArgb(44, 62, 102);
            lblNomDeUtilisateur.Location = new Point(28, 112);
            lblNomDeUtilisateur.MaximumSize = new Size(220, 0);
            lblNomDeUtilisateur.Name = "lblNomDeUtilisateur";
            lblNomDeUtilisateur.Size = new Size(121, 30);
            lblNomDeUtilisateur.TabIndex = 13;
            lblNomDeUtilisateur.Text = "Utilisateur";
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.AutoSize = true;
            lblUtilisateur.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUtilisateur.ForeColor = Color.FromArgb(91, 104, 128);
            lblUtilisateur.Location = new Point(28, 84);
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Size = new Size(107, 25);
            lblUtilisateur.TabIndex = 12;
            lblUtilisateur.Text = "Utilisateur :";
            // 
            // lblNombreDeCalcul
            // 
            lblNombreDeCalcul.AutoSize = true;
            lblNombreDeCalcul.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreDeCalcul.ForeColor = Color.FromArgb(44, 62, 102);
            lblNombreDeCalcul.Location = new Point(514, 172);
            lblNombreDeCalcul.Name = "lblNombreDeCalcul";
            lblNombreDeCalcul.Size = new Size(98, 30);
            lblNombreDeCalcul.TabIndex = 11;
            lblNombreDeCalcul.Text = "Nombre";
            lblNombreDeCalcul.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCalcul
            // 
            lblCalcul.AutoSize = true;
            lblCalcul.Font = new Font("Segoe UI", 12F);
            lblCalcul.ForeColor = Color.FromArgb(91, 104, 128);
            lblCalcul.Location = new Point(544, 151);
            lblCalcul.Name = "lblCalcul";
            lblCalcul.Size = new Size(69, 21);
            lblCalcul.TabIndex = 10;
            lblCalcul.Text = "Réussis :";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 12F);
            lblTimer.ForeColor = Color.FromArgb(91, 104, 128);
            lblTimer.Location = new Point(550, 94);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(61, 21);
            lblTimer.TabIndex = 9;
            lblTimer.Text = "Temps :";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.FromArgb(44, 62, 102);
            lblTime.Location = new Point(514, 113);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(70, 30);
            lblTime.TabIndex = 8;
            lblTime.Text = "Temp";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVisualisationCalcul
            // 
            lblVisualisationCalcul.BackColor = Color.White;
            lblVisualisationCalcul.BorderStyle = BorderStyle.FixedSingle;
            lblVisualisationCalcul.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisualisationCalcul.ForeColor = Color.FromArgb(91, 104, 128);
            lblVisualisationCalcul.Location = new Point(121, 468);
            lblVisualisationCalcul.Name = "lblVisualisationCalcul";
            lblVisualisationCalcul.Size = new Size(387, 96);
            lblVisualisationCalcul.TabIndex = 15;
            lblVisualisationCalcul.TextAlign = ContentAlignment.MiddleCenter;
            lblVisualisationCalcul.Visible = false;
            // 
            // textBoxCalcul
            // 
            textBoxCalcul.BackColor = Color.White;
            textBoxCalcul.BorderStyle = BorderStyle.FixedSingle;
            textBoxCalcul.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxCalcul.ForeColor = Color.FromArgb(44, 62, 102);
            textBoxCalcul.Location = new Point(153, 375);
            textBoxCalcul.Name = "textBoxCalcul";
            textBoxCalcul.PlaceholderText = "Ta réponse";
            textBoxCalcul.Size = new Size(318, 57);
            textBoxCalcul.TabIndex = 1;
            textBoxCalcul.TextAlign = HorizontalAlignment.Center;
            textBoxCalcul.KeyPress += textBoxCalcul_KeyPress;
            // 
            // lblLigne
            // 
            lblLigne.AutoSize = true;
            lblLigne.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLigne.ForeColor = Color.FromArgb(203, 213, 225);
            lblLigne.Location = new Point(140, 327);
            lblLigne.Name = "lblLigne";
            lblLigne.Size = new Size(348, 25);
            lblLigne.TabIndex = 6;
            lblLigne.Text = "__________________________________________";
            // 
            // lblASMD
            // 
            lblASMD.AutoSize = true;
            lblASMD.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblASMD.ForeColor = Color.FromArgb(72, 133, 237);
            lblASMD.Location = new Point(214, 245);
            lblASMD.Name = "lblASMD";
            lblASMD.Size = new Size(62, 65);
            lblASMD.TabIndex = 5;
            lblASMD.Text = "+";
            // 
            // lblDernierNombre
            // 
            lblDernierNombre.AutoSize = true;
            lblDernierNombre.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDernierNombre.ForeColor = Color.FromArgb(44, 62, 102);
            lblDernierNombre.Location = new Point(299, 247);
            lblDernierNombre.Name = "lblDernierNombre";
            lblDernierNombre.Size = new Size(56, 65);
            lblDernierNombre.TabIndex = 4;
            lblDernierNombre.Text = "0";
            // 
            // lblPremierNombre
            // 
            lblPremierNombre.AutoSize = true;
            lblPremierNombre.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPremierNombre.ForeColor = Color.FromArgb(44, 62, 102);
            lblPremierNombre.Location = new Point(299, 179);
            lblPremierNombre.Name = "lblPremierNombre";
            lblPremierNombre.Size = new Size(56, 65);
            lblPremierNombre.TabIndex = 3;
            lblPremierNombre.Text = "0";
            // 
            // btnRetourFinSession
            // 
            btnRetourFinSession.BackColor = Color.FromArgb(72, 133, 237);
            btnRetourFinSession.FlatAppearance.BorderSize = 0;
            btnRetourFinSession.FlatStyle = FlatStyle.Flat;
            btnRetourFinSession.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRetourFinSession.ForeColor = Color.White;
            btnRetourFinSession.Location = new Point(58, 27);
            btnRetourFinSession.Name = "btnRetourFinSession";
            btnRetourFinSession.Size = new Size(126, 34);
            btnRetourFinSession.TabIndex = 16;
            btnRetourFinSession.Text = "Retour";
            btnRetourFinSession.UseVisualStyleBackColor = false;
            btnRetourFinSession.Visible = false;
            btnRetourFinSession.Click += btnRetourFinSession_Click;
            // 
            // btnArrêt
            // 
            btnArrêt.BackColor = Color.FromArgb(229, 72, 77);
            btnArrêt.FlatAppearance.BorderSize = 0;
            btnArrêt.FlatStyle = FlatStyle.Flat;
            btnArrêt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnArrêt.ForeColor = Color.White;
            btnArrêt.Location = new Point(482, 27);
            btnArrêt.Name = "btnArrêt";
            btnArrêt.Size = new Size(126, 34);
            btnArrêt.TabIndex = 0;
            btnArrêt.Text = "Arrêt";
            btnArrêt.UseVisualStyleBackColor = false;
            btnArrêt.Click += btnArrêt_Click;
            // 
            // panelGoodPercentage
            // 
            panelGoodPercentage.Location = new Point(525, 513);
            panelGoodPercentage.Name = "panelGoodPercentage";
            panelGoodPercentage.Size = new Size(401, 65);
            panelGoodPercentage.TabIndex = 32;
            // 
            // Calculomath
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 255);
            ClientSize = new Size(1550, 767);
            Controls.Add(panelAnalyse);
            Controls.Add(panelConfigure);
            Controls.Add(panelCalcul);
            Margin = new Padding(2);
            Name = "Calculomath";
            Text = "Calculomath";
            panelConfigure.ResumeLayout(false);
            panelConfigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCalculXMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            panelCalcul.ResumeLayout(false);
            panelCalcul.PerformLayout();
            ResumeLayout(false);

        }

        private void DockPanelsAndResizeClientWindow()
        {
            ClientSize = new Size(700, 700);
            panelConfigure!.Location = new Point(0, 0);
            panelCalcul!.Location = new Point(0, 0);
            panelAnalyse!.Location = new Point(0, 0);
            panelConfigure.Size = new Size(700, 700);
            panelCalcul.Size = new Size(700, 700);
            panelAnalyse.Size = new Size(700, 700);
            panelConfigure!.Dock = DockStyle.Fill;
            panelCalcul!.Dock = DockStyle.Fill;
            panelAnalyse!.Dock = DockStyle.Fill;
            panelCalcul.Visible = false;
            panelAnalyse.Visible = false;
            panelConfigure.Visible = true;

            timerCalcul!.Interval = 1000;

            timerCalcul.Tick += (s, args) =>
            {
                TimeSpan tempsEcouleSession = DateTime.Now - debutSession;

                if (tempsEcouleSession >= dureeSession)
                {
                    lblTime!.Text = $"{dureeSession.Minutes:D2}:{dureeSession.Seconds:D2}";
                    TerminerSessionCalcul(tempsEcoule: true);
                    return;
                }

                lblTime!.Text = $"{tempsEcouleSession.Minutes:D2}:{tempsEcouleSession.Seconds:D2}";
            };

        }

        private void InitialiserPanelAnalyse()
        {
            panelAnalyse!.BackColor = Color.FromArgb(245, 247, 255);
            panelAnalyse.AutoScroll = true;

            btnRetourAnalyse = new Button
            {
                BackColor = Color.FromArgb(72, 133, 237),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(28, 24),
                Name = "btnRetourAnalyse",
                Size = new Size(94, 34),
                TabIndex = 0,
                Text = "Retour",
                UseVisualStyleBackColor = false
            };
            btnRetourAnalyse.FlatAppearance.BorderSize = 0;
            btnRetourAnalyse.Click += btnRetourAnalyse_Click;

            lblTitreAnalyse = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(44, 62, 102),
                Location = new Point(28, 74),
                Name = "lblTitreAnalyse",
                Text = "Analyse des archives"
            };

            lblSousTitreAnalyseArchive = new Label
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(91, 104, 128),
                Location = new Point(32, 118),
                Name = "lblSousTitreAnalyseArchive",
                Size = new Size(720, 38),
                Text = "Données chargées depuis App\\Data\\Testing."
            };

            lblPeriodeAnalyse = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(44, 62, 102),
                Location = new Point(32, 160),
                Name = "lblPeriodeAnalyse",
                Text = "Période :"
            };

            comboBoxPeriodeAnalyse = new ComboBox
            {
                BackColor = Color.White,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(104, 156),
                Name = "comboBoxPeriodeAnalyse",
                Size = new Size(170, 25)
            };
            comboBoxPeriodeAnalyse.Items.AddRange(["Quotidien", "Hebdomadaire", "Mensuel", "Annuel"]);
            comboBoxPeriodeAnalyse.SelectedIndex = 0;
            comboBoxPeriodeAnalyse.SelectedIndexChanged += (_, _) =>
            {
                panelGraphiqueAnalyse?.Invalidate();
                RafraichirTableauxAnalyseParType();
            };

            panelGraphiqueAnalyse = new DoubleBufferedPanel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(32, 194),
                Name = "panelGraphiqueAnalyse",
                Size = new Size(720, 360),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            panelGraphiqueAnalyse.Paint += panelGraphiqueAnalyse_Paint;

            panelTableauxAnalyse = new TableLayoutPanel
            {
                BackColor = Color.FromArgb(245, 247, 255),
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                ColumnCount = 1,
                GrowStyle = TableLayoutPanelGrowStyle.FixedSize,
                Location = new Point(32, 578),
                Margin = Padding.Empty,
                Name = "panelTableauxAnalyse",
                Padding = Padding.Empty
            };
            panelTableauxAnalyse.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            lblGrilleCalculsAnalyse = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(44, 62, 102),
                Location = new Point(32, 578),
                Name = "lblGrilleCalculsAnalyse",
                Text = "Tableaux de réussite par opération"
            };

            panelAnalyse.Controls.Add(btnRetourAnalyse);
            panelAnalyse.Controls.Add(lblTitreAnalyse);
            panelAnalyse.Controls.Add(lblSousTitreAnalyseArchive);
            panelAnalyse.Controls.Add(lblPeriodeAnalyse);
            panelAnalyse.Controls.Add(comboBoxPeriodeAnalyse);
            panelAnalyse.Controls.Add(panelGraphiqueAnalyse);
            panelAnalyse.Controls.Add(lblGrilleCalculsAnalyse);
            panelAnalyse.Controls.Add(panelTableauxAnalyse);
            panelAnalyse.Resize += (_, _) => AjusterDispositionPanelAnalyse();

            AjusterDispositionPanelAnalyse();
            RafraichirTableauxAnalyseParType();
        }

        private void AjusterDispositionPanelAnalyse()
        {
            if (panelAnalyse == null || lblSousTitreAnalyseArchive == null || lblPeriodeAnalyse == null || comboBoxPeriodeAnalyse == null || panelGraphiqueAnalyse == null || panelTableauxAnalyse == null || lblGrilleCalculsAnalyse == null)
            {
                return;
            }

            const int margeHorizontale = 32;
            const int margeBas = 32;
            const int largeurMinimale = 420;
            const int hauteurGraphique = 360;
            int largeurContenu = Math.Max(panelAnalyse.ClientSize.Width - (margeHorizontale * 2), largeurMinimale);
            lblPeriodeAnalyse.Location = new Point(margeHorizontale, lblSousTitreAnalyseArchive.Bottom + 8);
            comboBoxPeriodeAnalyse.Location = new Point(lblPeriodeAnalyse.Right + 8, lblSousTitreAnalyseArchive.Bottom + 4);
            panelGraphiqueAnalyse.Location = new Point(margeHorizontale, comboBoxPeriodeAnalyse.Bottom + 16);
            lblGrilleCalculsAnalyse.Location = new Point(margeHorizontale, panelGraphiqueAnalyse.Bottom + 24);
            panelTableauxAnalyse.Location = new Point(margeHorizontale, lblGrilleCalculsAnalyse.Bottom + 12);

            lblSousTitreAnalyseArchive.Size = new Size(largeurContenu, 38);
            panelGraphiqueAnalyse.Size = new Size(largeurContenu, hauteurGraphique);

            panelTableauxAnalyse.MinimumSize = new Size(largeurContenu, 0);
            int largeurTableaux = Math.Max(largeurContenu, panelTableauxAnalyse.PreferredSize.Width);
            int hauteurTableaux = panelTableauxAnalyse.PreferredSize.Height;
            panelTableauxAnalyse.Size = new Size(largeurTableaux, hauteurTableaux);

            int hauteurContenu = panelTableauxAnalyse.Bottom + margeBas;
            int largeurContenuScrollable = Math.Max(panelGraphiqueAnalyse.Right, panelTableauxAnalyse.Right) + margeHorizontale;
            panelAnalyse.AutoScrollMinSize = new Size(largeurContenuScrollable, hauteurContenu);
        }

        private void panelGraphiqueAnalyse_Paint(object? sender, PaintEventArgs e)
        {
            if (panelGraphiqueAnalyse == null)
            {
                return;
            }

            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle zoneDessin = panelGraphiqueAnalyse.ClientRectangle;

            using Font titreFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            using Font axeFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            using Font valeurFont = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            using SolidBrush textePrincipal = new SolidBrush(Color.FromArgb(44, 62, 102));
            using SolidBrush texteSecondaire = new SolidBrush(Color.FromArgb(91, 104, 128));
            using Pen axePen = new Pen(Color.FromArgb(148, 163, 184), 1.5F);
            using Pen grillePen = new Pen(Color.FromArgb(226, 232, 240), 1F);
            PeriodeAnalyse periodeAnalyse = ObtenirPeriodeAnalyseSelectionnee();

            e.Graphics.DrawString(ObtenirTitreGraphique(periodeAnalyse), titreFont, textePrincipal, new PointF(24, 18));

            IReadOnlyList<(string Code, string Libelle, Color Couleur)> typesDeCalcul = ObtenirTypesDeCalculAnalyse();

            float positionLegendeX = 24;
            foreach ((string _, string libelle, Color couleur) in typesDeCalcul)
            {
                using SolidBrush legendeBrush = new SolidBrush(couleur);
                e.Graphics.FillRectangle(legendeBrush, positionLegendeX, 52, 14, 14);
                e.Graphics.DrawString(libelle, axeFont, texteSecondaire, positionLegendeX + 20, 49);
                positionLegendeX += 110;
            }

            var donneesFiltrees = FiltrerDonneesPourAnalyse(periodeAnalyse).ToList();

            if (donneesFiltrees.Count == 0)
            {
                SizeF tailleTexte = e.Graphics.MeasureString("Aucune archive à afficher.", titreFont);
                PointF positionTexte = new PointF(
                    (zoneDessin.Width - tailleTexte.Width) / 2,
                    (zoneDessin.Height - tailleTexte.Height) / 2);
                e.Graphics.DrawString("Aucune archive à afficher.", titreFont, texteSecondaire, positionTexte);
                return;
            }

            var donneesParDate = ConstruireDonneesGraphique(donneesFiltrees, periodeAnalyse, typesDeCalcul);

            int maximumValeur = Math.Max(1, donneesParDate.SelectMany(item => item.Totaux.Values).DefaultIfEmpty(0).Max());

            RectangleF zoneGraphique = new RectangleF(80, 95, zoneDessin.Width - 120, zoneDessin.Height - 145);
            if (zoneGraphique.Width <= 0 || zoneGraphique.Height <= 0)
            {
                return;
            }

            int nombreGraduations = Math.Min(5, maximumValeur);
            for (int indexGraduation = 0; indexGraduation <= nombreGraduations; indexGraduation++)
            {
                float ratio = nombreGraduations == 0 ? 0 : indexGraduation / (float)nombreGraduations;
                float positionY = zoneGraphique.Bottom - (zoneGraphique.Height * ratio);
                int valeur = (int)Math.Round(maximumValeur * ratio, MidpointRounding.AwayFromZero);

                if (indexGraduation < nombreGraduations)
                {
                    e.Graphics.DrawLine(grillePen, zoneGraphique.Left, positionY, zoneGraphique.Right, positionY);
                }

                Rectangle texteGraduation = Rectangle.Round(new RectangleF(12, positionY - 10, 58, 20));
                TextRenderer.DrawText(e.Graphics, valeur.ToString(), axeFont, texteGraduation, Color.FromArgb(91, 104, 128), TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
            }

            e.Graphics.DrawLine(axePen, zoneGraphique.Left, zoneGraphique.Top, zoneGraphique.Left, zoneGraphique.Bottom);
            e.Graphics.DrawLine(axePen, zoneGraphique.Left, zoneGraphique.Bottom, zoneGraphique.Right, zoneGraphique.Bottom);

            float largeurGroupe = zoneGraphique.Width / donneesParDate.Count;
            float margeInterneGroupe = Math.Min(18F, largeurGroupe * 0.15F);
            float espacementBarres = Math.Min(8F, largeurGroupe * 0.05F);
            float largeurDisponible = Math.Max(largeurGroupe - (margeInterneGroupe * 2), 24F);
            float largeurBarre = Math.Max((largeurDisponible - (espacementBarres * (typesDeCalcul.Count - 1))) / typesDeCalcul.Count, 4F);

            for (int indexDate = 0; indexDate < donneesParDate.Count; indexDate++)
            {
                var donnee = donneesParDate[indexDate];
                float origineGroupeX = zoneGraphique.Left + (indexDate * largeurGroupe) + margeInterneGroupe;

                for (int indexType = 0; indexType < typesDeCalcul.Count; indexType++)
                {
                    (string code, _, Color couleur) = typesDeCalcul[indexType];
                    int valeur = donnee.Totaux[code];
                    float hauteurBarre = maximumValeur == 0 ? 0 : (valeur / (float)maximumValeur) * zoneGraphique.Height;
                    RectangleF barre = new RectangleF(
                        origineGroupeX + (indexType * (largeurBarre + espacementBarres)),
                        zoneGraphique.Bottom - hauteurBarre,
                        largeurBarre,
                        hauteurBarre);

                    using SolidBrush barreBrush = new SolidBrush(couleur);
                    e.Graphics.FillRectangle(barreBrush, barre);

                    if (valeur > 0)
                    {
                        Rectangle texteValeur = Rectangle.Round(new RectangleF(barre.Left - 6, barre.Top - 20, largeurBarre + 12, 16));
                        TextRenderer.DrawText(e.Graphics, valeur.ToString(), valeurFont, texteValeur, Color.FromArgb(44, 62, 102), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    }
                }

                Rectangle etiquetteDate = Rectangle.Round(new RectangleF(
                    zoneGraphique.Left + (indexDate * largeurGroupe),
                    zoneGraphique.Bottom + 8,
                    largeurGroupe,
                    32));
                TextRenderer.DrawText(e.Graphics, donnee.Etiquette, axeFont, etiquetteDate, Color.FromArgb(91, 104, 128), TextFormatFlags.HorizontalCenter | TextFormatFlags.Top | TextFormatFlags.EndEllipsis);
            }
        }

        private void panelGoodPercentage_Paint(object? sender, PaintEventArgs e)
        {
            if (panelGoodPercentage == null)
            {
                return;
            }

            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using Font titreFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            using Font sousTitreFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            using Font carteTitreFont = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            using Font pourcentageFont = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            using Font valeurFont = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            using SolidBrush textePrincipal = new SolidBrush(Color.FromArgb(44, 62, 102));
            using SolidBrush texteSecondaire = new SolidBrush(Color.FromArgb(91, 104, 128));
            using SolidBrush fondCarte = new SolidBrush(Color.FromArgb(248, 250, 252));
            using Pen bordureCarte = new Pen(Color.FromArgb(226, 232, 240), 1F);

            e.Graphics.DrawString("Pourcentage de bonnes réponses", titreFont, textePrincipal, new PointF(24, 18));
            e.Graphics.DrawString("Chaque grillage représente le taux de réussite par type de calcul.", sousTitreFont, texteSecondaire, new PointF(24, 46));

            IReadOnlyList<(string Code, string Libelle, Color Couleur)> typesDeCalcul = ObtenirTypesDeCalculAnalyse();
            List<DateOnlyCalculList> donneesFiltrees = FiltrerDonneesPourAnalyse(ObtenirPeriodeAnalyseSelectionnee()).ToList();

            if (donneesFiltrees.Count == 0)
            {
                SizeF tailleTexte = e.Graphics.MeasureString("Aucune archive à afficher.", titreFont);
                PointF positionTexte = new PointF(
                    (panelGoodPercentage.ClientSize.Width - tailleTexte.Width) / 2,
                    (panelGoodPercentage.ClientSize.Height - tailleTexte.Height) / 2);
                e.Graphics.DrawString("Aucune archive à afficher.", titreFont, texteSecondaire, positionTexte);
                return;
            }

            IReadOnlyList<StatistiqueReussiteAnalyse> statistiques = ConstruireStatistiquesReussite(donneesFiltrees, typesDeCalcul);

            const int marge = 24;
            const int espace = 18;
            const int colonnes = 2;
            int lignes = (int)Math.Ceiling(statistiques.Count / (double)colonnes);
            float largeurCarte = (panelGoodPercentage.ClientSize.Width - (marge * 2) - espace) / (float)colonnes;
            float hauteurDisponible = panelGoodPercentage.ClientSize.Height - 90 - marge - ((lignes - 1) * espace);
            float hauteurCarte = hauteurDisponible / lignes;

            for (int index = 0; index < statistiques.Count; index++)
            {
                StatistiqueReussiteAnalyse statistique = statistiques[index];
                int colonne = index % colonnes;
                int ligne = index / colonnes;
                RectangleF carte = new RectangleF(
                    marge + (colonne * (largeurCarte + espace)),
                    78 + (ligne * (hauteurCarte + espace)),
                    largeurCarte,
                    hauteurCarte);

                e.Graphics.FillRectangle(fondCarte, carte);
                e.Graphics.DrawRectangle(bordureCarte, Rectangle.Round(carte));

                using SolidBrush couleurOperation = new SolidBrush(statistique.Couleur);
                e.Graphics.FillRectangle(couleurOperation, carte.Left + 16, carte.Top + 16, 10, 10);
                e.Graphics.DrawString(statistique.Libelle, carteTitreFont, textePrincipal, new PointF(carte.Left + 34, carte.Top + 11));

                string pourcentageTexte = $"{statistique.Pourcentage:0}%";
                SizeF taillePourcentage = e.Graphics.MeasureString(pourcentageTexte, pourcentageFont);
                e.Graphics.DrawString(pourcentageTexte, pourcentageFont, couleurOperation, new PointF(carte.Right - taillePourcentage.Width - 16, carte.Top + 8));

                string resume = statistique.Total > 0
                    ? $"{statistique.Reussis} / {statistique.Total} bonnes réponses"
                    : "0 / 0 bonne réponse";
                e.Graphics.DrawString(resume, sousTitreFont, texteSecondaire, new PointF(carte.Left + 16, carte.Top + 42));

                RectangleF zoneGrillage = new RectangleF(carte.Left + 16, carte.Top + 68, 120, 120);
                DessinerGrillagePourcentage(e.Graphics, zoneGrillage, statistique.Pourcentage, statistique.Couleur);

                Rectangle zoneValeurs = Rectangle.Round(new RectangleF(carte.Left + 152, carte.Top + 82, carte.Width - 168, 90));
                TextRenderer.DrawText(
                    e.Graphics,
                    statistique.Total > 0 ? $"Réussis : {statistique.Reussis}\r\nTentatives : {statistique.Total}" : "Aucune tentative",
                    valeurFont,
                    zoneValeurs,
                    Color.FromArgb(44, 62, 102),
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void butAnalyse_Click(object? sender, EventArgs e)
        {
            ChargerAnalyseArchives();
            WindowState = FormWindowState.Maximized;
            panelConfigure!.Visible = false;
            panelCalcul!.Visible = false;
            panelAnalyse!.Visible = true;
            panelAnalyse.Invalidate();
            panelGraphiqueAnalyse?.Invalidate();
            RafraichirTableauxAnalyseParType();
        }

        #endregion Initialization

        #region Buttons Click Events

        private void btnArrêt_Click(object? sender, EventArgs e)
        {
            if (sessionTerminee)
            {
                RetournerConfigurationDepuisPanelCalcul();
                return;
            }

            TerminerSessionCalcul();
        }

        private void btnRetourAnalyse_Click(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            panelAnalyse!.Visible = false;
            panelCalcul!.Visible = true;
        }

        private void btnRetourFinSession_Click(object? sender, EventArgs e)
        {
            if (!sessionTerminee)
            {
                return;
            }

            RetournerConfigurationDepuisPanelCalcul();
        }

        private void btnCréerUtilisateur_Click(object? sender, EventArgs e)
        {
            string nouvelUtilisateur = textBoxNouvelUtilisateur?.Text.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nouvelUtilisateur))
            {
                lblError!.Text = "SVP entrer le nom d'un nouvel utilisateur avant de créer le nouvel utilisateur.";
                return;
            }

            if (nouvelUtilisateur.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                lblError!.Text = "Le nom d'utilisateur contient des caractères invalides : " + string.Join(", ", Path.GetInvalidFileNameChars());
                return;
            }

            lblError!.Text = "";

            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Data", nouvelUtilisateur));

            textBoxNouvelUtilisateur!.Text = string.Empty;

            ChargerUtilisateursExistants();
        }

        private void btnOnCommence_Click(object? sender, EventArgs e)
        {
            if (lblError == null || numericUpDownMin == null || numericUpDownMax == null || numericUpDownCalculXMinutes == null)
            {
                return;
            }

            MettreAJourTypeDeCalculSelectionne();

            if (string.IsNullOrWhiteSpace(userName))
            {
                lblError.Text = "SVP sélectionner ou créer un utilisateur avant de commencer.";
                return;
            }

            if (numericUpDownMin.Value > numericUpDownMax.Value)
            {
                lblError.Text = "Le minimum doit être inférieur ou égal au maximum.";
                return;
            }

            lblError.Text = "";
            panelConfigure!.Visible = false;
            panelCalcul!.Visible = true;
            MasquerVisualisationCalcul();

            tempsEcoule = TimeSpan.Zero;
            debutCalcul = DateTime.Now;
            debutSession = DateTime.Now;
            dureeSession = TimeSpan.FromMinutes((double)numericUpDownCalculXMinutes!.Value);
            GoodAnswer = true;
            sessionTerminee = false;
            timerCalcul!.Enabled = true;
            lblTime!.Text = $"{tempsEcoule.Minutes:D2}:{tempsEcoule.Seconds:D2}";
            btnArrêt!.Text = "Arrêt";

            NombreDeCalcul = 0;
            lblNombreDeCalcul!.Text = NombreDeCalcul.ToString();

            textBoxCalcul!.Text = string.Empty;
            textBoxCalcul.ReadOnly = false;
            textBoxCalcul.BackColor = Color.White;
            textBoxCalcul!.Focus();

            LoopCalculation();
        }

        private void radioButtonTypeCalcul_CheckedChanged(object? sender, EventArgs e)
        {
            MettreAJourTypeDeCalculSelectionne();
        }

        private void radioButtonAddition_Click(object? sender, EventArgs e)
        {
            radioButtonSoustraction!.Checked = false;
            radioButtonMultiplication!.Checked = false;
            radioButtonDivision!.Checked = false;
            radioButtonAddition!.Checked = true;
        }

        private void radioButtonSoustraction_Click(object? sender, EventArgs e)
        {
            radioButtonAddition!.Checked = false;
            radioButtonMultiplication!.Checked = false;
            radioButtonDivision!.Checked = false;
            radioButtonSoustraction!.Checked = true;
        }

        private void radioButtonMultiplication_Click(object? sender, EventArgs e)
        {
            radioButtonAddition!.Checked = false;
            radioButtonDivision!.Checked = false;
            radioButtonSoustraction!.Checked = false;
            radioButtonMultiplication!.Checked = true;
        }

        private void radioButtonDivision_Click(object? sender, EventArgs e)
        {
            radioButtonAddition!.Checked = false;
            radioButtonSoustraction!.Checked = false;
            radioButtonMultiplication!.Checked = false;
            radioButtonDivision!.Checked = true;
        }

        #endregion Buttons Click Events

        #region KeyPress Events

        private void textBoxCalcul_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sessionTerminee)
            {
                return;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (SessionCalculeeEstTerminee())
                {
                    TerminerSessionCalcul(tempsEcoule: true);
                    return;
                }

                if (!string.IsNullOrEmpty(textBoxCalcul!.Text))
                {
                    tempsEcoule = ObtenirTempsEcouleCalculCourant();

                    if (!int.TryParse(textBoxCalcul.Text, out int resultatCalcul))
                    {
                        textBoxCalcul.BackColor = Color.Red;
                        AfficherVisualisationCalcul();
                        textBoxCalcul.Text = string.Empty;
                        textBoxCalcul.Focus();
                        return;
                    }

                    if (!TryGetNombresCourants(out int premierNombre, out int dernierNombre))
                    {
                        textBoxCalcul.BackColor = Color.Red;
                        textBoxCalcul.Text = string.Empty;
                        textBoxCalcul.Focus();
                        return;
                    }

                    if (resultatCalcul == reponseCalcul)
                    {
                        textBoxCalcul.BackColor = Color.Lime;
                        MasquerVisualisationCalcul();

                        Calcul calcul = new Calcul
                        {
                            TypeDeCalcul = typeDeCalculSelectionne,
                            PremierNombre = premierNombre,
                            DernierNombre = dernierNombre,
                            Correct = true,
                            DureeEnMillisecondes = tempsEcoule.TotalMilliseconds
                        };

                        calculList.Add(calcul);

                        NombreDeCalcul = NombreDeCalcul + 1;

                        lblNombreDeCalcul!.Text = NombreDeCalcul.ToString();

                        GoodAnswer = true;

                        textBoxCalcul!.Text = string.Empty;
                        textBoxCalcul!.Focus();

                        LoopCalculation();
                    }
                    else
                    {
                        if (!premiereErreurSurCalculCourant)
                        {
                            premiereErreurSurCalculCourant = true;
                        }

                        Calcul calcul = new Calcul
                        {
                            TypeDeCalcul = typeDeCalculSelectionne,
                            PremierNombre = premierNombre,
                            DernierNombre = dernierNombre,
                            Correct = false,
                            DureeEnMillisecondes = tempsEcoule.TotalMilliseconds
                        };

                        calculList.Add(calcul);

                        textBoxCalcul!.BackColor = Color.Red;
                        AfficherVisualisationCalcul();
                        textBoxCalcul!.Text = string.Empty;
                        textBoxCalcul!.Focus();
                    }
                }
                else
                {
                    textBoxCalcul!.BackColor = Color.Red;
                    AfficherVisualisationCalcul();
                    textBoxCalcul!.Text = string.Empty;
                    textBoxCalcul!.Focus();
                }
            }
            else if (e.KeyChar == (char)Keys.Delete)
            {
                textBoxCalcul!.Text = string.Empty;
                textBoxCalcul!.Focus();
            }
        }

        #endregion

        #region Private
        private void ChargerUtilisateursExistants()
        {
            if (!Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Data")))
            {
                if (comboBoxUtilisateurExistant != null)
                {
                    comboBoxUtilisateurExistant.Items.Clear();
                }
            }
            else
            {
                IReadOnlyList<string> utilisateurs = Directory
                    .GetDirectories(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Data"))
                    .Select(Path.GetFileName)
                    .Where(nomUtilisateur => !string.IsNullOrWhiteSpace(nomUtilisateur))
                    .Cast<string>()
                    .OrderBy(nomUtilisateur => nomUtilisateur, StringComparer.OrdinalIgnoreCase)
                    .ToList();

                if (comboBoxUtilisateurExistant != null)
                {
                    comboBoxUtilisateurExistant.BeginUpdate();
                    comboBoxUtilisateurExistant.Items.Clear();
                    comboBoxUtilisateurExistant.Items.AddRange(utilisateurs.Cast<object>().ToArray());
                    comboBoxUtilisateurExistant.EndUpdate();

                    if (comboBoxUtilisateurExistant.Items.Count > 0)
                    {
                        comboBoxUtilisateurExistant.SelectedIndex = 0;
                    }
                }
            }
        }

        private void ChargerAnalyseArchives()
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                dateOnlyCalculList.Clear();
                panelGraphiqueAnalyse?.Invalidate();
                RafraichirTableauxAnalyseParType();
                return;
            }

            string dossierArchives = Path.Combine(AppContext.BaseDirectory, "App", "Data", $"{userName}");

            dateOnlyCalculList.Clear();

            if (!Directory.Exists(dossierArchives))
            {
                panelGraphiqueAnalyse?.Invalidate();
                RafraichirTableauxAnalyseParType();
                return;
            }

            foreach (string cheminFichier in Directory.GetFiles(dossierArchives, "*.json").OrderBy(chemin => chemin, StringComparer.OrdinalIgnoreCase))
            {
                using (FileStream stream = File.OpenRead(cheminFichier))
                {
                    string nomFichier = Path.GetFileNameWithoutExtension(cheminFichier);

                    DateOnly dateOnly = DateOnly.Parse($"{nomFichier.Substring(0, 4)}-{nomFichier.Substring(5, 2)}-{nomFichier.Substring(8, 2)}");

                    List<Calcul>? calculs = JsonSerializer.Deserialize<List<Calcul>>(stream);
                    List<Calcul> calculsDuFichier = calculs ?? new List<Calcul>();
                    DateOnlyCalculList dateOnlyCalcul = new DateOnlyCalculList()
                    {
                        DateOfCalcul = dateOnly,
                        CalculList = calculsDuFichier
                    };

                    DateOnlyCalculList? tempDateOnly = (from c in dateOnlyCalculList
                                                        where c.DateOfCalcul == dateOnly
                                                        select c).FirstOrDefault();

                    if (tempDateOnly != null)
                    {
                        tempDateOnly.CalculList.AddRange(calculsDuFichier);
                    }
                    else
                    {
                        dateOnlyCalculList.Add(dateOnlyCalcul);
                    }
                }

                File.Delete(cheminFichier);
            }

            for (int i = 0; i < dateOnlyCalculList.Count; i++)
            {
                int NumFichier = 0;

                string monthText = string.Empty;

                if (dateOnlyCalculList[i].DateOfCalcul.Month < 10)
                {
                    monthText = $"0{dateOnlyCalculList[i].DateOfCalcul.Month}";
                }
                else
                {
                    monthText = dateOnlyCalculList[i].DateOfCalcul.Month.ToString();
                }

                string dayText = string.Empty;
                if (dateOnlyCalculList[i].DateOfCalcul.Day < 10)
                {
                    dayText = $"0{dateOnlyCalculList[i].DateOfCalcul.Day}";
                }
                else
                {
                    dayText = dateOnlyCalculList[i].DateOfCalcul.Day.ToString();
                }

                string cheminFichier2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Data", userName,
                    $"{dateOnlyCalculList[i].DateOfCalcul.Year}-{monthText}-{dayText}-({NumFichier}).json");

                using (FileStream stream = File.Create(cheminFichier2))
                {
                    JsonSerializer.Serialize(stream, dateOnlyCalculList[i].CalculList ?? Enumerable.Empty<Calcul>(), OptionsSerialisation);
                }
            }

            panelGraphiqueAnalyse?.Invalidate();
            RafraichirTableauxAnalyseParType();
        }

        private void comboBoxUtilisateurExistant_SelectedValueChanged(object? sender, EventArgs e)
        {
            userName = comboBoxUtilisateurExistant!.SelectedItem?.ToString() ?? string.Empty;

            Text = $"Calculomath - {userName}";
            lblNomDeUtilisateur!.Text = userName;
        }

        private void AfficherVisualisationCalcul()
        {
            if (lblVisualisationCalcul == null || lblASMD == null)
            {
                return;
            }

            if (!TryGetNombresCourants(out int premierNombre, out int dernierNombre))
            {
                lblVisualisationCalcul.Text = string.Empty;
                lblVisualisationCalcul.Visible = false;
                return;
            }

            lblVisualisationCalcul.Text = ConstruireRepresentationVisuelle(premierNombre, dernierNombre, reponseCalcul, lblASMD.Text);
            lblVisualisationCalcul.Visible = true;
        }

        private void MasquerVisualisationCalcul()
        {
            if (lblVisualisationCalcul == null)
            {
                return;
            }

            lblVisualisationCalcul.Text = string.Empty;
            lblVisualisationCalcul.Visible = false;
        }

        private static string ConstruireRepresentationVisuelle(int premierNombre, int dernierNombre, int resultat, string operateur)
        {
            return $"{premierNombre} {operateur} {dernierNombre} = {resultat}";
        }

        private PeriodeAnalyse ObtenirPeriodeAnalyseSelectionnee()
        {
            return comboBoxPeriodeAnalyse?.SelectedItem?.ToString() switch
            {
                "Hebdomadaire" => PeriodeAnalyse.Hebdomadaire,
                "Mensuel" => PeriodeAnalyse.Mensuel,
                "Annuel" => PeriodeAnalyse.Annuel,
                _ => PeriodeAnalyse.Journalier
            };
        }

        private static string ObtenirTitreGraphique(PeriodeAnalyse periodeAnalyse)
        {
            return periodeAnalyse switch
            {
                PeriodeAnalyse.Hebdomadaire => "Nombre de calculs par type - 7 derniers jours",
                PeriodeAnalyse.Mensuel => "Nombre de calculs par type - 30 derniers jours",
                PeriodeAnalyse.Annuel => "Nombre de calculs par type - 12 derniers mois",
                _ => "Nombre de calculs par type et par date"
            };
        }

        private static IReadOnlyList<(string Code, string Libelle, Color Couleur)> ObtenirTypesDeCalculAnalyse()
        {
            return new (string Code, string Libelle, Color Couleur)[]
            {
                ("A", "Addition", Color.FromArgb(72, 133, 237)),
                ("S", "Soustraction", Color.FromArgb(229, 72, 77)),
                ("M", "Multiplication", Color.FromArgb(73, 193, 121)),
                ("D", "Division", Color.FromArgb(245, 158, 11))
            };
        }

        private IEnumerable<DateOnlyCalculList> FiltrerDonneesPourAnalyse(PeriodeAnalyse periodeAnalyse)
        {
            DateOnly aujourdHui = DateOnly.FromDateTime(DateTime.Today);

            return periodeAnalyse switch
            {
                PeriodeAnalyse.Hebdomadaire => dateOnlyCalculList.Where(item => item.DateOfCalcul >= aujourdHui.AddDays(-6) && item.DateOfCalcul <= aujourdHui),
                PeriodeAnalyse.Mensuel => dateOnlyCalculList.Where(item => item.DateOfCalcul >= aujourdHui.AddDays(-29) && item.DateOfCalcul <= aujourdHui),
                PeriodeAnalyse.Annuel => dateOnlyCalculList.Where(item => item.DateOfCalcul >= aujourdHui.AddDays(-364) && item.DateOfCalcul <= aujourdHui),
                _ => dateOnlyCalculList
            };
        }

        private static IReadOnlyList<DonneeGraphiqueAnalyse> ConstruireDonneesGraphique(
            IEnumerable<DateOnlyCalculList> donnees,
            PeriodeAnalyse periodeAnalyse,
            IReadOnlyList<(string Code, string Libelle, Color Couleur)> typesDeCalcul)
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.GetCultureInfo("fr-FR");

            return periodeAnalyse switch
            {
                PeriodeAnalyse.Mensuel => donnees
                    .GroupBy(item => ObtenirDebutSemaine(item.DateOfCalcul))
                    .OrderBy(group => group.Key)
                    .Select(group => new DonneeGraphiqueAnalyse
                    {
                        Etiquette = $"{group.Key:dd/MM} - {group.Key.AddDays(6):dd/MM}",
                        Totaux = ConstruireTotauxParType(group, typesDeCalcul)
                    })
                    .ToList(),
                PeriodeAnalyse.Annuel => donnees
                    .GroupBy(item => new DateOnly(item.DateOfCalcul.Year, item.DateOfCalcul.Month, 1))
                    .OrderBy(group => group.Key)
                    .Select(group => new DonneeGraphiqueAnalyse
                    {
                        Etiquette = group.Key.ToString("MMM yyyy", culture),
                        Totaux = ConstruireTotauxParType(group, typesDeCalcul)
                    })
                    .ToList(),
                _ => donnees
                    .GroupBy(item => item.DateOfCalcul)
                    .OrderBy(group => group.Key)
                    .Select(group => new DonneeGraphiqueAnalyse
                    {
                        Etiquette = periodeAnalyse == PeriodeAnalyse.Hebdomadaire
                            ? group.Key.ToString("ddd dd/MM", culture)
                            : group.Key.ToString("dd/MM/yyyy", culture),
                        Totaux = ConstruireTotauxParType(group, typesDeCalcul)
                    })
                    .ToList()
            };
        }

        private static Dictionary<string, int> ConstruireTotauxParType(IEnumerable<DateOnlyCalculList> donnees, IReadOnlyList<(string Code, string Libelle, Color Couleur)> typesDeCalcul)
        {
            return typesDeCalcul.ToDictionary(
                type => type.Code,
                type => donnees.SelectMany(item => item.CalculList).Count(calcul => calcul.TypeDeCalcul == type.Code));
        }

        private static IReadOnlyList<StatistiqueReussiteAnalyse> ConstruireStatistiquesReussite(
            IEnumerable<DateOnlyCalculList> donnees,
            IReadOnlyList<(string Code, string Libelle, Color Couleur)> typesDeCalcul)
        {
            List<Calcul> calculs = donnees.SelectMany(item => item.CalculList).ToList();

            return typesDeCalcul
                .Select(type =>
                {
                    List<Calcul> calculsParType = calculs
                        .Where(calcul => string.Equals(calcul.TypeDeCalcul, type.Code, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    int total = calculsParType.Count;
                    int reussis = calculsParType.Count(calcul => calcul.Correct);

                    return new StatistiqueReussiteAnalyse
                    {
                        Libelle = type.Libelle,
                        Couleur = type.Couleur,
                        Reussis = reussis,
                        Total = total,
                        Pourcentage = total == 0 ? 0 : (reussis * 100D) / total
                    };
                })
                .ToList();
        }

        private void RafraichirTableauxAnalyseParType()
        {
            if (panelTableauxAnalyse == null)
            {
                return;
            }

            panelTableauxAnalyse.SuspendLayout();
            panelTableauxAnalyse.Controls.Clear();
            panelTableauxAnalyse.RowStyles.Clear();
            panelTableauxAnalyse.RowCount = NombreCartesTableauAnalyse;

            for (int indexLigne = 0; indexLigne < panelTableauxAnalyse.RowCount; indexLigne++)
            {
                panelTableauxAnalyse.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            List<DateOnlyCalculList> donneesFiltrees = FiltrerDonneesPourAnalyse(ObtenirPeriodeAnalyseSelectionnee()).ToList();
            IReadOnlyList<(string Code, string Libelle, Color Couleur)> typesDeCalcul = ObtenirTypesDeCalculAnalyse();

            for (int index = 0; index < typesDeCalcul.Count; index++)
            {
                (string code, string libelle, Color couleur) = typesDeCalcul[index];
                Panel carte = CreerCarteTableauAnalyse(code, libelle, couleur, donneesFiltrees);
                carte.Margin = new Padding(0, 0, 0, index == typesDeCalcul.Count - 1 ? 0 : EspacementCarteTableauAnalyse);
                panelTableauxAnalyse.Controls.Add(carte, 0, index);
            }

            panelTableauxAnalyse.ResumeLayout();
            AjusterDispositionPanelAnalyse();
        }

        private Panel CreerCarteTableauAnalyse(string typeDeCalcul, string libelle, Color couleur, IEnumerable<DateOnlyCalculList> donnees)
        {
            Panel carte = new Panel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Padding = new Padding(16)
            };

            Label titre = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = couleur,
                Text = libelle
            };

            Label sousTitre = new Label
            {
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.FromArgb(91, 104, 128),
                Height = 36,
                Padding = new Padding(0, 4, 0, 8),
                Text = typeDeCalcul == "D"
                    ? "Ligne = dividende, colonne = diviseur. Chaque case affiche réussites / tentatives et le pourcentage."
                    : "Ligne = 1er nombre, colonne = 2e nombre. Chaque case affiche réussites / tentatives et le pourcentage."
            };

            Control contenu = CreerTableauAnalyseParType(typeDeCalcul, donnees);
            contenu.Dock = DockStyle.Top;

            carte.Controls.Add(contenu);
            carte.Controls.Add(sousTitre);
            carte.Controls.Add(titre);

            return carte;
        }

        private Control CreerTableauAnalyseParType(string typeDeCalcul, IEnumerable<DateOnlyCalculList> donnees)
        {
            List<Calcul> calculs = donnees
                .SelectMany(item => item.CalculList)
                .Where(calcul => string.Equals(calcul.TypeDeCalcul, typeDeCalcul, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (calculs.Count == 0)
            {
                return new Label
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = Color.FromArgb(91, 104, 128),
                    Height = HauteurMessageTableauVide,
                    Text = "Aucune tentative sur la période sélectionnée.",
                    TextAlign = ContentAlignment.MiddleCenter
                };
            }

            DataGridView tableau = new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.Single,
                ColumnHeadersHeight = 36,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                MultiSelect = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                RowTemplate = { Height = 52 },
                ScrollBars = ScrollBars.None,
                SelectionMode = DataGridViewSelectionMode.CellSelect
            };

            tableau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableau.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableau.EnableHeadersVisualStyles = false;
            tableau.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            tableau.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 102);
            tableau.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableau.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableau.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tableau.DefaultCellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableau.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            tableau.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            tableau.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            tableau.GridColor = Color.FromArgb(226, 232, 240);

            DataGridViewTextBoxColumn premiereColonne = new DataGridViewTextBoxColumn
            {
                Frozen = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                HeaderText = typeDeCalcul == "D" ? "÷" : "#",
                MinimumWidth = 56,
                Name = "PremierNombre",
                ReadOnly = true,
                SortMode = DataGridViewColumnSortMode.NotSortable,
                Width = 64
            };
            tableau.Columns.Add(premiereColonne);

            tableau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            List<int> premiersNombres = calculs.Select(calcul => calcul.PremierNombre).Distinct().OrderBy(nombre => nombre).ToList();
            List<int> derniersNombres = calculs.Select(calcul => calcul.DernierNombre).Distinct().OrderBy(nombre => nombre).ToList();

            foreach (int dernierNombre in derniersNombres)
            {
                tableau.Columns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = dernierNombre.ToString(),
                    MinimumWidth = 72,
                    Name = $"Colonne_{dernierNombre}",
                    ReadOnly = true,
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    Width = 78
                });
            }

            Dictionary<(int PremierNombre, int DernierNombre), StatistiqueCelluleAnalyse> statistiques = calculs
                .GroupBy(calcul => (calcul.PremierNombre, calcul.DernierNombre))
                .ToDictionary(
                    group => group.Key,
                    group => new StatistiqueCelluleAnalyse
                    {
                        Tentatives = group.Count(),
                        Reussites = group.Count(calcul => calcul.Correct)
                    });

            foreach (int premierNombre in premiersNombres)
            {
                int indexLigne = tableau.Rows.Add();
                DataGridViewRow ligne = tableau.Rows[indexLigne];
                ligne.Cells[0].Value = premierNombre.ToString();
                ligne.Cells[0].Style.BackColor = Color.FromArgb(248, 250, 252);
                ligne.Cells[0].Style.ForeColor = Color.FromArgb(44, 62, 102);
                ligne.Cells[0].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);

                for (int indexColonne = 0; indexColonne < derniersNombres.Count; indexColonne++)
                {
                    int dernierNombre = derniersNombres[indexColonne];
                    DataGridViewCell cellule = ligne.Cells[indexColonne + 1];

                    if (!statistiques.TryGetValue((premierNombre, dernierNombre), out StatistiqueCelluleAnalyse? statistique))
                    {
                        cellule.Value = "—";
                        cellule.Style.BackColor = Color.FromArgb(248, 250, 252);
                        cellule.Style.ForeColor = Color.FromArgb(148, 163, 184);
                        cellule.Style.SelectionBackColor = cellule.Style.BackColor;
                        cellule.Style.SelectionForeColor = cellule.Style.ForeColor;
                        continue;
                    }

                    double pourcentage = statistique.Pourcentage;
                    Color couleurCellule = ObtenirCouleurPourcentage(pourcentage);
                    Color couleurTexte = couleurCellule.GetBrightness() < 0.7F ? Color.White : Color.FromArgb(30, 41, 59);

                    cellule.Value = $"{statistique.Reussites}/{statistique.Tentatives}{Environment.NewLine}{pourcentage:0}%";
                    cellule.Style.BackColor = couleurCellule;
                    cellule.Style.ForeColor = couleurTexte;
                    cellule.Style.SelectionBackColor = couleurCellule;
                    cellule.Style.SelectionForeColor = couleurTexte;
                    cellule.ToolTipText = $"{statistique.Reussites} bonne(s) réponse(s) sur {statistique.Tentatives} tentative(s)";
                }
            }

            tableau.ClearSelection();
            tableau.Width = tableau.Columns.Cast<DataGridViewColumn>().Sum(colonne => colonne.Width) + 2;
            tableau.Height = tableau.ColumnHeadersHeight + tableau.Rows.Cast<DataGridViewRow>().Sum(ligne => ligne.Height) + 2;
            return tableau;
        }

        private static Color ObtenirCouleurPourcentage(double pourcentage)
        {
            double ratio = Math.Clamp(pourcentage / 100D, 0D, 1D);
            Color faible = Color.FromArgb(239, 68, 68);
            Color moyen = Color.FromArgb(245, 158, 11);
            Color eleve = Color.FromArgb(34, 197, 94);

            if (ratio <= 0.5D)
            {
                return InterpolerCouleur(faible, moyen, ratio / 0.5D);
            }

            return InterpolerCouleur(moyen, eleve, (ratio - 0.5D) / 0.5D);
        }

        private static Color InterpolerCouleur(Color depart, Color arrivee, double ratio)
        {
            double ratioNormalise = Math.Clamp(ratio, 0D, 1D);

            return Color.FromArgb(
                (int)Math.Round(depart.R + ((arrivee.R - depart.R) * ratioNormalise), MidpointRounding.AwayFromZero),
                (int)Math.Round(depart.G + ((arrivee.G - depart.G) * ratioNormalise), MidpointRounding.AwayFromZero),
                (int)Math.Round(depart.B + ((arrivee.B - depart.B) * ratioNormalise), MidpointRounding.AwayFromZero));
        }

        private void RafraichirGrilleAnalyse()
        {
            if (dataGridViewAnalyseCalculs == null)
            {
                return;
            }

            PeriodeAnalyse periodeAnalyse = ObtenirPeriodeAnalyseSelectionnee();
            List<LigneGrilleCalculAnalyse> lignes = ConstruireLignesGrilleAnalyse(FiltrerDonneesPourAnalyse(periodeAnalyse), periodeAnalyse);

            dataGridViewAnalyseCalculs.DataSource = lignes;
            dataGridViewAnalyseCalculs.ClearSelection();
        }

        private static List<LigneGrilleCalculAnalyse> ConstruireLignesGrilleAnalyse(IEnumerable<DateOnlyCalculList> donnees, PeriodeAnalyse periodeAnalyse)
        {
            return donnees
                .SelectMany(item => item.CalculList.Select(calcul => new
                {
                    Periode = ObtenirClePeriodeAnalyse(item.DateOfCalcul, periodeAnalyse),
                    item.DateOfCalcul,
                    Calcul = calcul
                }))
                .GroupBy(item => new
                {
                    item.Periode.DateTri,
                    item.Periode.Etiquette,
                    item.Calcul.TypeDeCalcul,
                    item.Calcul.PremierNombre,
                    item.Calcul.DernierNombre
                })
                .OrderBy(group => group.Key.DateTri)
                .ThenBy(group => group.Key.TypeDeCalcul)
                .ThenBy(group => group.Key.PremierNombre)
                .ThenBy(group => group.Key.DernierNombre)
                .Select(group =>
                {
                    int tentatives = group.Count();
                    int reussites = group.Count(item => item.Calcul.Correct);
                    return new LigneGrilleCalculAnalyse
                    {
                        Periode = group.Key.Etiquette,
                        TypeDeCalcul = ObtenirLibelleTypeCalcul(group.Key.TypeDeCalcul),
                        PremierNombre = group.Key.PremierNombre,
                        Operateur = ObtenirOperateurCalcul(group.Key.TypeDeCalcul),
                        DernierNombre = group.Key.DernierNombre,
                        Resultat = CalculerResultat(group.Key.TypeDeCalcul, group.Key.PremierNombre, group.Key.DernierNombre),
                        Tentatives = tentatives,
                        Reussites = reussites,
                        Erreurs = tentatives - reussites,
                        TauxReussite = tentatives == 0 ? "0 %" : $"{(reussites * 100D) / tentatives:0}%",
                        DureeMoyenne = FormaterDuree(group.Average(item => item.Calcul.DureeEnMillisecondes))
                    };
                })
                .ToList();
        }

        private static ClePeriodeAnalyse ObtenirClePeriodeAnalyse(DateOnly date, PeriodeAnalyse periodeAnalyse)
        {
            System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.GetCultureInfo("fr-FR");

            return periodeAnalyse switch
            {
                PeriodeAnalyse.Hebdomadaire => new ClePeriodeAnalyse(date, date.ToString("ddd dd/MM", culture)),
                PeriodeAnalyse.Mensuel => new ClePeriodeAnalyse(ObtenirDebutSemaine(date), $"{ObtenirDebutSemaine(date):dd/MM} - {ObtenirDebutSemaine(date).AddDays(6):dd/MM}"),
                PeriodeAnalyse.Annuel => new ClePeriodeAnalyse(new DateOnly(date.Year, date.Month, 1), new DateOnly(date.Year, date.Month, 1).ToString("MMM yyyy", culture)),
                _ => new ClePeriodeAnalyse(date, date.ToString("dd/MM/yyyy", culture))
            };
        }

        private static string ObtenirLibelleTypeCalcul(string typeDeCalcul)
        {
            return typeDeCalcul switch
            {
                "A" => "Addition",
                "S" => "Soustraction",
                "M" => "Multiplication",
                "D" => "Division",
                _ => "Inconnu"
            };
        }

        private static string ObtenirOperateurCalcul(string typeDeCalcul)
        {
            return typeDeCalcul switch
            {
                "A" => "+",
                "S" => "-",
                "M" => "x",
                "D" => "÷",
                _ => "?"
            };
        }

        private static int CalculerResultat(string typeDeCalcul, int premierNombre, int dernierNombre)
        {
            return typeDeCalcul switch
            {
                "A" => premierNombre + dernierNombre,
                "S" => premierNombre - dernierNombre,
                "M" => premierNombre * dernierNombre,
                "D" when dernierNombre != 0 => premierNombre / dernierNombre,
                _ => 0
            };
        }

        private static string FormaterDuree(double dureeEnMillisecondes)
        {
            return TimeSpan.FromMilliseconds(Math.Max(0, dureeEnMillisecondes)).ToString(@"mm\:ss\.fff");
        }

        private static void DessinerGrillagePourcentage(Graphics graphics, RectangleF zoneGrillage, double pourcentage, Color couleur)
        {
            const int colonnes = 10;
            const int lignes = 10;
            const float espacement = 2F;

            float largeurCellule = (zoneGrillage.Width - ((colonnes - 1) * espacement)) / colonnes;
            float hauteurCellule = (zoneGrillage.Height - ((lignes - 1) * espacement)) / lignes;
            int cellulesRemplies = (int)Math.Round(pourcentage, MidpointRounding.AwayFromZero);

            using SolidBrush brushPleine = new SolidBrush(couleur);
            using SolidBrush brushVide = new SolidBrush(Color.FromArgb(226, 232, 240));

            for (int index = 0; index < colonnes * lignes; index++)
            {
                int colonne = index % colonnes;
                int ligne = index / colonnes;
                RectangleF cellule = new RectangleF(
                    zoneGrillage.Left + (colonne * (largeurCellule + espacement)),
                    zoneGrillage.Top + (ligne * (hauteurCellule + espacement)),
                    largeurCellule,
                    hauteurCellule);

                graphics.FillRectangle(index < cellulesRemplies ? brushPleine : brushVide, cellule);
            }
        }

        private static DateOnly ObtenirDebutSemaine(DateOnly date)
        {
            int delta = ((int)date.DayOfWeek + 6) % 7;
            return date.AddDays(-delta);
        }

        private TimeSpan ObtenirTempsEcouleCalculCourant()
        {
            return DateTime.Now - debutCalcul;
        }

        private bool TryGetNombresCourants(out int premierNombre, out int dernierNombre)
        {
            premierNombre = 0;
            dernierNombre = 0;

            return lblPremierNombre != null
                && lblDernierNombre != null
                && int.TryParse(lblPremierNombre.Text, out premierNombre)
                && int.TryParse(lblDernierNombre.Text, out dernierNombre);
        }

        private void MettreAJourTypeDeCalculSelectionne()
        {
            if (radioButtonSoustraction?.Checked == true)
            {
                typeDeCalculSelectionne = "S";
            }
            else if (radioButtonMultiplication?.Checked == true)
            {
                typeDeCalculSelectionne = "M";
            }
            else if (radioButtonDivision?.Checked == true)
            {
                typeDeCalculSelectionne = "D";
            }
            else
            {
                typeDeCalculSelectionne = "A";
            }
        }

        private bool SessionCalculeeEstTerminee()
        {
            return dureeSession > TimeSpan.Zero && DateTime.Now >= debutSession.Add(dureeSession);
        }

        private void TerminerSessionCalcul(bool tempsEcoule = false)
        {
            if (panelCalcul == null || panelConfigure == null || !panelCalcul.Visible || sessionTerminee)
            {
                return;
            }

            timerCalcul!.Stop();
            GoodAnswer = false;
            sessionTerminee = true;
            SauvegarderCalculs();

            if (tempsEcoule)
            {
                AfficherIndicateurTempsEcoule();
                return;
            }

            RetournerConfigurationDepuisPanelCalcul();
        }

        private void AfficherIndicateurTempsEcoule()
        {
            if (panelCalcul == null || textBoxCalcul == null || lblVisualisationCalcul == null || btnArrêt == null || btnRetourFinSession == null || lblPremierNombre == null || lblDernierNombre == null || lblASMD == null)
            {
                return;
            }

            textBoxCalcul.Text = string.Empty;
            textBoxCalcul.ReadOnly = true;
            textBoxCalcul.TabStop = false;
            textBoxCalcul.BackColor = Color.FromArgb(241, 245, 249);
            lblPremierNombre.Text = string.Empty;
            lblDernierNombre.Text = string.Empty;
            lblASMD.Text = "Terminé";
            lblVisualisationCalcul.Text = "Temps écoulé.\r\nLa séance est terminée.\r\nClique sur Retour pour revenir.";
            lblVisualisationCalcul.Visible = true;
            btnArrêt.Visible = true;
            btnRetourFinSession.Visible = true;
            butAnalyse!.Visible = true;
            ActiveControl = null;
        }

        private void RetournerConfigurationDepuisPanelCalcul()
        {
            if (panelCalcul == null || panelConfigure == null || textBoxCalcul == null || btnArrêt == null || btnRetourFinSession == null)
            {
                return;
            }

            panelCalcul.Visible = false;
            panelConfigure.Visible = true;
            textBoxCalcul.Text = string.Empty;
            textBoxCalcul.ReadOnly = false;
            textBoxCalcul.TabStop = true;
            textBoxCalcul.BackColor = Color.White;
            btnArrêt.Text = "Arrêt";
            btnArrêt.Visible = true;
            btnRetourFinSession.Visible = false;
            sessionTerminee = false;
            MasquerVisualisationCalcul();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (sessionTerminee && keyData == Keys.Enter && !BoutonFinSessionEstFocalise())
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool BoutonFinSessionEstFocalise()
        {
            return btnRetourFinSession?.Focused == true
                || butAnalyse?.Focused == true
                || btnArrêt?.Focused == true;
        }

        private void GenererCalculSuivant()
        {
            if (sessionTerminee)
            {
                return;
            }

            switch (typeDeCalculSelectionne)
            {
                case "S":
                    {
                        int premierNombre = random.Next((int)numericUpDownMin!.Value, (int)numericUpDownMax!.Value + 1);
                        int dernierNombre = random.Next((int)numericUpDownMin!.Value, (int)numericUpDownMax!.Value + 1);

                        if (premierNombre < dernierNombre)
                        {
                            int temp = premierNombre;
                            premierNombre = dernierNombre;
                            dernierNombre = temp;
                        }

                        lblPremierNombre!.Text = premierNombre.ToString();
                        lblDernierNombre!.Text = dernierNombre.ToString();
                        reponseCalcul = premierNombre - dernierNombre;
                        lblASMD!.Text = "-";
                        break;
                    }
                case "M":
                    {
                        int premierNombre = random.Next((int)numericUpDownMin!.Value, (int)numericUpDownMax!.Value + 1);
                        int dernierNombre = random.Next((int)numericUpDownMin!.Value, (int)numericUpDownMax!.Value + 1);

                        lblPremierNombre!.Text = premierNombre.ToString();
                        lblDernierNombre!.Text = dernierNombre.ToString();
                        reponseCalcul = premierNombre * dernierNombre;
                        lblASMD!.Text = "x";
                        break;
                    }
                case "D":
                    {
                        int premierNombre = random.Next((int)numericUpDownMin!.Value, (int)numericUpDownMax!.Value + 1);
                        int dernierNombre = 0;

                        while (dernierNombre == 0)
                        {
                            dernierNombre = random.Next((int)numericUpDownMin!.Value, (int)numericUpDownMax!.Value + 1);
                        }

                        premierNombre *= dernierNombre;

                        lblPremierNombre!.Text = premierNombre.ToString();
                        lblDernierNombre!.Text = dernierNombre.ToString();
                        reponseCalcul = premierNombre / dernierNombre;
                        lblASMD!.Text = "÷";
                        break;
                    }
                default:
                    {
                        int premierNombre = random.Next((int)numericUpDownMin!.Value, (int)numericUpDownMax!.Value + 1);
                        int dernierNombre = random.Next((int)numericUpDownMin!.Value, (int)numericUpDownMax!.Value + 1);

                        lblPremierNombre!.Text = premierNombre.ToString();
                        lblDernierNombre!.Text = dernierNombre.ToString();
                        reponseCalcul = premierNombre + dernierNombre;
                        lblASMD!.Text = "+";
                        break;
                    }
            }

            debutCalcul = DateTime.Now;
        }

        private void LoopCalculation()
        {
            if (!panelCalcul!.Visible || !GoodAnswer)
            {
                return;
            }

            if (sessionTerminee)
            {
                return;
            }

            if (SessionCalculeeEstTerminee())
            {
                TerminerSessionCalcul(tempsEcoule: true);
                return;
            }

            premiereErreurSurCalculCourant = false;
            textBoxCalcul!.BackColor = Color.White;
            MasquerVisualisationCalcul();

            GenererCalculSuivant();

            textBoxCalcul.Text = string.Empty;
            textBoxCalcul.Focus();

            GoodAnswer = false;
        }

        private static readonly JsonSerializerOptions OptionsSerialisation = new()
        {
            WriteIndented = true
        };

        private void SauvegarderCalculs()
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return;
            }

            int NumFichier = 0;

            string monthText = string.Empty;

            if (DateTime.Now.Month < 10)
            {
                monthText = $"0{DateTime.Now.Month}";
            }
            else
            {
                monthText = DateTime.Now.Month.ToString();
            }

            string dayText = string.Empty;
            if (DateTime.Now.Day < 10)
            {
                dayText = $"0{DateTime.Now.Day}";
            }
            else
            {
                dayText = DateTime.Now.Day.ToString();
            }

            string cheminFichier = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Data", userName,
                $"{DateTime.Now.Year}-{monthText}-{dayText}-({NumFichier}).json");

            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Data", userName));

            while (File.Exists(cheminFichier))
            {
                NumFichier = NumFichier + 1;

                cheminFichier = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App", "Data", userName,
                $"{DateTime.Now.Year}-{monthText}-{dayText}-({NumFichier}).json");
            }

            using (FileStream stream = File.Create(cheminFichier))
            {
                JsonSerializer.Serialize(stream, calculList ?? Enumerable.Empty<Calcul>(), OptionsSerialisation);
            }

            calculList = new List<Calcul>();
        }

        #endregion Private

        #region Internal Classes and Records

        internal sealed class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
            }
        }

        internal enum PeriodeAnalyse
        {
            Journalier,
            Hebdomadaire,
            Mensuel,
            Annuel
        }

        internal readonly record struct ClePeriodeAnalyse(DateOnly DateTri, string Etiquette);

        internal sealed class DonneeGraphiqueAnalyse
        {
            public string Etiquette { get; set; } = string.Empty;

            public Dictionary<string, int> Totaux { get; set; } = new Dictionary<string, int>();
        }

        internal sealed class LigneGrilleCalculAnalyse
        {
            public string Periode { get; set; } = string.Empty;

            public string TypeDeCalcul { get; set; } = string.Empty;

            public int PremierNombre { get; set; }

            public string Operateur { get; set; } = string.Empty;

            public int DernierNombre { get; set; }

            public int Resultat { get; set; }

            public int Tentatives { get; set; }

            public int Reussites { get; set; }

            public int Erreurs { get; set; }

            public string TauxReussite { get; set; } = string.Empty;

            public string DureeMoyenne { get; set; } = string.Empty;
        }

        internal sealed class StatistiqueReussiteAnalyse
        {
            public string Libelle { get; set; } = string.Empty;

            public Color Couleur { get; set; }

            public int Reussis { get; set; }

            public int Total { get; set; }

            public double Pourcentage { get; set; }
        }

        internal sealed class StatistiqueCelluleAnalyse
        {
            public int Tentatives { get; set; }

            public int Reussites { get; set; }

            public double Pourcentage => Tentatives == 0 ? 0 : (Reussites * 100D) / Tentatives;
        }

        #endregion Internal Classes and Records
    }
}
