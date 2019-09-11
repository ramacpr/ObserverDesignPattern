using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ObserverPattern.Data;
using ObserverPattern.Helpers;
using ObserverPattern.Observable;

namespace ObserverPattern.Observer
{
    public class CollegePlacementCell : BindingHelper, IObserver
    {
        public CollegePlacementCell()
        {

        }

        string jobListingText;
        public string JobListingText
        {
            get => jobListingText;
            set
            { jobListingText = value; OnPropertyChanged("JobListingText"); }
        }

        public void Update(ISubscribedData data)
        {
            if (data == null)
                return;
            JobListingText = data.GetJobDescription();
        }

        #region Subscribe/Unsubscribe button commands
        private ICommand _subscribeCommand;
        public ICommand SubscribeCommand
        {
            get
            {
                if (_subscribeCommand == null)
                {
                    _subscribeCommand = new MyCommand(
                        param => OnSubscribeSelf(),
                        param => CanSubScribe()
                    );
                }
                return _subscribeCommand;
            }
        }

        bool CanSubScribe()
        {
            return true;
        }

        void OnSubscribeSelf()
        {
            AppData.GetObservable().RegisterObserver(this);
        }

        private ICommand _unsubscribeCommand;
        public ICommand UnsubscribeCommand
        {
            get
            {
                if (_unsubscribeCommand == null)
                {
                    _unsubscribeCommand = new MyCommand(
                        param => OnUnsubscribeSelf(),
                        param => CanUnsubScribe()
                    );
                }
                return _unsubscribeCommand;
            }
        }

        bool CanUnsubScribe()
        {
            return true;
        }

        void OnUnsubscribeSelf()
        {
            AppData.GetObservable().UnRegisterObserver(this);
        } 
        #endregion
    }
}
