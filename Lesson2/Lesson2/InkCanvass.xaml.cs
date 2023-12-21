using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lesson2
{
    /// <summary>
    /// Логика взаимодействия для InkCanvass.xaml
    /// </summary>
    public partial class InkCanvass : Window
    {
        public InkCanvass()
        {
            InitializeComponent();
        }

        private void Window_LayoutUpdated(object sender, EventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode)))
                IstEditingMode.Items.Add(mode);
            IstEditingMode.SelectedItem = inkCanvasPanel.EditingMode;
        }

        private void inkCanvasPanel_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
            String gestures = "";

            foreach (GestureRecognitionResult res in e.GetGestureRecognitionResults())
                gestures += res.ApplicationGesture.ToString() + "; ";

            gestureName.Text = gestures;
        }
    }
}
