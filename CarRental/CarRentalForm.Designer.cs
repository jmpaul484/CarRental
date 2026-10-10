namespace CarRental
{
    partial class CarRentalForm
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
            CoustomerNameTextBox = new TextBox();
            CoustomerNameLabel = new Label();
            AddressLabel = new Label();
            CityLabel = new Label();
            StateLabel = new Label();
            ZipCodeLabel = new Label();
            BeginningODRLabel = new Label();
            EndingORDLabel = new Label();
            NumberOfDaysLabel = new Label();
            MilesKilometersGroupBox = new GroupBox();
            KilometersRadioButton = new RadioButton();
            MilesRadioButton = new RadioButton();
            DiscountsGroupBox = new GroupBox();
            SeniorCitizenDiscountCheckBox = new CheckBox();
            AAAMemberDiscountCheckBox = new CheckBox();
            ClearButton = new Button();
            SummaryButton = new Button();
            CalculateButton = new Button();
            ExitButton = new Button();
            DistanceDrivenInMilesTextBox = new TextBox();
            MileageChargeTextBox = new TextBox();
            DayChargeTextBox = new TextBox();
            YouOweTextBox = new TextBox();
            MinusDiscountTextBox = new TextBox();
            DistanceDrivenInMilesLabel = new Label();
            MileageChargeLabel = new Label();
            DayChargeLabel = new Label();
            MinusDiscountLabel = new Label();
            YouOweLabel = new Label();
            AddressTextBox = new TextBox();
            CityTextBox = new TextBox();
            StateTextBox = new TextBox();
            ZipCodeTextBox = new TextBox();
            BeginningODRTextBox = new TextBox();
            EndingODRTextBox = new TextBox();
            NumberOfDaysTextBox = new TextBox();
            MilesKilometersGroupBox.SuspendLayout();
            DiscountsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CoustomerNameTextBox
            // 
            CoustomerNameTextBox.Location = new Point(276, 9);
            CoustomerNameTextBox.Name = "CoustomerNameTextBox";
            CoustomerNameTextBox.Size = new Size(150, 31);
            CoustomerNameTextBox.TabIndex = 0;
            CoustomerNameTextBox.TextChanged += CoustomerNameTextBox_TextChanged;
            // 
            // CoustomerNameLabel
            // 
            CoustomerNameLabel.AutoSize = true;
            CoustomerNameLabel.Location = new Point(22, 18);
            CoustomerNameLabel.Name = "CoustomerNameLabel";
            CoustomerNameLabel.Size = new Size(152, 25);
            CoustomerNameLabel.TabIndex = 1;
            CoustomerNameLabel.Text = "Coustomer Name";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(22, 55);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(77, 25);
            AddressLabel.TabIndex = 2;
            AddressLabel.Text = "Address";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(22, 92);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(42, 25);
            CityLabel.TabIndex = 3;
            CityLabel.Text = "City";
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(22, 129);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(51, 25);
            StateLabel.TabIndex = 4;
            StateLabel.Text = "State";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new Point(22, 166);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(84, 25);
            ZipCodeLabel.TabIndex = 5;
            ZipCodeLabel.Text = "Zip Code";
            // 
            // BeginningODRLabel
            // 
            BeginningODRLabel.AutoSize = true;
            BeginningODRLabel.Location = new Point(22, 203);
            BeginningODRLabel.Name = "BeginningODRLabel";
            BeginningODRLabel.Size = new Size(247, 25);
            BeginningODRLabel.TabIndex = 6;
            BeginningODRLabel.Text = "Beginning Odometer Reading";
            // 
            // EndingORDLabel
            // 
            EndingORDLabel.AutoSize = true;
            EndingORDLabel.Location = new Point(22, 240);
            EndingORDLabel.Name = "EndingORDLabel";
            EndingORDLabel.Size = new Size(223, 25);
            EndingORDLabel.TabIndex = 7;
            EndingORDLabel.Text = "Ending Odometer Reading";
            // 
            // NumberOfDaysLabel
            // 
            NumberOfDaysLabel.AutoSize = true;
            NumberOfDaysLabel.Location = new Point(22, 277);
            NumberOfDaysLabel.Name = "NumberOfDaysLabel";
            NumberOfDaysLabel.Size = new Size(146, 25);
            NumberOfDaysLabel.TabIndex = 8;
            NumberOfDaysLabel.Text = "Number Of Days";
            // 
            // MilesKilometersGroupBox
            // 
            MilesKilometersGroupBox.Controls.Add(KilometersRadioButton);
            MilesKilometersGroupBox.Controls.Add(MilesRadioButton);
            MilesKilometersGroupBox.Location = new Point(22, 326);
            MilesKilometersGroupBox.Name = "MilesKilometersGroupBox";
            MilesKilometersGroupBox.Size = new Size(493, 136);
            MilesKilometersGroupBox.TabIndex = 9;
            MilesKilometersGroupBox.TabStop = false;
            MilesKilometersGroupBox.Text = "Is Odometer In Miles or Killometers?";
            // 
            // KilometersRadioButton
            // 
            KilometersRadioButton.AutoSize = true;
            KilometersRadioButton.Location = new Point(34, 85);
            KilometersRadioButton.Name = "KilometersRadioButton";
            KilometersRadioButton.Size = new Size(120, 29);
            KilometersRadioButton.TabIndex = 1;
            KilometersRadioButton.TabStop = true;
            KilometersRadioButton.Text = "Kilometers";
            KilometersRadioButton.UseVisualStyleBackColor = true;
            KilometersRadioButton.CheckedChanged += KilometersRadioButton_CheckedChanged;
            // 
            // MilesRadioButton
            // 
            MilesRadioButton.AutoSize = true;
            MilesRadioButton.Location = new Point(34, 38);
            MilesRadioButton.Name = "MilesRadioButton";
            MilesRadioButton.Size = new Size(78, 29);
            MilesRadioButton.TabIndex = 0;
            MilesRadioButton.TabStop = true;
            MilesRadioButton.Text = "Miles";
            MilesRadioButton.UseVisualStyleBackColor = true;
            MilesRadioButton.CheckedChanged += MilesRadioButton_CheckedChanged;
            // 
            // DiscountsGroupBox
            // 
            DiscountsGroupBox.Controls.Add(SeniorCitizenDiscountCheckBox);
            DiscountsGroupBox.Controls.Add(AAAMemberDiscountCheckBox);
            DiscountsGroupBox.Location = new Point(534, 326);
            DiscountsGroupBox.Name = "DiscountsGroupBox";
            DiscountsGroupBox.Size = new Size(327, 136);
            DiscountsGroupBox.TabIndex = 10;
            DiscountsGroupBox.TabStop = false;
            DiscountsGroupBox.Text = "Enter Any Discounts";
            // 
            // SeniorCitizenDiscountCheckBox
            // 
            SeniorCitizenDiscountCheckBox.AutoSize = true;
            SeniorCitizenDiscountCheckBox.Location = new Point(7, 86);
            SeniorCitizenDiscountCheckBox.Name = "SeniorCitizenDiscountCheckBox";
            SeniorCitizenDiscountCheckBox.Size = new Size(220, 29);
            SeniorCitizenDiscountCheckBox.TabIndex = 1;
            SeniorCitizenDiscountCheckBox.Text = "Senior Citizen Discount";
            SeniorCitizenDiscountCheckBox.UseVisualStyleBackColor = true;
            SeniorCitizenDiscountCheckBox.CheckedChanged += SeniorCitizenDiscountCheckBox_CheckedChanged;
            // 
            // AAAMemberDiscountCheckBox
            // 
            AAAMemberDiscountCheckBox.AutoSize = true;
            AAAMemberDiscountCheckBox.Location = new Point(7, 38);
            AAAMemberDiscountCheckBox.Name = "AAAMemberDiscountCheckBox";
            AAAMemberDiscountCheckBox.Size = new Size(221, 29);
            AAAMemberDiscountCheckBox.TabIndex = 0;
            AAAMemberDiscountCheckBox.Text = "AAA Member Discount";
            AAAMemberDiscountCheckBox.UseVisualStyleBackColor = true;
            AAAMemberDiscountCheckBox.CheckedChanged += AAAMemberDiscountCheckBox_CheckedChanged;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(296, 500);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 11;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Location = new Point(434, 500);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(112, 34);
            SummaryButton.TabIndex = 12;
            SummaryButton.Text = "Summary";
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(164, 500);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(112, 34);
            CalculateButton.TabIndex = 14;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(565, 500);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DistanceDrivenInMilesTextBox
            // 
            DistanceDrivenInMilesTextBox.Location = new Point(711, 12);
            DistanceDrivenInMilesTextBox.Name = "DistanceDrivenInMilesTextBox";
            DistanceDrivenInMilesTextBox.Size = new Size(150, 31);
            DistanceDrivenInMilesTextBox.TabIndex = 16;
            // 
            // MileageChargeTextBox
            // 
            MileageChargeTextBox.Location = new Point(711, 55);
            MileageChargeTextBox.Name = "MileageChargeTextBox";
            MileageChargeTextBox.Size = new Size(150, 31);
            MileageChargeTextBox.TabIndex = 17;
            // 
            // DayChargeTextBox
            // 
            DayChargeTextBox.Location = new Point(711, 103);
            DayChargeTextBox.Name = "DayChargeTextBox";
            DayChargeTextBox.Size = new Size(150, 31);
            DayChargeTextBox.TabIndex = 18;
            // 
            // YouOweTextBox
            // 
            YouOweTextBox.Location = new Point(711, 203);
            YouOweTextBox.Name = "YouOweTextBox";
            YouOweTextBox.Size = new Size(150, 31);
            YouOweTextBox.TabIndex = 19;
            // 
            // MinusDiscountTextBox
            // 
            MinusDiscountTextBox.Location = new Point(711, 150);
            MinusDiscountTextBox.Name = "MinusDiscountTextBox";
            MinusDiscountTextBox.Size = new Size(150, 31);
            MinusDiscountTextBox.TabIndex = 20;
            // 
            // DistanceDrivenInMilesLabel
            // 
            DistanceDrivenInMilesLabel.AutoSize = true;
            DistanceDrivenInMilesLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            DistanceDrivenInMilesLabel.Location = new Point(448, 18);
            DistanceDrivenInMilesLabel.Name = "DistanceDrivenInMilesLabel";
            DistanceDrivenInMilesLabel.Size = new Size(230, 25);
            DistanceDrivenInMilesLabel.TabIndex = 21;
            DistanceDrivenInMilesLabel.Text = "Distance Driven In Miles";
            // 
            // MileageChargeLabel
            // 
            MileageChargeLabel.AutoSize = true;
            MileageChargeLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            MileageChargeLabel.Location = new Point(448, 61);
            MileageChargeLabel.Name = "MileageChargeLabel";
            MileageChargeLabel.Size = new Size(151, 25);
            MileageChargeLabel.TabIndex = 22;
            MileageChargeLabel.Text = "Mileage Charge";
            // 
            // DayChargeLabel
            // 
            DayChargeLabel.AutoSize = true;
            DayChargeLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            DayChargeLabel.Location = new Point(448, 109);
            DayChargeLabel.Name = "DayChargeLabel";
            DayChargeLabel.Size = new Size(113, 25);
            DayChargeLabel.TabIndex = 23;
            DayChargeLabel.Text = "Day Charge";
            // 
            // MinusDiscountLabel
            // 
            MinusDiscountLabel.AutoSize = true;
            MinusDiscountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            MinusDiscountLabel.Location = new Point(448, 156);
            MinusDiscountLabel.Name = "MinusDiscountLabel";
            MinusDiscountLabel.Size = new Size(151, 25);
            MinusDiscountLabel.TabIndex = 24;
            MinusDiscountLabel.Text = "Minus Discount";
            // 
            // YouOweLabel
            // 
            YouOweLabel.AutoSize = true;
            YouOweLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            YouOweLabel.Location = new Point(448, 209);
            YouOweLabel.Name = "YouOweLabel";
            YouOweLabel.Size = new Size(90, 25);
            YouOweLabel.TabIndex = 25;
            YouOweLabel.Text = "You Owe";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(276, 49);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(150, 31);
            AddressTextBox.TabIndex = 26;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(276, 86);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(150, 31);
            CityTextBox.TabIndex = 27;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(276, 123);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(150, 31);
            StateTextBox.TabIndex = 28;
            StateTextBox.TextChanged += StateTextBox_TextChanged;
            // 
            // ZipCodeTextBox
            // 
            ZipCodeTextBox.Location = new Point(276, 160);
            ZipCodeTextBox.Name = "ZipCodeTextBox";
            ZipCodeTextBox.Size = new Size(150, 31);
            ZipCodeTextBox.TabIndex = 29;
            ZipCodeTextBox.TextChanged += ZipCodeTextBox_TextChanged;
            // 
            // BeginningODRTextBox
            // 
            BeginningODRTextBox.Location = new Point(276, 197);
            BeginningODRTextBox.Name = "BeginningODRTextBox";
            BeginningODRTextBox.Size = new Size(150, 31);
            BeginningODRTextBox.TabIndex = 30;
            BeginningODRTextBox.TextChanged += BeginningODRTextBox_TextChanged;
            // 
            // EndingODRTextBox
            // 
            EndingODRTextBox.Location = new Point(276, 234);
            EndingODRTextBox.Name = "EndingODRTextBox";
            EndingODRTextBox.Size = new Size(150, 31);
            EndingODRTextBox.TabIndex = 31;
            EndingODRTextBox.TextChanged += EndingODRTextBox_TextChanged;
            // 
            // NumberOfDaysTextBox
            // 
            NumberOfDaysTextBox.Location = new Point(276, 271);
            NumberOfDaysTextBox.Name = "NumberOfDaysTextBox";
            NumberOfDaysTextBox.Size = new Size(150, 31);
            NumberOfDaysTextBox.TabIndex = 32;
            NumberOfDaysTextBox.TextChanged += NumberOfDaysTextBox_TextChanged;
            // 
            // CarRentalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 554);
            Controls.Add(NumberOfDaysTextBox);
            Controls.Add(EndingODRTextBox);
            Controls.Add(BeginningODRTextBox);
            Controls.Add(ZipCodeTextBox);
            Controls.Add(StateTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(YouOweLabel);
            Controls.Add(MinusDiscountLabel);
            Controls.Add(DayChargeLabel);
            Controls.Add(MileageChargeLabel);
            Controls.Add(DistanceDrivenInMilesLabel);
            Controls.Add(MinusDiscountTextBox);
            Controls.Add(YouOweTextBox);
            Controls.Add(DayChargeTextBox);
            Controls.Add(MileageChargeTextBox);
            Controls.Add(DistanceDrivenInMilesTextBox);
            Controls.Add(ExitButton);
            Controls.Add(CalculateButton);
            Controls.Add(SummaryButton);
            Controls.Add(ClearButton);
            Controls.Add(DiscountsGroupBox);
            Controls.Add(MilesKilometersGroupBox);
            Controls.Add(NumberOfDaysLabel);
            Controls.Add(EndingORDLabel);
            Controls.Add(BeginningODRLabel);
            Controls.Add(ZipCodeLabel);
            Controls.Add(StateLabel);
            Controls.Add(CityLabel);
            Controls.Add(AddressLabel);
            Controls.Add(CoustomerNameLabel);
            Controls.Add(CoustomerNameTextBox);
            Name = "CarRentalForm";
            Text = "Car Rental";
            MilesKilometersGroupBox.ResumeLayout(false);
            MilesKilometersGroupBox.PerformLayout();
            DiscountsGroupBox.ResumeLayout(false);
            DiscountsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CoustomerNameTextBox;
        private Label CoustomerNameLabel;
        private Label AddressLabel;
        private Label CityLabel;
        private Label StateLabel;
        private Label ZipCodeLabel;
        private Label BeginningODRLabel;
        private Label EndingORDLabel;
        private Label NumberOfDaysLabel;
        private GroupBox MilesKilometersGroupBox;
        private RadioButton KilometersRadioButton;
        private RadioButton MilesRadioButton;
        private GroupBox DiscountsGroupBox;
        private CheckBox SeniorCitizenDiscountCheckBox;
        private CheckBox AAAMemberDiscountCheckBox;
        private Button ClearButton;
        private Button SummaryButton;
        private Button CalculateButton;
        private Button ExitButton;
        private TextBox DistanceDrivenInMilesTextBox;
        private TextBox MileageChargeTextBox;
        private TextBox DayChargeTextBox;
        private TextBox YouOweTextBox;
        private TextBox MinusDiscountTextBox;
        private Label DistanceDrivenInMilesLabel;
        private Label MileageChargeLabel;
        private Label DayChargeLabel;
        private Label MinusDiscountLabel;
        private Label YouOweLabel;
        private TextBox AddressTextBox;
        private TextBox CityTextBox;
        private TextBox StateTextBox;
        private TextBox ZipCodeTextBox;
        private TextBox BeginningODRTextBox;
        private TextBox EndingODRTextBox;
        private TextBox NumberOfDaysTextBox;
    }
}
