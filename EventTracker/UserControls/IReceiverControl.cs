using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTracker.UserControls
{
    public interface IReceiverControl : IControl
    {
        void AddItemToList(string message);
    }
}