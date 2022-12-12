using CityStats_front_end.Themes;

namespace CityStats_front_end;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    public void OnWichitaTheme()
    {
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();

            mergedDictionaries.Add(new WichitaTheme());

        }
    }

    public void OnParisTheme()
    {
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();

            mergedDictionaries.Add(new ParisTheme());

        }
    }



}
