using RebootWarning.Code;
using RebootWarning.Code.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Xceed.Wpf.Toolkit;

namespace RebootWarning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       private Color _selectedColor { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ClrPcker_Default.ColorMode = ColorMode.ColorCanvas;
            ClrPcker_Default.SelectedColor = DwmApiHelper.ColorizationColor.ToSWMColor();



            Console.Write("");

        }

        private void ClrPcker_Default_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            Console.Write(sender.ToString());
            _selectedColor = ClrPcker_Default.SelectedColor.Value;
            //TextBox.Text = "#" + ClrPcker_Background.SelectedColor.R.ToString() + ClrPcker_Background.SelectedColor.G.ToString() + ClrPcker_Background.SelectedColor.B.ToString();

        }


        private void SetColor()
        {
            DwmApiHelper.SetSystemColor(_selectedColor);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetColor();
        }
    }
}
