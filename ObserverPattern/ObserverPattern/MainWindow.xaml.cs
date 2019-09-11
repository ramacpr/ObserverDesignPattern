using ObserverPattern.Helpers;
using ObserverPattern.Observable;
using ObserverPattern.Views;
using System.Windows;

namespace ObserverPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CPCell_JobListingView collegeView = new CPCell_JobListingView();
        Individuals_JobListingView individualsView = new Individuals_JobListingView();
        Online_JobListingView onlineView = new Online_JobListingView();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = AppData.GetObservable();

            // also bring up other views
            // this is only to test the observer pattern and this
            // may not be the correct way to bring up multiple views 
            // as it violates the OOAD principle "Program to interfcae"
            collegeView.Show();            
            individualsView.Show();            
            onlineView.Show(); 
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("All the subscriber windows will also be closed.", "Job Agency Portal", MessageBoxButton.OK, MessageBoxImage.Information);

            collegeView.Close();
            individualsView.Close();
            onlineView.Close();
        }
    }
}
