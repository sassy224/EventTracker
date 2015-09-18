using EventTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTracker.Mediator
{
    internal class LogMediator : IMediator
    {
        //The event that this mediator publish
        public event LogHandler NewLogEvent;

        //The method which fires the event.
        public void Log(InteractionInfoEventArgs interactionInfo)
        {
            //Build log message
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Control: {0}, ", interactionInfo.ControlName);
            sb.AppendFormat("Event: {0}", interactionInfo.EventName);
            if (!String.IsNullOrEmpty(interactionInfo.EventText))
                sb.AppendFormat(", Info: {0}", interactionInfo.EventText);

            //raised event
            NewLogEvent(sb.ToString());
        }

        /// <summary>
        /// Allow this mediator to listen to an event that the IPublisherControl publishes
        /// </summary>
        /// <param name="control"></param>
        public void SubscribeToControl(UserControls.IPublisherControl control)
        {
            control.InteractionOccursEvent += this.Log;
        }

        /// <summary>
        /// Allow an IReceiverControl to listen to an event that this mediator publishes
        /// </summary>
        /// <param name="control"></param>
        public void PublishToControl(UserControls.IReceiverControl control)
        {
            this.NewLogEvent += control.AddItemToList;
        }
    }
}