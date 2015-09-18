using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventTracker.UserControls
{
    public partial class ListingControl : UserControl, IReceiverControl
    {
        public ListingControl()
        {
            InitializeComponent();
        }

        public void AddItemToList(string message)
        {
            if (!String.IsNullOrEmpty(message))
            {
                //Insert at first position, latest first
                lstLog.Items.Insert(0, message);
            }
        }
    }
}