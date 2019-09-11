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
    /// Interaction logic for CPCell_JobListingView.xaml
    /// </summary>
    public partial class CPCell_JobListingView : Window
    {
        public CPCell_JobListingView()
        {
            InitializeComponent();
            this.DataContext = new CollegePlacementCell();
        }
    }
}
