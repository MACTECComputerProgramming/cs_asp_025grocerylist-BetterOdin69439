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

namespace CS_ASP_025
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string[] listarray;
        int num = 0;
        double total = 0;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            newlist();
            labelTelllToAdd.Content = "Enter Items";
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Visible;



        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            if (num + 1 == listarray.Length) labelTelllToAdd.Content = "Press again to print list";
            if (num + 1 < listarray.Length) labelTelllToAdd.Content = "Enter Item: " + (num + 2);

            additem();



        }


        private void newlist()
        {
            listarray = new string[Convert.ToInt32(textBoxTotalAmount.Text)];


        }

        private void additem()
        {
            if (num < listarray.Length)
            {
                total += Convert.ToDouble(textBoxPrice.Text);
                listarray[num] = textBoxName.Text + string.Format(" {0:c}", Convert.ToDouble(textBoxPrice.Text));
                num++;
            }
            else
            {
                foreach (string x in listarray)
                {
                    labelList.Content += x + "\n";
                }
                labelTotal.Content = string.Format("Total: {0:c}", total);
            }
            textBoxPrice.Text = null;
            textBoxName.Text = null;

        }
    }
}