using System.Diagnostics;

namespace PagesDemo;

public partial class TextControlsDemo : ContentPage
{
	public TextControlsDemo()
	{
		InitializeComponent();
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine(phoneNumber.Text);
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(phoneNumber.Text);

    }
}