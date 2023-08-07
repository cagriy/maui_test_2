namespace multi1;

public partial class MainPage : ContentPage
{
    IDispatcherTimer Timer1;
    public MainPage()
	{
		InitializeComponent();

		
		Timer1 = Dispatcher.CreateTimer();
		Timer1.Interval = TimeSpan.FromMilliseconds(20);
		Timer1.Tick += FlipCard;

        Card1.AnchorX = 1;
		Timer1.Start();

    }

	private void FlipCard(object sender, EventArgs e)
	{
		Card1.RotationY += 0.5;
	}


}


