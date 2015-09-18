using EventTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTracker.UserControls
{
    //The delegate that encapsulates any method that takes an object and an InteractionInfoEventArgs as parameters and return no value
    public delegate void InteractionHandler(InteractionInfoEventArgs interactInfo);

    public interface IControl
    {
    }
}