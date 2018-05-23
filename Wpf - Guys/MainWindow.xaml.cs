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

namespace Wpf___Guys
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;
            joe = new Guy() { Cash = 50, Name = "Joe" };  //joe.Name = "Joe"; joe.Cash = 50;
            UpdateForm();
        }
        Guy joe;
        Guy bob;
        int bank = 100;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("В банке нет денег.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }
        public void UpdateForm()
        {
            joesCashLabel.Content = joe.Name + " имеет $" + joe.Cash;
            bobsCashLabel.Content = bob.Name + " имеет $" + bob.Cash;
            bankCashLabel.Content = "В банке сейчас $" + bank;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            joe.GiveCash(bob.ReceiveCash(10));
            UpdateForm();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            bob.GiveCash(joe.ReceiveCash(5));
            UpdateForm();
        }
    }
}

