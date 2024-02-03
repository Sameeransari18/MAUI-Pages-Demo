namespace PagesDemo;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblSlider.Text = slider.Value.ToString();
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		if (stepper != null)
		{
			lblSlider.Text = stepper.Value.ToString();
		}
    }
}