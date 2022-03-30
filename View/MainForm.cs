using Programming.Model;
using Programming.View;
namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((Enum)EnumsListBox.SelectedItem)
                {
                case Enums.Color:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Model.Color));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Manufactures:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValuesTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if(Enum.TryParse(DayWeekTextBox.Text, out Weekday day))
            {
                ResultLabel.Text =  $"{day} = {(int)day}";
            }
            else
            {
                ResultLabel.Text = "No set day a week";
            }
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            switch(SeasonComboBox.SelectedItem)
            {
                case Season.Winter:
                    MessageBox.Show("Брр!Холодно!");
                    break;
                case Season.Spring: BackColor = System.Drawing.Color.LightGreen;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура!Солнце!");
                    break;
                case Season.Autumn: BackColor = System.Drawing.Color.Orange;
                    break;
            }
        }    
    }
}