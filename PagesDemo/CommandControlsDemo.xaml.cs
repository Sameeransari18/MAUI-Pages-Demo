namespace PagesDemo;

public partial class CommandControlsDemo : ContentPage
{
    public CommandControlsDemo()
    {
        InitializeComponent();
    }

    private void btnTest_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Test", "This is Demo", "Ok", "Cancel");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("RadioButton", $"Changed: {e.Value}", "Ok", "Cancel");
    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Searching", $"Searching: {searchControl.Text}", "Ok");

    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", $"Element Tapped", "Ok");
    }
}