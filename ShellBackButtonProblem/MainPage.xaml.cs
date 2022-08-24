using System.Windows.Input;

namespace ShellBackButtonProblem;

public partial class MainPage : ContentPage
{
	int count = 0;

	public ICommand BackButtonCommand { get; }
	public MainPage()
	{
		InitializeComponent();
		this.BackButtonCommand = new Command(() =>
		{

		});
		this.BindingContext = this;
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
}

