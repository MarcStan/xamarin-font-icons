using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("FontAwesome-regular.otf", Alias = "FontAwesomeRegular")]
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinFontIcons
{
    public partial class App
    {
        public App()
        {
            Refresh();
        }

        public static void Refresh()
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
