using CityStats_front_end.ViewModels;

namespace CityStats_front_end;

public partial class ParisPage : ContentPage
{
	public ParisPage(ParisViewModel pvm,AppShell ash)
	{
		InitializeComponent();
        BindingContext = pvm;
        this.pvm = pvm;
        this.ash = ash;
        LoadItemSource();
    }


    ParisViewModel pvm;
    AppShell ash;

    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}

    public async void LoadItemSource()
    {
        await pvm.GetStats();
        ash.OnParisTheme();
        var z = await pvm.GetStats();
        //System.Diagnostics.Debug.WriteLine(z.daily.sunrise);
        //sunriseItemSource.ItemsSource = z.daily.sunrise;

    }
}