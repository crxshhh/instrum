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

namespace SRLessonn1
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
            ColorButtons color = new ColorButtons();
            color.Show();
        }

        private void stackPanelButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow stackk = new StackPanelWindow();
            stackk.Show();
        }

        private void dockPanelButton_Click(object sender, RoutedEventArgs e)
        {
            Dockkk docck = new Dockkk();
            docck.Show();
        }

        private void wrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
            WraaapPanel wrap = new WraaapPanel();
            wrap.Show();
        }
    }
}
