﻿using CommunityToolkit.Maui;
using MicrobApp.Services;
using MicrobApp.Views;

namespace MicrobApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

			});

        //Inyeccion de dependencias
        builder.Services.AddTransient<LoginPage>();


        //Se agregan servicios
        builder.Services.AddSingleton<AuthenticationService>();

        return builder.Build();
	}
}
