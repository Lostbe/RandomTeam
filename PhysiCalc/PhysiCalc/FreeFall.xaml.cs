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

namespace PhysiCalc
{
    /// <summary>
    /// Interaction logic for FreeFall.xaml
    /// </summary>
    public partial class FreeFall : Window
    {
        private FreeFallMath ffm;

        public FreeFall()
        {

            InitializeComponent();

            ffm = new FreeFallMath();
            ffm.
        }

        private void backToMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            mainMenu.Show();
            this.Close();
        }

        private void RadioButtonHeight(object sender, RoutedEventArgs e)
        {
            textBlockChoiceInstruction.Text = "";
        }

        private void RadioButtonTime(object sender, RoutedEventArgs e)
        {
            textBlockChoiceInstruction.Text = "";
        }
    }
}
