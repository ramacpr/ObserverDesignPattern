using ObserverPattern.Observer;
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

namespace ObserverPattern.Views
{
    /// <summary>
    /// Interaction logic for Individuals_JobListingView.xaml
    /// </summary>
    public partial class Individuals_JobListingView : Window
    {
        public Individuals_JobListingView()
        {
            InitializeComponent();
            this.DataContext = new IndividualSeekers();
        }
    }
}
