using Classes;
using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace PR45_2019_Dejan_Kurdulija
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public bool boolSlika = false;
        public int index = 0;
        public string putanjaZaBrisanje;
        int wordCount = 0;

        public static BindingList<double> fontSize = new BindingList<double> { 8, 9, 11, 12, 14, 16, 18, 22, 25 };
        public static List<string> agencije = new List<string> { "Modena Travels", "Go2 Traveling", "Way Out", "Halo Tours" };


        public AddWindow(string putanjaDokumenta)
        {
            InitializeComponent();

            putanjaZaBrisanje = putanjaDokumenta;
            comboBoxAgencija.ItemsSource = agencije;
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies;
            cmbFontSize.ItemsSource = fontSize;
        }

        

        private void buttonIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {


            if (validate())
            {
                if (buttonDodaj.Content.Equals("Dodaj"))
                {
                    string putanja = saveRtfDocument();
                    MainWindow.destinacije.Add(new Destinacija(imgPhoto.Source.ToString(), textBoxNaziv.Text, comboBoxAgencija.Text, Int32.Parse(textBoxCena.Text), (DateTime)datePicker.SelectedDate, putanja));
                    this.Close();    
                }
                else
                {
                    File.Delete(putanjaZaBrisanje);
                    string putanja = saveRtfDocument();
                    MainWindow.destinacije[index] = new Destinacija(imgPhoto.Source.ToString(), textBoxNaziv.Text, comboBoxAgencija.Text, Int32.Parse(textBoxCena.Text), (DateTime)datePicker.SelectedDate, putanja); ;
                    //MainWindow.destinacije.ResetBindings();
                    this.Close();
                   
                }
            }
            else
            {
                MessageBox.Show("Niste dobro popunili podatke!", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        
        private bool validate()
        {
            bool isValid = true;

            if(textBoxNaziv.Text.Trim().Equals("") || textBoxNaziv.Text.Trim().Equals("unesite naziv"))
            {
                isValid = false;
                textBoxNaziv.BorderBrush = Brushes.Red;
                textBoxNaziv.BorderThickness = new Thickness(2);
                labelNazivGreska.Content = "Unesite naziv!";
            }
            else
            {
                textBoxNaziv.BorderBrush = Brushes.Black;
                labelNazivGreska.Content = "";
            }


            if(comboBoxAgencija.SelectedItem == null)
            {
                isValid = false;
                comboBoxAgencija.BorderBrush = Brushes.Red;
                comboBoxAgencija.BorderThickness = new Thickness(2);
                labelAgencijaGreska.Content = "Unesite agenciju!";
            }
            else
            {
                comboBoxAgencija.BorderBrush = Brushes.Black;
                labelAgencijaGreska.Content = "";
            }


            if(textBoxCena.Text.Trim().Equals("") || textBoxCena.Text.Trim().Equals("unesite cenu"))
            {
                isValid = false;
                textBoxCena.BorderBrush = Brushes.Red;
                textBoxCena.BorderThickness = new Thickness(2);
                labelCenaGreska.Content = "Unesite cenu!";
            }
            else
            {
                //textBoxCena.BorderBrush = Brushes.Black;

                try
                {
                    double cena = Double.Parse(textBoxCena.Text.Trim());
                    if (cena < 0)
                    {
                        isValid = false;
                        textBoxCena.BorderBrush = Brushes.Red;
                        textBoxCena.BorderThickness = new Thickness(2);
                        labelCenaGreska.Content = "Cena mora biti pozitivan broj!";
                    }
                    else
                    {
                        textBoxCena.BorderBrush = Brushes.Black;
                        labelCenaGreska.Content = "";
                    }
                }
                catch(Exception e)
                {
                    isValid = false;
                    textBoxCena.BorderBrush = Brushes.Red;
                    textBoxCena.BorderThickness = new Thickness(2);
                    labelCenaGreska.Content = "Cena mora biti broj!";
                    Console.WriteLine(e.Message);
                }
            }


            if(datePicker.SelectedDate == null)
            {
                isValid = false;
                labelDatumGreska.Content = "Unesite datum!";
                datePicker.BorderBrush = Brushes.Red;
            }
            else
            {
                labelDatumGreska.Content = "";
                datePicker.BorderBrush = Brushes.Black;
            }


            if(!boolSlika && buttonDodaj.Content.Equals("Dodaj"))
            {
                labelSlikaGreska.Content = "Dodajte sliku!";
                Browse.BorderBrush = Brushes.Red;
                Browse.BorderThickness = new Thickness(2);
                isValid = false;
            }
            else
            {
                labelSlikaGreska.Content = "";
                Browse.BorderBrush = Brushes.Black;
            }


            if (IsRichTextBoxEmpty(rtbOpis))
            {
                isValid = false;
                labelOpisGreska.Content = "Unesite opis!";
                rtbOpis.BorderBrush = Brushes.Red;
                rtbOpis.BorderThickness = new Thickness(2);
            }
            else
            {
                labelOpisGreska.Content = "";
                rtbOpis.BorderBrush = Brushes.Black;
            }

            return isValid;
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgPhoto.Source = new BitmapImage(fileUri);
                boolSlika = true;
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbFontFamily.SelectedItem != null && !rtbOpis.Selection.IsEmpty)
            {
                rtbOpis.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
            }
        }

        private void cmbFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontSize.SelectedItem != null && !rtbOpis.Selection.IsEmpty)
            {
                rtbOpis.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.SelectedItem);
            }
        }

       private void buttonColor_Click(object sender, RoutedEventArgs e)
       {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();

            if(colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(!rtbOpis.Selection.IsEmpty)
                {
                    rtbOpis.Selection.ApplyPropertyValue(Inline.ForegroundProperty, new SolidColorBrush(Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B)));
                }
            }    
       }

        private void rtbOpis_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp;

            temp = rtbOpis.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;

            temp = rtbOpis.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.SelectedItem = temp;

            temp = rtbOpis.Selection.GetPropertyValue(Inline.FontWeightProperty);
            buttonBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));

            temp = rtbOpis.Selection.GetPropertyValue(Inline.FontStyleProperty);
            buttonItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));

            temp = rtbOpis.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            buttonUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));  
        }

        public bool IsRichTextBoxEmpty(RichTextBox richTextBox)
        {
            if (wordCount == 0)
                return true;

            if (rtbOpis.Document.Blocks.Count == 0) return true;
            TextPointer start = rtbOpis.Document.ContentStart.GetNextInsertionPosition(LogicalDirection.Forward);
            TextPointer end = rtbOpis.Document.ContentEnd.GetNextInsertionPosition(LogicalDirection.Backward);
            return start.CompareTo(end) == 0;
        }

        public string saveRtfDocument()
        {
            string naziv = "";
            foreach (var s in textBoxNaziv.Text.Split())
            {
                naziv += s;
            }

            string putanja = "../../Rtf datoteka/";
            string konacnaPutanja = putanja + naziv + ".rtf";
            FileStream fileStream = new FileStream(konacnaPutanja, FileMode.Create);
            TextRange textRange = new TextRange(rtbOpis.Document.ContentStart, rtbOpis.Document.ContentEnd);
            textRange.Save(fileStream, DataFormats.Rtf);
            fileStream.Close();

            return konacnaPutanja;
        }


        private void rtbOpis_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextRange textRange = new TextRange(rtbOpis.Document.ContentStart, rtbOpis.Document.ContentEnd);
            string trText = textRange.Text.Trim();

            wordCount = 0;

            foreach (string word in trText.Split(' '))
            {
                if (word != "")
                {
                    wordCount++;
                }
            }

            textBoxWordsCount.Text = wordCount.ToString();
        }

        private void textBoxNaziv_GotFocus(object sender, RoutedEventArgs e)
        {
            if(textBoxNaziv.Text.Trim().Equals("unesite naziv"))
            {
                textBoxNaziv.Text = "";
                textBoxNaziv.Foreground = Brushes.Black;
            }
        }

        private void textBoxNaziv_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxNaziv.Text.Trim().Equals(String.Empty))
            {
                textBoxNaziv.Text = "unesite naziv";
                textBoxNaziv.Foreground = Brushes.LightSlateGray;
            }
        }

        private void textBoxCena_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxCena.Text.Trim().Equals("unesite cenu"))
            {
                textBoxCena.Text = "";
                textBoxCena.Foreground = Brushes.Black;
            }
        }

        private void textBoxCena_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBoxCena.Text.Trim().Equals(String.Empty))
            {
                textBoxCena.Text = "unesite cenu";
                textBoxCena.Foreground = Brushes.LightSlateGray;
            }
        }
    }
}
