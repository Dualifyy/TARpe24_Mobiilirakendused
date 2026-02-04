using Microsoft.Extensions.Logging;

namespace TARpe24_Mobiilirakendused
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("DS-DIGII.TTF", "DSDIGII");
                    fonts.AddFont("DS-DIGIT.TTF", "DSDIGIT");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
