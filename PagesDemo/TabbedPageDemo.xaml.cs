namespace PagesDemo;

public partial class TabbedPageDemo : TabbedPage
{
	public TabbedPageDemo()
	{
		InitializeComponent();
	}

    private void onMainPage2(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}