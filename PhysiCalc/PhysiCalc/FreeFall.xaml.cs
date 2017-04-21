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
            }
        }

        private void radioButtonHeight_Checked(object sender, RoutedEventArgs e)
        {
            textBlockChoiceInstruction.Text = "";
            if (radioButtonHeight.IsChecked == true)
            {
                inputType = false;
            }
        }

        private void buttonCalc_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString($"{pm.FreeFallMath(Convert.ToDouble(textBoxChoiceData.Text), inputType)}"));
        }
    }
}
