using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PR45_2019_Dejan_Kurdulija
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static BindingList<Destinacija> destinacije{ get; set; }

        public MainWindow()
        {
            if(destinacije == null)
            {
                destinacije = new BindingList<Destinacija>();
            }

            DataContext = this;

            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow("");
            addWindow.ShowDialog();
            //dataGridDestinacije.Items.Refresh();
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonProcitaj_Click(object sender, RoutedEventArgs e)
        {            
            ViewWindow viewWindow = new ViewWindow(((Destinacija)dataGridDestinacije.SelectedItem).Naziv);
            viewWindow.viewImgPhoto.Source = new BitmapImage(new Uri(destinacije[dataGridDestinacije.SelectedIndex].Slika));
            viewWindow.viewLabelNaslov.Content = destinacije[dataGridDestinacije.SelectedIndex].Naziv;
            viewWindow.viewAgencija.Content = destinacije[dataGridDestinacije.SelectedIndex].Agencija;
            viewWindow.viewCena.Content = destinacije[dataGridDestinacije.SelectedIndex].Cena.ToString();
            viewWindow.viewDatum.Content = destinacije[dataGridDestinacije.SelectedIndex].DatumPolaska.ToString();

            viewWindow.ShowDialog();
            //dataGridDestinacije.Items.Refresh();
        }

        private void buttonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            
            AddWindow addWindow = new AddWindow(((Destinacija)dataGridDestinacije.SelectedItem).Putanja);

            addWindow.textBoxNaziv.Text = destinacije[dataGridDestinacije.SelectedIndex].Naziv;
            addWindow.comboBoxAgencija.Text = destinacije[dataGridDestinacije.SelectedIndex].Agencija;
            addWindow.textBoxCena.Text = destinacije[dataGridDestinacije.SelectedIndex].Cena.ToString();
            addWindow.imgPhoto.Source = new BitmapImage(new Uri(destinacije[dataGridDestinacije.SelectedIndex].Slika));
            addWindow.datePicker.SelectedDate = destinacije[dataGridDestinacije.SelectedIndex].DatumPolaska;

            loadFromRtfDocument(addWindow);

            addWindow.buttonDodaj.Content = "Izmeni";
            addWindow.labelNaslov.Content = "Izmena destinacije";
            addWindow.index = dataGridDestinacije.SelectedIndex;
            addWindow.ShowDialog();
            //dataGridDestinacije.Items.Refresh();
        }

        private void buttonObrisi_Click(object sender, RoutedEventArgs e)
        {
            File.Delete(((Destinacija)dataGridDestinacije.SelectedItem).Putanja);
            destinacije.RemoveAt(dataGridDestinacije.SelectedIndex);
            //dataGridDestinacije.Items.Refresh();
        }

        public void loadFromRtfDocument(AddWindow addWindow)
        {
            string naziv = "";
            foreach (var s in addWindow.textBoxNaziv.Text.Split())
            {
                naziv += s;
            }

            string putanja = "../../Rtf datoteka/";
            string konacnaPutanja = putanja + naziv + ".rtf";
            FileStream fileStream = new FileStream(konacnaPutanja, FileMode.Open);
            TextRange textRange = new TextRange(addWindow.rtbOpis.Document.ContentStart, addWindow.rtbOpis.Document.ContentEnd);
            textRange.Load(fileStream, DataFormats.Rtf);
            fileStream.Close();
        }
    }
}
