namespace Pet_Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int ageInYears;
            float ageInDogYears;

            ageInYears = int.Parse(txtAgeInYears.Text);
            ageInDogYears = ageInYears = 7;
            txtAgeInDogYears.Text = ageInDogYears.ToString();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            int ageInYears;
            float ageInCatYears;

            ageInYears = int.Parse(txtAgeInYears.Text);
            ageInCatYears = ageInYears = 11 + (ageInYears + 4);
            txtAgeInCatYears.Text = ageInCatYears.ToString();
        }

        private void btnTurtle_Click(object sender, EventArgs e)
        {
            int ageInYears;
            float ageInTurtleYears;

            ageInYears = int.Parse(txtAgeInYears.Text);
            ageInTurtleYears = ageInYears / 2;
            txtAgeInTurtleYears.Text = ageInTurtleYears.ToString();
        }
    }
}