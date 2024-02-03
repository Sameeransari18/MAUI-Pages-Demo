namespace PagesDemo;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

    private void onMainPage(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}