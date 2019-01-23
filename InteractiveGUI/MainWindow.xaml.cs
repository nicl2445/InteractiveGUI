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

namespace InteractiveGUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Controller cont = Controller.GetInstance();
            cont.NextPerson();
            TextBox1.Text = cont.CurrentPerson.FirstName;
            TextBox2.Text = cont.CurrentPerson.LastName;
            TextBox3.Text = cont.CurrentPerson.Age.ToString();
            TextBox4.Text = cont.CurrentPerson.TelephoneNo;
            Index.Content = "Index " + cont.PersonIndex;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Controller cont = Controller.GetInstance();
            cont.PrevPerson();
            TextBox1.Text = cont.CurrentPerson.FirstName;
            TextBox2.Text = cont.CurrentPerson.LastName;
            TextBox3.Text = cont.CurrentPerson.Age.ToString();
            TextBox4.Text = cont.CurrentPerson.TelephoneNo;
            Index.Content = "Index " + cont.PersonIndex;
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox1.IsEnabled = true;
            TextBox2.IsEnabled = true;
            TextBox3.IsEnabled = true;
            TextBox4.IsEnabled = true;
            Controller cont = Controller.GetInstance();
            if(cont.PersonCount >= 1)
            {
                But1.IsEnabled = true;
                But2.IsEnabled = true;
                But4.IsEnabled = true;
            }
            cont.AddPerson();
            Count.Content = "Person Count " + cont.PersonCount;
            Index.Content = "Index " + cont.PersonIndex;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Controller cont = Controller.GetInstance();
            cont.DeletePerson();
            Count.Content = "Person Count " + cont.PersonCount;
            Index.Content = "Index " + cont.PersonIndex;
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Controller cont = Controller.GetInstance();
            cont.CurrentPerson.FirstName = TextBox1.Text;

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Controller cont = Controller.GetInstance();
            cont.CurrentPerson.LastName = TextBox2.Text;
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Controller cont = Controller.GetInstance();
            cont.CurrentPerson.Age = int.Parse(TextBox3.Text);
        }

        private void TextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            Controller cont = Controller.GetInstance();
            cont.CurrentPerson.TelephoneNo = TextBox4.Text;
        }
    }
}
