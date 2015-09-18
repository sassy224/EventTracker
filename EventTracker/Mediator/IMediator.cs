using EventTracker.Model;
using EventTracker.UserControls;
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
        //The event that this interface publish
        event LogHandler NewLogEvent;

        //The method which fires the event.
        void Log(InteractionInfoEventArgs interactionInfo);

        /// <summary>
        /// Interface method to listen to an event of a control
        /// </summary>
        /// <param name="control"></param>
        void SubscribeToControl(IPublisherControl control);

        /// <summary>
        /// Interface method to allow a control to listen to event of this interface
        /// </summary>
        /// <param name="control"></param>
        void PublishToControl(IReceiverControl control);
    }
}