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

namespace PhysiCalc
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

        private void buttonFreeFall_Click(object sender, RoutedEventArgs e)
        {
            FreeFall freefallForm = new FreeFall();
            freefallForm.Show();
            this.Close();
        }

        private void buttonLightning_Click(object sender, RoutedEventArgs e)
        {
            Lightning lightningForm = new Lightning();
            lightningForm.Show();
            this.Close();
        }

        private void buttonProjectile_Click(object sender, RoutedEventArgs e)
        {
            Projectile projectileForm = new Projectile();
            projectileForm.Show();
            this.Close();
        }
    }
}
