using XamarinFontIcons.Droid.Services;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidThemeProvider))]
namespace XamarinFontIcons.Droid.Services
{
    public class AndroidThemeProvider : IPlatformSpecificThemeProvider
    {
        public bool Dark { get; private set; }

        public void ChangeTheme(bool dark)
        {
            Dark = dark;
        }
    }
}
