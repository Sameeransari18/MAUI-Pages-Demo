namespace PagesDemo;

public partial class FlyoutPageDemo : FlyoutPage
{
	public FlyoutPageDemo()
	{
		InitializeComponent();
	}

	private void onMainpPage1(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}