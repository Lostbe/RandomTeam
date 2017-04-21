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
        private PhysicsMath pm;
        bool inputType;
        public FreeFall()
        {

            InitializeComponent();

            pm = new PhysicsMath();
           
        }

        private void backToMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            mainMenu.Show();
            this.Close();
        }
        private void radioButtonTime_Checked(object sender, RoutedEventArgs e)
        {
            textBlockChoiceInstruction.Text = "";
            if (radioButtonTime.IsChecked == true)
            {
                inputType = true;
                textBlockChoiceInstruction.Text = "Please enter the height of the ledge in meters.";
            }
        }

        private void radioButtonHeight_Checked(object sender, RoutedEventArgs e)
        {
            textBlockChoiceInstruction.Text = "";
            if (radioButtonHeight.IsChecked == true)
            {
                inputType = false;
                textBlockChoiceInstruction.Text = "Please enter the time for an object to fall in seconds.";
            }
        }
        private void buttonCalc_Click_1(object sender, RoutedEventArgs e)
        {
            freeFallOutputTxtBlock.Text = $"{pm.FreeFallMath(Convert.ToDouble(textBoxChoiceData.Text), inputType)}";
            if(inputType == true)
            {
                freeFallOutputTxtBlock.Text += " sec";
            }
            else
            {
                freeFallOutputTxtBlock.Text += " meters";
            }
        }
    }
}
