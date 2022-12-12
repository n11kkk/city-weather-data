﻿using CityStats_front_end.ViewModels;

namespace CityStats_front_end;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<WichitaViewModel>();
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<WeatherMap>();
		builder.Services.AddSingleton<ParisViewModel>();
		builder.Services.AddSingleton<ParisPage>();
		builder.Services.AddSingleton<AppShell>();

		return builder.Build();
	}
}
