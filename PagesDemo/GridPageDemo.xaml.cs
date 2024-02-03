namespace PagesDemo;

public partial class GridPageDemo : ContentPage
{
	public GridPageDemo()
	{
		InitializeComponent();
	}

    private void PopOut(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}