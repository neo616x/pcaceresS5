﻿using Microsoft.Extensions.Logging;

namespace pcaceresS4;

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

		string dbPath = FileAccessHelper.GetLocalFilePath("persona.db3");
		builder.Services.AddSingleton<PersonaRepository>(s => ActivatorUtilities.CreateInstance<PersonaRepository>(s, dbPath));


#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
