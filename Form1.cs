namespace ArcheAgeHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPremium1_CheckedChanged(object sender, EventArgs e)
        {
            DailyWP.Text = "В день получается " + WorkingPoints.DailyWorkingPointsCalculate(ButtonPremium2.Checked, ButtonPremium3.Checked) + " очков работы";
        }

        private void ButtonPremium2_CheckedChanged(object sender, EventArgs e)
        {
            DailyWP.Text = "В день получается " + WorkingPoints.DailyWorkingPointsCalculate(ButtonPremium2.Checked, ButtonPremium3.Checked) + " очков работы";
        }

        private void ButtonPremium3_CheckedChanged(object sender, EventArgs e)
        {
            DailyWP.Text = "В день получается " + WorkingPoints.DailyWorkingPointsCalculate(ButtonPremium2.Checked, ButtonPremium3.Checked) + " очков работы";
        }
    }
}