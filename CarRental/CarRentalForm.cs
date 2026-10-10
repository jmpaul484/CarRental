namespace CarRental
{
    public partial class CarRentalForm : Form
    {
        int NumberOfDays = 0;
        int BeginningODR = 0;
        int EndingODR = 0;


        public CarRentalForm()
        {
            InitializeComponent();
            Defaults();
            EvaluateInput();
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

            DistanceDrivenInMilesTextBox.Enabled = false;
            MileageChargeTextBox.Enabled = false;
            DayChargeTextBox.Enabled = false;
            MinusDiscountTextBox.Enabled = false;
            YouOweTextBox.Enabled = false;
        }

        bool EvaluateInput()
        {
            bool valid = true;
            try
            {
                int.Parse(BeginningODRTextBox.Text);
                BeginningODRTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                valid = false;
                BeginningODRTextBox.BackColor = Color.LightYellow;

            }
            try
            {
                int.Parse(EndingODRTextBox.Text);
                EndingODRTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                valid = false;
                EndingODRTextBox.BackColor = Color.LightYellow;

            }
            try
            {
                int.Parse(NumberOfDaysTextBox.Text);
                NumberOfDaysTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                valid = false;
                NumberOfDaysTextBox.BackColor = Color.LightYellow;

            }
            try
            {
                int.Parse(ZipCodeTextBox.Text);
                ZipCodeTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                valid = false;
                ZipCodeTextBox.BackColor = Color.LightYellow;

            }
            if (CoustomerNameTextBox.Text == "")
            {
                valid = false;
                CoustomerNameTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                CoustomerNameTextBox.BackColor = Color.White;
            }
            if (AddressTextBox.Text == "")
            {
                valid = false;
                AddressTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                AddressTextBox.BackColor = Color.White;
            }
            if (CityTextBox.Text == "")
            {
                valid = false;
                CityTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                CityTextBox.BackColor = Color.White;
            }
            if (StateTextBox.Text == "")
            {
                valid = false;
                StateTextBox.BackColor = Color.LightYellow;
            }
            else
            {
                StateTextBox.BackColor = Color.White;
            }
            return valid;
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
        private void CoustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
        }
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
        }
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
        }

        private void StateTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
        }
        private void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
        }
        private void BeginningODRTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
        }

        private void EndingODRTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
        }

        private void NumberOfDaysTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
        }





    }
}
