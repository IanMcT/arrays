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
using System.IO;

namespace u3ArrayExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int[] scores = new int[100];
            int counter = 0;
            int total = 0;

            try
            {
                System.IO.StreamReader streamReader = new StreamReader("scores.txt");
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    int.TryParse(line, out scores[counter]);
                    counter++;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            string temp = "";
            for (int i = 0; i < counter; i++)
            {
                temp += scores[i].ToString() + "\n";
                total += scores[i];
            }
            int average = total / (counter + 1);
            temp = "Average score = " + average.ToString() + "\n" +
                temp;

            MessageBox.Show(temp);
        }
    }
}
