using EventTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTracker.Mediator
{
    //The delegate that encapsulates any method that takes a string as parameter and return no value
    public delegate void LogHandler(string logMessage);

    public interface IMediator
    {
        //The event that this mediator publish
        event LogHandler NewLogEvent;

        //The method which fires the event.
        //This method also has the same signature as InteractionOccursEvent of EventControl, because this mediator will subscribe this method to that event
        void Log(InteractionInfoEventArgs interactionInfo);
    }
}