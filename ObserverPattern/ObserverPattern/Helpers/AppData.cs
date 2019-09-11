using ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Helpers
{
    public class AppData
    {
        static IObservable Observable; 

        static public IObservable GetObservable()
        {
            if (Observable == null)
                Observable = new JobAgency(); 
            return Observable;
        }
    }
}
