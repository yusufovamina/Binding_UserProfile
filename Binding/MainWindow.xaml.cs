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

namespace Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool IsLetter(string text)
        {
            foreach (char ch in text) {
            if(char.IsLetter (ch)) {
                   return true;
                }
            
            }
            return false;
        }
        public void NamePreviewInput(object sender, TextCompositionEventArgs e)
        {
                  
                if (!(IsLetter(e.Text)))
                {
                    e.Handled = true;
                }
        }

        public bool IsEmailValid(string text)
        {
            return text.Contains("@");
        }
        public void EmailPreviewInput(object sender, TextCompositionEventArgs e)
        {
            if (!IsEmailValid(e.Text))
            {
                e.Handled = true;
            }
        }
    }
}
