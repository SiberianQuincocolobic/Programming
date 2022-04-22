using Programming.Model;
using Programming.View;
using System.Windows.Forms;
using Color = Programming.Model.Color;
using Rectangle = Programming.Model.Rectangle;
namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movie;
        private Movie _currentMovie;
        private Random _random;
        private const int elementObjects = 5;
        

        public MainForm()
        {
            InitializeComponent();
            InitRectangles();
            InitMovie();
            
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
        }
        private void InitRectangles()
        {
            _random = new Random();
            _rectangles = new Rectangle[elementObjects];
            var colors = Enum.GetValues(typeof(Color));
            for (int i = 0; i < elementObjects; i++)
            {
                _currentRectangle = new Rectangle();
                {
                _currentRectangle.Width = _random.Next(101);
                _currentRectangle.Lenght = _random.Next(101);
                _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();

                }
                _rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle{i + 1}"); 
            }
            RectanglesListBox.SelectedIndex = 0;
        }
        private void InitMovie()
        {
            _random = new Random();
            _movie = new Movie[elementObjects];
            var genres = Enum.GetValues(typeof(Genre));
            for( int i = 0; i < elementObjects; i++)
            {
                _currentMovie = new Movie();
                {
                    
                    _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                    _currentMovie.Name = $"Movie {_currentMovie.Genre}";
                    _currentMovie.MinuteDuration = _random.Next(0, 200);
                    _currentMovie.Rating = _random.Next(0, 11);
                    _currentMovie.ReleaseYear = _random.Next(1990, 2020);
                }
                _movie[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie{i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }
        private int FindMaxWidth(Rectangle[] rectangles)
        {
            int indexRectangle = 0;
            double maxWidth = 0;
            for (int i = 0; i < elementObjects; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexRectangle = i;
                }
            }
            return indexRectangle; 
        }
        private int FindMaxRating(Movie[] movies)
        {
            int indexMovie = 0;
            double maxRating = 0;
            for (int i = 0; i < elementObjects; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    indexMovie = i;
                }
            }
            return indexMovie;
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
        private void RectanglesButton_Click(object sender, EventArgs e)
        {
            int FindMaxWidthIndex = FindMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = FindMaxWidthIndex;
        }
        private void MovieButton_Click(object sender, EventArgs e)
        {
            int FindMaxRatingIndex = FindMaxRating(_movie);
            MovieListBox.SelectedIndex = FindMaxRatingIndex;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectagles = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectagles];
            LengthTextBox.Text = _currentRectangle.Lenght.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MovieListBox.SelectedIndex;
            _currentMovie = _movie[selectedIndexMovie];
            NameTextBox.Text = _currentMovie.Name;
            GenreTextBox.Text = _currentMovie.Genre.ToString();
            DurationTextBox.Text = _currentMovie.MinuteDuration.ToString();
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();

        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleLength = LengthTextBox.Text;
                double rectangleLength = double.Parse(currentRectangleLength);
                _currentRectangle.Lenght = rectangleLength;
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleWidth = WidthTextBox.Text;
                double rectangleWidth = double.Parse(currentRectangleWidth);
                _currentRectangle.Width = rectangleWidth;
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangle = ColorTextBox.Text;
            _currentRectangle.Color = colorRectangle;
        }

        
    }
}