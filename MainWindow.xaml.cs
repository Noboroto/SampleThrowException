using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleThrowException
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DarkBut_Click(object sender, RoutedEventArgs e)
        {
            var paletteHelper = new PaletteHelper();
            //Retrieve the app's existing theme
            ITheme theme = paletteHelper.GetTheme();

            //Change the base theme to Dark
            theme.SetBaseTheme(Theme.Dark);
            //or theme.SetBaseTheme(Theme.Light);

            //Change the app's current theme
            paletteHelper.SetTheme(theme);
        }

        private void LightBut_Click(object sender, RoutedEventArgs e)
        {
            var paletteHelper = new PaletteHelper();
            //Retrieve the app's existing theme
            ITheme theme = paletteHelper.GetTheme();

            //Change the base theme to Dark
            theme.SetBaseTheme(Theme.Light);
            //or theme.SetBaseTheme(Theme.Light);

            //Change the app's current theme
            paletteHelper.SetTheme(theme);
        }
    }
}
