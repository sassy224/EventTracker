using EventTracker.Model;
using EventTracker.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTracker.Mediator
{
    internal class LogMediator : IMediator
    {
        /// <summary>
        /// Allow this mediator to listen to an event that the IPublisherControl publishes
        /// </summary>
        /// <param name="control"></param>
        public void MapEventToControl(IPublisherControl pubControl, IReceiverControl recControl)
        {
            pubControl.InteractionOccursEvent += recControl.AddItemToList;
        }
    }
}