﻿using EventTracker.Model;
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

        public void AddItemToList(InteractionInfoEventArgs interactionInfo)
        {
            //Build log message
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Control: {0}, ", interactionInfo.ControlName);
            sb.AppendFormat("Event: {0}", interactionInfo.EventName);
            if (!String.IsNullOrEmpty(interactionInfo.EventText))
                sb.AppendFormat(", Info: {0}", interactionInfo.EventText);

            //Insert at first position, latest first
            lstLog.Items.Insert(0, sb.ToString());
        }
    }
}