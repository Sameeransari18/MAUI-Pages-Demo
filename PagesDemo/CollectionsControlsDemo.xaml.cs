namespace PagesDemo;

public partial class CollectionsControlsDemo : ContentPage
{
	public CollectionsControlsDemo()
	{
		InitializeComponent();
	}

    private void ListViewBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ListViewDemo());
    }

    private void CarouselViewBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CarouselViewDemo());
    }

    private void CollectionViewBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CollectionViewDemo());
    }

    private void PickerViewBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PickerViewDemo());
    }
    
    private void TableViewBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TableViewDemo());
    }
}