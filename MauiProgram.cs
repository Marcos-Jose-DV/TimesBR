using Microsoft.Extensions.Logging;
using Times_do_Brasil.Data;
using Times_do_Brasil.ViewModels;
using Times_do_Brasil.Views;

namespace Times_do_Brasil;

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

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<TabelaPage>();
        builder.Services.AddSingleton<TabelaViewModel>();


        var appDbContext = new AppDbContext();
        appDbContext.Database.EnsureCreated();
        appDbContext.Dispose();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
