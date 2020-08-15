using Xamarin.Forms;

namespace XamarinFontIcons
{
    public class ThemeProvider
    {
        private IPlatformSpecificThemeProvider _platformSpecificThemeProvider;

        public ThemeProvider()
        {
            _platformSpecificThemeProvider = DependencyService.Get<IPlatformSpecificThemeProvider>();
        }

        public Color BackgroundColor => Dark ? Color.Black : Color.White;

        public Color TextColor => Dark ? Color.White : Color.Black;

        public bool Dark { get; private set; }

        public void ChangeTheme(bool dark)
        {
            Dark = dark;
            _platformSpecificThemeProvider.ChangeTheme(dark);
            var foregroundLight = Color.FromHex("777777");
            var button = Color.FromHex("D6D8D7");
            if (dark)
            {
                foregroundLight = Color.LightGray;
                button = Color.FromHex("33302E");
            }
            App.Current.Resources["BackgroundColor"] = BackgroundColor;
            App.Current.Resources["TextColor"] = TextColor;
            App.Current.Resources["LightTextColor"] = foregroundLight;
            App.Current.Resources["ButtonColor"] = button;
        }
    }
}
