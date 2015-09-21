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
    public interface IMediator
    {
        /// <summary>
        /// Interface method to map event from a control to a method in another control
        /// </summary>
        /// <param name="pubControl"></param>
        /// <param name="recControl"></param>
        void MapEventToControl(IPublisherControl pubControl, IReceiverControl recControl);
    }
}