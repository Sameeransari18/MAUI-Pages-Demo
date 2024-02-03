namespace PagesDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	
	private void onFlyoutPage(object sender, EventArgs e)
	{
        Navigation.PushAsync(new FlyoutPageDemo());
    }
	private void onTabbedPage(object sender, EventArgs e)
	{
        Navigation.PushAsync(new TabbedPageDemo());	
    }

    private void onGridPage(object sender, EventArgs e)
    {
		Navigation.PushAsync(new GridPageDemo());
    }
	
	private void onAbsolutePage(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteStackLayoutDemo());
    }
	
	private void onFlexPage(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexStackLayoutDemo());
    }
	
	private void onPresentationControl(object sender, EventArgs e)
    {
		Navigation.PushAsync(new PresentationControlsDemo());
    }
	
	private void onCommandControl(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CommandControlsDemo());
    }
	
	private void onInputControl(object sender, EventArgs e)
    {
		Navigation.PushAsync(new InputControlsDemo());
    }
	
	private void onTextControl(object sender, EventArgs e)
    {
		Navigation.PushAsync(new TextControlsDemo());
    }

	private void onActivityControl(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ActivityControlsDemo());
    }

	private void onCollectionsControl(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CollectionsControlsDemo());
    }
}

