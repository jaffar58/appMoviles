namespace appMovil;

public partial class MainPage : ContentPage
{
	private string color = "#FFFFFF"; // Default color (white)
	

	public MainPage()
	{
		InitializeComponent();
	}


	private void OnCounterClicked(object sender, EventArgs e)
	{
		Random random = new Random();
		int red = random.Next(0, 256);
		int green = random.Next(0, 256);
		int blue = random.Next(0, 256);

		// Generate the hex color
		color = $"#{red:X2}{green:X2}{blue:X2}";

		// Update the text and color square
		ColorBtnText.Text = color; // Update the label text
		ColorSquare.BackgroundColor = Color.FromArgb(color); // Update the square color

		// Change the background color of CounterBtn
		CounterBtn.BackgroundColor = Color.FromArgb(color);

		// Announce the updated text for accessibility
		SemanticScreenReader.Announce(CounterBtn.Text);
		SemanticScreenReader.Announce(ColorBtnText.Text);
	}
}

