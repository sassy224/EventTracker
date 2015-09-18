using EventTracker.Mediator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTracker
{
    public partial class Form1 : Form
    {
        private IMediator _mediator;

        public Form1(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;

            //Let mediator listen to event InteractionOccursEvent of EventControl
            _mediator.SubscribeToControl(evtCtrl);

            //Let ListingControl listen to event NewLogEvent of Mediator
            _mediator.PublishToControl(lstCtrl);
        }
    }
}