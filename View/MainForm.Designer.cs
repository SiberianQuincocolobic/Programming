namespace Programming.View
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
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.IntValuesTextBox = new System.Windows.Forms.TextBox();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.DayWeekTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DayWeekLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.TypeValueLabel = new System.Windows.Forms.Label();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MovieButton = new System.Windows.Forms.Button();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesButton = new System.Windows.Forms.Button();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnumsTabControl.Controls.Add(this.RectanglesTabPage);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(793, 528);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.EnumGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(785, 500);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumGroupBox.Controls.Add(this.ValuesLabel);
            this.EnumGroupBox.Controls.Add(this.IntValuesTextBox);
            this.EnumGroupBox.Controls.Add(this.EnumLabel);
            this.EnumGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumGroupBox.Location = new System.Drawing.Point(9, 6);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(768, 312);
            this.EnumGroupBox.TabIndex = 6;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(397, 22);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 6;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValuesLabel
            // 
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Location = new System.Drawing.Point(213, 22);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(81, 15);
            this.ValuesLabel.TabIndex = 5;
            this.ValuesLabel.Text = "Choose value:";
            // 
            // IntValuesTextBox
            // 
            this.IntValuesTextBox.Location = new System.Drawing.Point(397, 40);
            this.IntValuesTextBox.Name = "IntValuesTextBox";
            this.IntValuesTextBox.Size = new System.Drawing.Size(115, 23);
            this.IntValuesTextBox.TabIndex = 3;
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Location = new System.Drawing.Point(15, 22);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(121, 15);
            this.EnumLabel.TabIndex = 4;
            this.EnumLabel.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Location = new System.Drawing.Point(16, 40);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(166, 244);
            this.EnumsListBox.TabIndex = 1;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(213, 40);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(164, 244);
            this.ValuesListBox.TabIndex = 2;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.DayWeekTextBox);
            this.WeekdayGroupBox.Controls.Add(this.ResultLabel);
            this.WeekdayGroupBox.Controls.Add(this.DayWeekLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayGroupBox.Controls.Add(this.TypeValueLabel);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(9, 324);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(395, 157);
            this.WeekdayGroupBox.TabIndex = 7;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // DayWeekTextBox
            // 
            this.DayWeekTextBox.Location = new System.Drawing.Point(15, 51);
            this.DayWeekTextBox.Name = "DayWeekTextBox";
            this.DayWeekTextBox.Size = new System.Drawing.Size(216, 23);
            this.DayWeekTextBox.TabIndex = 8;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(166, 88);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(49, 15);
            this.ResultLabel.TabIndex = 9;
            this.ResultLabel.Text = "(null=0)";
            // 
            // DayWeekLabel
            // 
            this.DayWeekLabel.AutoSize = true;
            this.DayWeekLabel.Location = new System.Drawing.Point(15, 88);
            this.DayWeekLabel.Name = "DayWeekLabel";
            this.DayWeekLabel.Size = new System.Drawing.Size(145, 15);
            this.DayWeekLabel.TabIndex = 8;
            this.DayWeekLabel.Text = "This is the day of the week";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(237, 50);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 7;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // TypeValueLabel
            // 
            this.TypeValueLabel.AutoSize = true;
            this.TypeValueLabel.Location = new System.Drawing.Point(15, 32);
            this.TypeValueLabel.Name = "TypeValueLabel";
            this.TypeValueLabel.Size = new System.Drawing.Size(125, 15);
            this.TypeValueLabel.TabIndex = 6;
            this.TypeValueLabel.Text = "Type value for parsing:";
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.GoButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Location = new System.Drawing.Point(410, 324);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(367, 157);
            this.SeasonGroupBox.TabIndex = 10;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(207, 51);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(13, 32);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(13, 51);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(188, 23);
            this.SeasonComboBox.TabIndex = 5;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.MovieGroupBox);
            this.RectanglesTabPage.Controls.Add(this.groupBox1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 24);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(785, 500);
            this.RectanglesTabPage.TabIndex = 1;
            this.RectanglesTabPage.Text = "Classes";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.RatingTextBox);
            this.MovieGroupBox.Controls.Add(this.ReleaseYearTextBox);
            this.MovieGroupBox.Controls.Add(this.DurationTextBox);
            this.MovieGroupBox.Controls.Add(this.GenreTextBox);
            this.MovieGroupBox.Controls.Add(this.NameTextBox);
            this.MovieGroupBox.Controls.Add(this.MovieButton);
            this.MovieGroupBox.Controls.Add(this.RatingLabel);
            this.MovieGroupBox.Controls.Add(this.ReleaseYearLabel);
            this.MovieGroupBox.Controls.Add(this.DurationLabel);
            this.MovieGroupBox.Controls.Add(this.GenreLabel);
            this.MovieGroupBox.Controls.Add(this.NameLabel);
            this.MovieGroupBox.Controls.Add(this.MovieListBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(337, 6);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(365, 486);
            this.MovieGroupBox.TabIndex = 5;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movie";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(180, 202);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 23);
            this.RatingTextBox.TabIndex = 11;
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(180, 158);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(100, 23);
            this.ReleaseYearTextBox.TabIndex = 10;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(180, 114);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(100, 23);
            this.DurationTextBox.TabIndex = 9;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(180, 71);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 23);
            this.GenreTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(180, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 23);
            this.NameTextBox.TabIndex = 7;
            // 
            // MovieButton
            // 
            this.MovieButton.Location = new System.Drawing.Point(205, 231);
            this.MovieButton.Name = "MovieButton";
            this.MovieButton.Size = new System.Drawing.Size(75, 23);
            this.MovieButton.TabIndex = 6;
            this.MovieButton.Text = "Find";
            this.MovieButton.UseVisualStyleBackColor = true;
            this.MovieButton.Click += new System.EventHandler(this.MovieButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(180, 184);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(44, 15);
            this.RatingLabel.TabIndex = 5;
            this.RatingLabel.Text = "Rating:";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(180, 140);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(74, 15);
            this.ReleaseYearLabel.TabIndex = 4;
            this.ReleaseYearLabel.Text = "Release year:";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(180, 96);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(56, 15);
            this.DurationLabel.TabIndex = 3;
            this.DurationLabel.Text = "Duration:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(180, 53);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(41, 15);
            this.GenreLabel.TabIndex = 2;
            this.GenreLabel.Text = "Genre:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(180, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 15;
            this.MovieListBox.Location = new System.Drawing.Point(6, 16);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(152, 229);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorLabel);
            this.groupBox1.Controls.Add(this.WidthLabel);
            this.groupBox1.Controls.Add(this.LengthLabel);
            this.groupBox1.Controls.Add(this.RectanglesButton);
            this.groupBox1.Controls.Add(this.WidthTextBox);
            this.groupBox1.Controls.Add(this.ColorTextBox);
            this.groupBox1.Controls.Add(this.LengthTextBox);
            this.groupBox1.Controls.Add(this.RectanglesListBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rectangles";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(157, 145);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(39, 15);
            this.ColorLabel.TabIndex = 4;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(157, 84);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(157, 26);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(47, 15);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length:";
            // 
            // RectanglesButton
            // 
            this.RectanglesButton.Location = new System.Drawing.Point(157, 225);
            this.RectanglesButton.Name = "RectanglesButton";
            this.RectanglesButton.Size = new System.Drawing.Size(75, 23);
            this.RectanglesButton.TabIndex = 1;
            this.RectanglesButton.Text = "Find";
            this.RectanglesButton.UseVisualStyleBackColor = true;
            this.RectanglesButton.Click += new System.EventHandler(this.RectanglesButton_Click);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(157, 102);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 23);
            this.WidthTextBox.TabIndex = 1;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(157, 163);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 23);
            this.ColorTextBox.TabIndex = 2;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(157, 44);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(116, 23);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 15;
            this.RectanglesListBox.Location = new System.Drawing.Point(3, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(148, 229);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 528);
            this.Controls.Add(this.EnumsTabControl);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage EnumsTabPage;
        private TextBox IntValuesTextBox;
        private ListBox EnumsListBox;
        private ListBox ValuesListBox;
        private GroupBox EnumGroupBox;
        private Label IntValueLabel;
        private Label ValuesLabel;
        private Label EnumLabel;
        private GroupBox WeekdayGroupBox;
        private Button ParseButton;
        private Label TypeValueLabel;
        private ComboBox SeasonComboBox;
        private TextBox DayWeekTextBox;
        private Label ResultLabel;
        private Label DayWeekLabel;
        private GroupBox SeasonGroupBox;
        private Button GoButton;
        private Label SeasonLabel;
        private TabPage RectanglesTabPage;
        private GroupBox groupBox1;
        private Button RectanglesButton;
        private TextBox WidthTextBox;
        private TextBox ColorTextBox;
        private TextBox LengthTextBox;
        private ListBox RectanglesListBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LengthLabel;
        private GroupBox MovieGroupBox;
        private ListBox MovieListBox;
        private TextBox RatingTextBox;
        private TextBox ReleaseYearTextBox;
        private TextBox DurationTextBox;
        private TextBox GenreTextBox;
        private TextBox NameTextBox;
        private Button MovieButton;
        private Label RatingLabel;
        private Label ReleaseYearLabel;
        private Label DurationLabel;
        private Label GenreLabel;
        private Label NameLabel;
    }
}