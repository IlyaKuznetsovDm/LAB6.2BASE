using LAB6._2BASE;
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
using System.Windows.Shapes;

namespace Stacks
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public Phones PhonesMy { get; set; }
        public AddWindow()
        {
            InitializeComponent();
            PhonesMy = new Phones();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            try
            {
                PhonesMy.Name = NamePhones.Text;
                PhonesMy.Price = decimal.Parse(PricePhones.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult=false;
        }


    }
}
