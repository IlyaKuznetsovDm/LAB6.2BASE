using Stacks;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace LAB6._2BASE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<Phones> _phones;
        public MainWindow()
        {
            InitializeComponent();
            _phones = new Stack<Phones>();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            if (addWindow.ShowDialog() == true)
            {
                Phones phones = addWindow.PhonesMy;
                _phones.Push(phones);
                Phones.ItemsSource = null;
                Phones.ItemsSource = _phones;

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _phones.Pop();
            Phones.ItemsSource = null;
            Phones.ItemsSource = _phones;          
        }
        
    }
}
