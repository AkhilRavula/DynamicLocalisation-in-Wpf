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

namespace DynamicLocalsn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SwitchLanguage("en");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("en");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SwitchLanguage("es");
        }

        private void SwitchLanguage(string LanguageCode)
        {
            ResourceDictionary dict = new ResourceDictionary();
            switch (LanguageCode)
            {
                case "en":
                    dict.Source = new Uri("..\\StringResources.en.xaml",UriKind.Relative);
                    break;
                case "es":
                    dict.Source = new Uri("..\\StringResources.es.xaml", UriKind.Relative);
                    break;
                default:
                    dict.Source = new Uri("..\\StringResources.en.xaml", UriKind.Relative);
                    break;
            }
            this.Resources.MergedDictionaries.Add(dict);
        }
    }
}
