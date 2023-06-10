namespace BMICalculator;

public partial class BMICalculatorPage : ContentPage
{
	public BMICalculatorPage()
	{
		InitializeComponent();
	}

    private void TapMale_Tapped(object sender, TappedEventArgs e)
    {
        FrameMale.BorderColor = Color.FromArgb("#0a0e29");
        FrameFemale.BorderColor = Color.FromArgb("#FDFDFD");
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {

        FrameFemale.BorderColor = Color.FromArgb("#0a0e29");
        FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
    }

    private void BtnCalculateBMI_Clicked(object sender, EventArgs e)
    {
        double height = double.Parse(LblHeight.Text);
        double weight = double.Parse(LblWeight.Text);
        double bmi = (weight / height / height) * 10000;

        Navigation.PushAsync(new BMIResultPage(bmi));
        //DisplayAlert("Your BMI is", bmi.ToString(), "cancel");
    }
}