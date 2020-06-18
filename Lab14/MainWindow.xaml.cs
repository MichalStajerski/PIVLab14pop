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

namespace Lab14
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private IPanelFiller _panelFiller;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(IPanelFiller panelFiller) : this()
        {
            _panelFiller = panelFiller;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _panelFiller.Fill(MyStackPanel);
        }
    }
}
