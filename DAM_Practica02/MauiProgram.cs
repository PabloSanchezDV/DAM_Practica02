using Microsoft.Extensions.Logging;

namespace DAM_Practica02
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
                    fonts.AddFont("OpenSans-Regular.ttf", "Open Sans");
                    fonts.AddFont("ARIAL.ttf", "Arial");
                    fonts.AddFont("times.ttf", "Times New Roman");
                    fonts.AddFont("cour.ttf", "Courier New");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
