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

namespace _344pr1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridSplitterButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void GridSplitterButton_Click_1(object sender, RoutedEventArgs e)
        {
            GridSpliterWindow gridSplitterWindow = new GridSpliterWindow();
            gridSplitterWindow.Show();
        }

        private void stackPanelButton_Click(object sender, RoutedEventArgs e)
        {
            Stack stack = new Stack();
            stack.Show();
        }

        private void dockPanelButton_Click(object sender, RoutedEventArgs e)
        {
            DockPanelWindow dock =  new DockPanelWindow();
            dock.Show();
        }

        private void wrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelWindow wrappp = new WrapPanelWindow();
            wrappp.Show();
        }
    }
}
