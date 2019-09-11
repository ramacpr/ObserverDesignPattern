using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ObserverPattern.Data;
using ObserverPattern.Helpers;
using ObserverPattern.Observer;

namespace ObserverPattern.Observable
{
    public class JobAgency : BindingHelper, IObservable
    {
        string jobData;
        public string JobData
        {
            get => jobData;
            set { jobData = value; OnPropertyChanged("JobData"); }
        }

        private ICommand _postCommand;
        public ICommand PostCommand
        {
            get
            {
                if (_postCommand == null)
                {
                    _postCommand = new MyCommand(
                        param => NotifyAllObservers(),
                        param => CanPost()
                    );
                }
                return _postCommand;
            }
        }

        private bool CanPost()
        {
            return true;
        }

        public JobAgency()
        {
            
        }

        #region Subscription Mechanism
        List<IObserver> subscriptionList = new List<IObserver>();

        public void NotifyAllObservers()
        {
            ISubscribedData jobData = new JobInfo(JobData);
            foreach (IObserver subscriber in subscriptionList)
                subscriber.Update(jobData);
        }

        public void RegisterObserver(IObserver observer)
        {
            subscriptionList.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            subscriptionList.Remove(observer);
        } 
        #endregion
    }
}
