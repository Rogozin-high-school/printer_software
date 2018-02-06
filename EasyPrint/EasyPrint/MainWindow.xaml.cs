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

namespace EasyPrint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetProgress(30);
            SetIndicatorColor(Colors.Red);
        }

        /*
        *  Sets the progressbar percentage 
        */
        public void SetProgress(float percent)
        {
            progressBar.Width = Width * percent / 100;
            progressBar.Height = Height * 0.07f;
        }

        /*
        *  Sets the progressbar color 
        */
        public void SetIndicatorColor(Color c)
        {
            progressBar.Fill = new SolidColorBrush(c);
        }
    }
}
