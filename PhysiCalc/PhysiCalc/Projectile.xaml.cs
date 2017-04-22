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
    /// Interaction logic for Projectile.xaml
    /// </summary>
    public partial class Projectile : Window
    {
        private PhysicsMath pm;
        public Projectile()
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

        private void buttonCalculate_Click(object sender, RoutedEventArgs e)
        {
            double theta = double.Parse(textBoxTheta.Text);
            double initialHeight = double.Parse(textBoxLaunchHeight.Text);
            double initialVelocity = double.Parse(textBoxVelocityNot.Text);
            textBlockHorizontalDistance.Text = $"The projectile will travel {pm.ProjectileDistance(initialHeight, theta, initialVelocity)} meters horizontally";
        }
    }
}
