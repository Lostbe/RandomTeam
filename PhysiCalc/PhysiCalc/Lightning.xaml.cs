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
    /// Interaction logic for Lightning.xaml
    /// </summary>
    public partial class Lightning : Window
    {
        private PhysicsMath pm;
        public Lightning()
        {
            InitializeComponent();
            pm = new PhysicsMath();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            mainMenu.Show();
            this.Close();
        }

        private void buttonLightningDistance_Click(object sender, RoutedEventArgs e)
        {
            double timeToEar = double.Parse(textBoxTimeToEar.Text);
            textBoxLightningResult.Text = $"The lightning strike was {pm.LightningMath(timeToEar):f3} kilometers away.";
        }
    }
}
