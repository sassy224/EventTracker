using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTracker.Model
{
    public class InteractionInfoEventArgs : EventArgs
    {
        public readonly string ControlName;
        public readonly string EventName;
        public readonly string EventText;

        public InteractionInfoEventArgs(string controlName, string eventName, string eventText)
        {
            this.ControlName = controlName;
            this.EventName = eventName;
            this.EventText = eventText;
        }
    }
}