using Microsoft.Extensions.Logging;

namespace BeautyShopApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("fallingsky.ttf", "FallingSky");
				fonts.AddFont("fallingSkybd.ttf", "FallingSkyBold");
                fonts.AddFont("fallingskylight.ttf", "FallingSkyLight");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
