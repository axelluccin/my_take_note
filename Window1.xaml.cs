using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace TestWPF
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        CultureInfo c = new CultureInfo("fr-FR");
        public Window1()
        {
            InitializeComponent();
            List<Note_> l = new List<Note_>();

            l.Add(new Note_ { Titre = "Rappel", Text = "Voila le contenu", Modification = DateTime.Now.ToString(c)});
            l.Add(new Note_ { Titre = "coucou", Text = "super cela marche", Modification = DateTime.Now.ToString(c)});
            
            ListNote.ItemsSource = l;
        }

    }

    public class Note_
    {
        public string Titre { get; set; }
        public string Modification { get; set; }
        public string Text { get; set; }
    }
}
