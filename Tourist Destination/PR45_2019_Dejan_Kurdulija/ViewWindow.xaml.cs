using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace PR45_2019_Dejan_Kurdulija
{
    /// <summary>
    /// Interaction logic for ViewWindow.xaml
    /// </summary>
    public partial class ViewWindow : Window
    {
        public ViewWindow(string naziv)
        {
            InitializeComponent();

            string str = "";
            foreach (var s in naziv.Split())
            {
                str += s;
            }

            string putanja = "../../Rtf datoteka/";
            string konacnaPutanja = putanja + naziv + ".rtf";
            FileStream fileStream = new FileStream(konacnaPutanja, FileMode.Open);
            TextRange textRange = new TextRange(viewRtbOpis.Document.ContentStart, viewRtbOpis.Document.ContentEnd);
            textRange.Load(fileStream, DataFormats.Rtf);
            fileStream.Close();

        }

        private void viewButtonIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
