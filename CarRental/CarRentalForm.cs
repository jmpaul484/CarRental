namespace CarRental
{
    public partial class CarRentalForm : Form
    {
        int NumberOfDays = 0;
        int BeginningODR = 0;
        int EndingODR = 0;
        static string UserMessage = "";
        int NumberOFCustomers = 0;
        Double TotalMilesDriven = 0;
        Double TotalCharge = 0.0;


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
            DistanceDrivenInMilesTextBox.Text = "";
            MileageChargeTextBox.Text = "";
            DayChargeTextBox.Text = "";
            MinusDiscountTextBox.Text = "";
            YouOweTextBox.Text = "";


            MilesRadioButton.Checked = true;
            KilometersRadioButton.Checked = false;
            AAAMemberDiscountCheckBox.Checked = false;
            SeniorCitizenDiscountCheckBox.Checked = false;

            DistanceDrivenInMilesTextBox.Enabled = false;
            MileageChargeTextBox.Enabled = false;
            DayChargeTextBox.Enabled = false;
            MinusDiscountTextBox.Enabled = false;
            YouOweTextBox.Enabled = false;
            SummaryButton.Enabled = false;
        }

            void Calculations()
            {
                DistanceDrivenInMilesTextBox.Text = (EndingODR - BeginningODR).ToString();


                if (KilometersRadioButton.Checked)

                {
                    DistanceDrivenInMilesTextBox.Text = ((EndingODR - BeginningODR) * 1.60934).ToString();

                }
            // Mileage charge calculation
            int First200MilesCharge = 0;
            double throughg200_500MilesCharge = ((EndingODR - BeginningODR)-200) * 0.12;
            if (throughg200_500MilesCharge <= 0)
            {
                throughg200_500MilesCharge = 0;
            }

            double over500MilesCharge = (EndingODR - BeginningODR - 500) * 0.10;
            if (over500MilesCharge <= 0)
            {
                over500MilesCharge = 0;
            }

            MileageChargeTextBox.Text = (First200MilesCharge + throughg200_500MilesCharge + over500MilesCharge).ToString();


                NumberOFCustomers++;
                TotalMilesDriven = TotalMilesDriven + Double.Parse(DistanceDrivenInMilesTextBox.Text);
            // Day charge calculation
            DayChargeTextBox.Text = (NumberOfDays * 15).ToString();
            // Discount calculation
            double discount = 0;
            if (AAAMemberDiscountCheckBox.Checked)
            {
                discount = .05;
            }
            if (SeniorCitizenDiscountCheckBox.Checked)
            {
                discount += .03;
            }
            if (discount > 0)
            {
                discount = (Double.Parse(MileageChargeTextBox.Text) + Double.Parse(DayChargeTextBox.Text)) * discount;
            }
            MinusDiscountTextBox.Text = discount.ToString();
            // Total charge calculation
                YouOweTextBox.Text = (Double.Parse(MileageChargeTextBox.Text) + Double.Parse(DayChargeTextBox.Text) - Double.Parse(MinusDiscountTextBox.Text)).ToString();
            if (YouOweTextBox.Text == "")

                {
                    YouOweTextBox.Text = 0.ToString();
                }
            TotalCharge = TotalCharge + Double.Parse(YouOweTextBox.Text);
            SummaryButton.Enabled = true;
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
                UserMessage = ("Beginning ODR must be a number less than Ending ODR.");

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
                UserMessage = ("Ending ODR must be a number greater than Beginning ODR.");

            }
            try
            {
                int.Parse(NumberOfDaysTextBox.Text);
                int numberOfDays = int.Parse(NumberOfDaysTextBox.Text);
                if (numberOfDays < 1 || numberOfDays > 45)
                {
                    valid = false;
                    NumberOfDaysTextBox.BackColor = Color.LightYellow;
                }
                else
                    NumberOfDaysTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                valid = false;
                NumberOfDaysTextBox.BackColor = Color.LightYellow;
                UserMessage = ("Number of days must be a number between 1 and 45.");

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
            UserMessage = $"Total Customers: {NumberOFCustomers}\nTotal Miles Driven: {TotalMilesDriven}\nTotal Charge: ${TotalCharge}";
            MessageBox.Show(UserMessage, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Defaults();
            SummaryButton.Enabled = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (EvaluateInput() == true)
            {
                Calculations();
            }
            else
            {
                MessageBox.Show( UserMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserMessage = "";   
            }
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
            try
            {
                BeginningODR = int.Parse(BeginningODRTextBox.Text);
            }
            catch
            {

            }
        }

        private void EndingODRTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
            try
            {
                EndingODR = int.Parse(EndingODRTextBox.Text);
            }
            catch
            {

            }
        }

        private void NumberOfDaysTextBox_TextChanged(object sender, EventArgs e)
        {
            EvaluateInput();
            try
            {
                NumberOfDays = int.Parse(NumberOfDaysTextBox.Text);
            }
            catch
            {

            }

        }





    }
}
