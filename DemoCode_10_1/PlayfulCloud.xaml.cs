namespace DemoCode_10_1;

public partial class PlayfulCloud : ContentPage
{
	public PlayfulCloud()
	{
		InitializeComponent();
	}
    private void CartClicked(object sender, EventArgs e)
    {
        try
        {
            int UserEntry = int.Parse(QuantityEntry.Text);
            QuantityEntry.Placeholder = "In Cart";
            QuantityEntry.Text = string.Empty;
        }
        catch (FormatException)
        {
            QuantityEntry.Placeholder = "Input an Integer";
            QuantityEntry.Text = string.Empty;
        }
        catch (ArgumentNullException)
        {
            QuantityEntry.Placeholder = "Input a Quantity";
            QuantityEntry.Text = string.Empty;
        }
    }
}