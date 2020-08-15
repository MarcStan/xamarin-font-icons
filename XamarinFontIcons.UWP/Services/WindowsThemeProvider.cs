using Windows.Storage;
using Windows.UI.Xaml;
using XamarinFontIcons.UWP.Services;

[assembly: Xamarin.Forms.Dependency(typeof(WindowsThemeProvider))]
namespace XamarinFontIcons.UWP.Services
{
    public class WindowsThemeProvider : IPlatformSpecificThemeProvider
    {
        public bool Dark { get; private set; }

        public void ChangeTheme(bool dark)
        {
            // during runtime only page theme can be changed
            App.MainPageInstance.RequestedTheme = dark ? ElementTheme.Dark : ElementTheme.Light;
            // app theme (nav bar) can only be changed in App.xaml.cs ctor on restart, so persist changes
            ApplicationData.Current.LocalSettings.Values["darkTheme"] = dark;

            Dark = dark;
        }
    }
}
