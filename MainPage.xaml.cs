using Microsoft.Maui.Controls;
using System;

namespace appMovil;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		UpdateColor();
	}

	private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
            UpdateColor();
	}

	private void UpdateColor()
	{
        int r = (int)RedSlider.Value;
        int g = (int)GreenSlider.Value;
        int b = (int)BlueSlider.Value;

		var color = Color.FromRgb(r, g, b);
		ColorPreview.Color = color;

        HexLabel.Text = $"#{r:X2}{g:X2}{b:X2}";
	}

	private void OnRandomColorClicked(object sender, EventArgs e)
    {
        Random random = new Random();
		int red = random.Next(0, 256);
		int green = random.Next(0, 256);
		int blue = random.Next(0, 256);

		RedSlider.Value = red;
		GreenSlider.Value = green;
		BlueSlider.Value = blue;

		this.BackgroundColor = Color.FromRgb(red, green, blue);;

        UpdateColor();

    }

	private async void OnCopyColorClicked(object sender, EventArgs e)
    {
        string hexCode = HexLabel.Text;
        await Clipboard.SetTextAsync(hexCode);
        await DisplayAlert("Copiado", $"Color {hexCode} copiado al portapapeles.", "OK");
    }
}
