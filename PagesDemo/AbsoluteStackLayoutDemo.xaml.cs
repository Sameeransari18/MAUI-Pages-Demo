namespace PagesDemo;

public partial class AbsoluteStackLayoutDemo : ContentPage
{
	public AbsoluteStackLayoutDemo()
	{
		InitializeComponent();
	}

	public void PopAsync(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}