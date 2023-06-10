namespace BMICalculator;

public partial class BMIResultPage : ContentPage
{
	public BMIResultPage(double bmi)
	{
		InitializeComponent();
		LblBMI.Text = $"{bmi:F1}";
		LblBMIMessage.Text = $"You're  {GetResult(bmi)}";
	}

    private string GetResult(double bmi)
    {
        if (bmi >= 25) 
		{
			return "Overweight";
		}
		else if (bmi >= 18.5)
		{
			return "Normal";
		}
		else 
		{ 
			return "Underweight";		
		}
    }
}