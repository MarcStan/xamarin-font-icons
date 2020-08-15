using System.Windows.Input;

namespace XamarinFontIcons
{
    public class MainPageViewModel
    {
        private static readonly ThemeProvider _themeProvider = new ThemeProvider();

        public MainPageViewModel()
        {
            ToggleTheme = new RelayCommand(() =>
            {
                _themeProvider.ChangeTheme(!_themeProvider.Dark);
                App.Refresh();
            });
        }

        public ICommand ToggleTheme { get; }
    }
}
