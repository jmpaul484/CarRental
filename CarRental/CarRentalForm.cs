namespace CarRental
{
    public partial class CarRentalForm : Form
    {
        public CarRentalForm()
        {
            InitializeComponent();
            Defaults();
        }
        void Defaults()
        {
            CoustomerNameTextBox.Text = "";
            AddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZipCodeTextBox.Text = "";
            BeginningODRTextBox.Text = "";
            EndingODRTextBox.Text = "";
            NumberOfDaysTextBox.Text = "";
            MilesRadioButton.Checked = false;
            KilometersRadioButton.Checked = false;
            AAAMemberDiscountCheckBox.Checked = false;
            SeniorCitizenDiscountCheckBox.Checked = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Defaults();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void MilesRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KilometersRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AAAMemberDiscountCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SeniorCitizenDiscountCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
