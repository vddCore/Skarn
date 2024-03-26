using Avalonia;

namespace Typhoon.UI.Fonts.OpenSans
{
    public static class AppBuilderExtensions
    {
        public static AppBuilder WithOpenSansFont(this AppBuilder appBuilder)
        {
            return appBuilder.ConfigureFonts(fontManager =>
            {
                fontManager.AddFontCollection(new OpenSansFontCollection());
            });
        }
    }
}