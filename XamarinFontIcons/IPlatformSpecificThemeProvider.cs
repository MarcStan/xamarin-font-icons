namespace XamarinFontIcons
{
    public interface IPlatformSpecificThemeProvider
    {
        void ChangeTheme(bool dark);

        bool Dark { get; }
    }
}
