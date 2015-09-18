using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTracker.UserControls
{
    public interface IPublisherControl : IControl
    {
        //The event that this control publish
        event InteractionHandler InteractionOccursEvent;
    }
}