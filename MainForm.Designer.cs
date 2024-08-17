namespace TextImagery
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            StartButton = new DataJuggler.Win.Controls.Button();
            FileSelector = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            OutputFolderSelector = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            StatusLabel = new Label();
            CountControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            ListFileSelector = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            BackgroundColorControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            TextColor = new DataJuggler.Win.Controls.LabelTextBoxControl();
            FontNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            FontSizeControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            Graph = new DataJuggler.Win.Controls.ProgressBar();
            HiddenButton = new DataJuggler.Win.Controls.Button();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.Transparent;
            StartButton.ButtonText = "Start";
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.ForeColor = Color.LemonChiffon;
            StartButton.Location = new Point(619, 441);
            StartButton.Margin = new Padding(4);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(114, 40);
            StartButton.TabIndex = 0;
            StartButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            StartButton.Click += StartButton_Click;
            // 
            // FileSelector
            // 
            FileSelector.BackColor = Color.Transparent;
            FileSelector.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            FileSelector.ButtonColor = Color.LemonChiffon;
            FileSelector.ButtonImage = (Image)resources.GetObject("FileSelector.ButtonImage");
            FileSelector.ButtonWidth = 48;
            FileSelector.DarkMode = false;
            FileSelector.DisabledLabelColor = Color.Empty;
            FileSelector.Editable = true;
            FileSelector.EnabledLabelColor = Color.Empty;
            FileSelector.Filter = null;
            FileSelector.Font = new Font("Verdana", 12F);
            FileSelector.HideBrowseButton = false;
            FileSelector.LabelBottomMargin = 0;
            FileSelector.LabelColor = Color.LemonChiffon;
            FileSelector.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            FileSelector.LabelText = "Source Image:";
            FileSelector.LabelTopMargin = 0;
            FileSelector.LabelWidth = 140;
            FileSelector.Location = new Point(25, 28);
            FileSelector.Name = "FileSelector";
            FileSelector.OnTextChangedListener = null;
            FileSelector.OpenCallback = null;
            FileSelector.ScrollBars = ScrollBars.None;
            FileSelector.SelectedPath = null;
            FileSelector.Size = new Size(708, 32);
            FileSelector.StartPath = null;
            FileSelector.TabIndex = 0;
            FileSelector.TextBoxBottomMargin = 0;
            FileSelector.TextBoxDisabledColor = Color.Empty;
            FileSelector.TextBoxEditableColor = Color.Empty;
            FileSelector.TextBoxFont = new Font("Verdana", 12F);
            FileSelector.TextBoxTopMargin = 0;
            FileSelector.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // OutputFolderSelector
            // 
            OutputFolderSelector.BackColor = Color.Transparent;
            OutputFolderSelector.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            OutputFolderSelector.ButtonColor = Color.LemonChiffon;
            OutputFolderSelector.ButtonImage = (Image)resources.GetObject("OutputFolderSelector.ButtonImage");
            OutputFolderSelector.ButtonWidth = 48;
            OutputFolderSelector.DarkMode = false;
            OutputFolderSelector.DisabledLabelColor = Color.Empty;
            OutputFolderSelector.Editable = true;
            OutputFolderSelector.EnabledLabelColor = Color.Empty;
            OutputFolderSelector.Filter = null;
            OutputFolderSelector.Font = new Font("Verdana", 12F);
            OutputFolderSelector.HideBrowseButton = false;
            OutputFolderSelector.LabelBottomMargin = 0;
            OutputFolderSelector.LabelColor = Color.LemonChiffon;
            OutputFolderSelector.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            OutputFolderSelector.LabelText = "Output Folder:";
            OutputFolderSelector.LabelTopMargin = 0;
            OutputFolderSelector.LabelWidth = 140;
            OutputFolderSelector.Location = new Point(25, 134);
            OutputFolderSelector.Name = "OutputFolderSelector";
            OutputFolderSelector.OnTextChangedListener = null;
            OutputFolderSelector.OpenCallback = null;
            OutputFolderSelector.ScrollBars = ScrollBars.None;
            OutputFolderSelector.SelectedPath = null;
            OutputFolderSelector.Size = new Size(708, 32);
            OutputFolderSelector.StartPath = null;
            OutputFolderSelector.TabIndex = 2;
            OutputFolderSelector.TextBoxBottomMargin = 0;
            OutputFolderSelector.TextBoxDisabledColor = Color.Empty;
            OutputFolderSelector.TextBoxEditableColor = Color.Empty;
            OutputFolderSelector.TextBoxFont = new Font("Verdana", 12F);
            OutputFolderSelector.TextBoxTopMargin = 0;
            OutputFolderSelector.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StatusLabel
            // 
            StatusLabel.ForeColor = Color.LemonChiffon;
            StatusLabel.Location = new Point(25, 495);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(662, 23);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status:";
            // 
            // CountControl
            // 
            CountControl.BackColor = Color.Transparent;
            CountControl.BottomMargin = 0;
            CountControl.Editable = true;
            CountControl.Encrypted = false;
            CountControl.Font = new Font("Verdana", 12F, FontStyle.Bold);
            CountControl.Inititialized = true;
            CountControl.LabelBottomMargin = 0;
            CountControl.LabelColor = Color.LemonChiffon;
            CountControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            CountControl.LabelText = "Count:";
            CountControl.LabelTopMargin = 0;
            CountControl.LabelWidth = 140;
            CountControl.Location = new Point(25, 399);
            CountControl.MultiLine = false;
            CountControl.Name = "CountControl";
            CountControl.OnTextChangedListener = null;
            CountControl.PasswordMode = false;
            CountControl.ScrollBars = ScrollBars.None;
            CountControl.Size = new Size(238, 32);
            CountControl.TabIndex = 7;
            CountControl.TextBoxBottomMargin = 0;
            CountControl.TextBoxDisabledColor = Color.LightGray;
            CountControl.TextBoxEditableColor = Color.White;
            CountControl.TextBoxFont = new Font("Verdana", 12F);
            CountControl.TextBoxTopMargin = 0;
            CountControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ListFileSelector
            // 
            ListFileSelector.BackColor = Color.Transparent;
            ListFileSelector.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            ListFileSelector.ButtonColor = Color.LemonChiffon;
            ListFileSelector.ButtonImage = (Image)resources.GetObject("ListFileSelector.ButtonImage");
            ListFileSelector.ButtonWidth = 48;
            ListFileSelector.DarkMode = false;
            ListFileSelector.DisabledLabelColor = Color.Empty;
            ListFileSelector.Editable = true;
            ListFileSelector.EnabledLabelColor = Color.Empty;
            ListFileSelector.Filter = null;
            ListFileSelector.Font = new Font("Verdana", 12F);
            ListFileSelector.HideBrowseButton = false;
            ListFileSelector.LabelBottomMargin = 0;
            ListFileSelector.LabelColor = Color.LemonChiffon;
            ListFileSelector.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            ListFileSelector.LabelText = "List File:";
            ListFileSelector.LabelTopMargin = 0;
            ListFileSelector.LabelWidth = 140;
            ListFileSelector.Location = new Point(25, 81);
            ListFileSelector.Name = "ListFileSelector";
            ListFileSelector.OnTextChangedListener = null;
            ListFileSelector.OpenCallback = null;
            ListFileSelector.ScrollBars = ScrollBars.None;
            ListFileSelector.SelectedPath = null;
            ListFileSelector.Size = new Size(708, 32);
            ListFileSelector.StartPath = null;
            ListFileSelector.TabIndex = 1;
            ListFileSelector.TextBoxBottomMargin = 0;
            ListFileSelector.TextBoxDisabledColor = Color.Empty;
            ListFileSelector.TextBoxEditableColor = Color.Empty;
            ListFileSelector.TextBoxFont = new Font("Verdana", 12F);
            ListFileSelector.TextBoxTopMargin = 0;
            ListFileSelector.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // BackgroundColorControl
            // 
            BackgroundColorControl.BackColor = Color.Transparent;
            BackgroundColorControl.BottomMargin = 0;
            BackgroundColorControl.Editable = true;
            BackgroundColorControl.Encrypted = false;
            BackgroundColorControl.Font = new Font("Verdana", 12F, FontStyle.Bold);
            BackgroundColorControl.Inititialized = true;
            BackgroundColorControl.LabelBottomMargin = 0;
            BackgroundColorControl.LabelColor = Color.LemonChiffon;
            BackgroundColorControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            BackgroundColorControl.LabelText = "Back Color:";
            BackgroundColorControl.LabelTopMargin = 0;
            BackgroundColorControl.LabelWidth = 140;
            BackgroundColorControl.Location = new Point(25, 187);
            BackgroundColorControl.MultiLine = false;
            BackgroundColorControl.Name = "BackgroundColorControl";
            BackgroundColorControl.OnTextChangedListener = null;
            BackgroundColorControl.PasswordMode = false;
            BackgroundColorControl.ScrollBars = ScrollBars.None;
            BackgroundColorControl.Size = new Size(343, 32);
            BackgroundColorControl.TabIndex = 3;
            BackgroundColorControl.TextBoxBottomMargin = 0;
            BackgroundColorControl.TextBoxDisabledColor = Color.LightGray;
            BackgroundColorControl.TextBoxEditableColor = Color.White;
            BackgroundColorControl.TextBoxFont = new Font("Verdana", 12F);
            BackgroundColorControl.TextBoxTopMargin = 0;
            BackgroundColorControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // TextColor
            // 
            TextColor.BackColor = Color.Transparent;
            TextColor.BottomMargin = 0;
            TextColor.Editable = true;
            TextColor.Encrypted = false;
            TextColor.Font = new Font("Verdana", 12F, FontStyle.Bold);
            TextColor.Inititialized = true;
            TextColor.LabelBottomMargin = 0;
            TextColor.LabelColor = Color.LemonChiffon;
            TextColor.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            TextColor.LabelText = "Text Color:";
            TextColor.LabelTopMargin = 0;
            TextColor.LabelWidth = 140;
            TextColor.Location = new Point(25, 240);
            TextColor.MultiLine = false;
            TextColor.Name = "TextColor";
            TextColor.OnTextChangedListener = null;
            TextColor.PasswordMode = false;
            TextColor.ScrollBars = ScrollBars.None;
            TextColor.Size = new Size(343, 32);
            TextColor.TabIndex = 4;
            TextColor.TextBoxBottomMargin = 0;
            TextColor.TextBoxDisabledColor = Color.LightGray;
            TextColor.TextBoxEditableColor = Color.White;
            TextColor.TextBoxFont = new Font("Verdana", 12F);
            TextColor.TextBoxTopMargin = 0;
            TextColor.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // FontNameControl
            // 
            FontNameControl.BackColor = Color.Transparent;
            FontNameControl.BottomMargin = 0;
            FontNameControl.Editable = true;
            FontNameControl.Encrypted = false;
            FontNameControl.Font = new Font("Verdana", 12F, FontStyle.Bold);
            FontNameControl.Inititialized = true;
            FontNameControl.LabelBottomMargin = 0;
            FontNameControl.LabelColor = Color.LemonChiffon;
            FontNameControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            FontNameControl.LabelText = "Font Name:";
            FontNameControl.LabelTopMargin = 0;
            FontNameControl.LabelWidth = 140;
            FontNameControl.Location = new Point(25, 293);
            FontNameControl.MultiLine = false;
            FontNameControl.Name = "FontNameControl";
            FontNameControl.OnTextChangedListener = null;
            FontNameControl.PasswordMode = false;
            FontNameControl.ScrollBars = ScrollBars.None;
            FontNameControl.Size = new Size(343, 32);
            FontNameControl.TabIndex = 5;
            FontNameControl.TextBoxBottomMargin = 0;
            FontNameControl.TextBoxDisabledColor = Color.LightGray;
            FontNameControl.TextBoxEditableColor = Color.White;
            FontNameControl.TextBoxFont = new Font("Verdana", 12F);
            FontNameControl.TextBoxTopMargin = 0;
            FontNameControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // FontSizeControl
            // 
            FontSizeControl.BackColor = Color.Transparent;
            FontSizeControl.BottomMargin = 0;
            FontSizeControl.Editable = true;
            FontSizeControl.Encrypted = false;
            FontSizeControl.Font = new Font("Verdana", 12F, FontStyle.Bold);
            FontSizeControl.Inititialized = true;
            FontSizeControl.LabelBottomMargin = 0;
            FontSizeControl.LabelColor = Color.LemonChiffon;
            FontSizeControl.LabelFont = new Font("Verdana", 12F, FontStyle.Bold);
            FontSizeControl.LabelText = "Font Size:";
            FontSizeControl.LabelTopMargin = 0;
            FontSizeControl.LabelWidth = 140;
            FontSizeControl.Location = new Point(25, 346);
            FontSizeControl.MultiLine = false;
            FontSizeControl.Name = "FontSizeControl";
            FontSizeControl.OnTextChangedListener = null;
            FontSizeControl.PasswordMode = false;
            FontSizeControl.ScrollBars = ScrollBars.None;
            FontSizeControl.Size = new Size(238, 32);
            FontSizeControl.TabIndex = 6;
            FontSizeControl.TextBoxBottomMargin = 0;
            FontSizeControl.TextBoxDisabledColor = Color.LightGray;
            FontSizeControl.TextBoxEditableColor = Color.White;
            FontSizeControl.TextBoxFont = new Font("Verdana", 12F);
            FontSizeControl.TextBoxTopMargin = 0;
            FontSizeControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // Graph
            // 
            Graph.BackColor = Color.DimGray;
            Graph.BackgroundColor = Color.DimGray;
            Graph.BorderStyle = BorderStyle.FixedSingle;
            Graph.ForeColor = Color.DodgerBlue;
            Graph.Location = new Point(27, 525);
            Graph.Maximum = 100;
            Graph.Name = "Graph";
            Graph.SetOverflowToMax = true;
            Graph.Size = new Size(705, 22);
            Graph.TabIndex = 0;
            Graph.Value = 0;
            // 
            // HiddenButton
            // 
            HiddenButton.BackColor = Color.Transparent;
            HiddenButton.ButtonText = "Hidden";
            HiddenButton.FlatStyle = FlatStyle.Flat;
            HiddenButton.ForeColor = Color.LemonChiffon;
            HiddenButton.Location = new Point(-497, 441);
            HiddenButton.Margin = new Padding(4);
            HiddenButton.Name = "HiddenButton";
            HiddenButton.Size = new Size(114, 40);
            HiddenButton.TabIndex = 8;
            HiddenButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(760, 570);
            Controls.Add(HiddenButton);
            Controls.Add(Graph);
            Controls.Add(FontSizeControl);
            Controls.Add(FontNameControl);
            Controls.Add(TextColor);
            Controls.Add(BackgroundColorControl);
            Controls.Add(ListFileSelector);
            Controls.Add(CountControl);
            Controls.Add(StatusLabel);
            Controls.Add(OutputFolderSelector);
            Controls.Add(FileSelector);
            Controls.Add(StartButton);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private DataJuggler.Win.Controls.Button StartButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl FileSelector;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputFolderSelector;
        private Label StatusLabel;
        private DataJuggler.Win.Controls.LabelTextBoxControl CountControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl ListFileSelector;
        private DataJuggler.Win.Controls.LabelTextBoxControl BackgroundColorControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl TextColor;
        private DataJuggler.Win.Controls.LabelTextBoxControl FontNameControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl FontSizeControl;
        private DataJuggler.Win.Controls.ProgressBar Graph;
        private DataJuggler.Win.Controls.Button HiddenButton;
    }
}
