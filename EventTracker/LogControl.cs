using EventTracker.Mediator;
using EventTracker.Model;
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
    public partial class LogControl : Form
    {
        private IMediator _mediator = null;

        public LogControl(IMediator mediator)
        {
            InitializeComponent();

            //Init vars
            _mediator = mediator;

            //Subscribe the control lstLogs to mediator
        }

        //The delegate that encapsulates any method that takes an object and an InteractionInfoEventArgs as parameters and return no value
        public delegate void InteractionHandler(object sender, InteractionInfoEventArgs interactInfo);

        //The event that this form publish
        public event InteractionHandler InteractionOccursEvent;

        //The method which fires the event
        protected void OnInteractionOccured(object sender, InteractionInfoEventArgs interactInfo)
        {
            //Check if there are any objects that subscribe to this event, notify them
            if (InteractionOccursEvent != null)
            {
                InteractionOccursEvent(sender, interactInfo);
            }
        }

        private void txtKeyboard_KeyDown(object sender, KeyEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "KeyDown";
            string eventText = String.Format("KeyCode: {0}, KeyValue: {1}", e.KeyCode.ToString(), e.KeyValue);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtKeyboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "KeyPress";
            string eventText = String.Format("KeyChar: {0}", e.KeyChar);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtKeyboard_KeyUp(object sender, KeyEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "KeyUp";
            string eventText = String.Format("KeyCode: {0}, KeyValue: {1}", e.KeyCode.ToString(), e.KeyValue);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtKeyboard_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "PreviewKeyDown";
            string eventText = String.Format("KeyCode: {0}, KeyValue: {1}", e.KeyCode.ToString(), e.KeyValue);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtKeyboard_TextChanged(object sender, EventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "TextChanged";
            string eventText = String.Format("Text changed to: {0}", txtKeyboard.Text);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtMouse_MouseDown(object sender, MouseEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseDown";
            string mouseBtn = GetClickedMouse(e);

            string eventText = String.Format("Mouse down: {0}", mouseBtn);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtMouse_MouseEnter(object sender, EventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseEnter";
            string eventText = "";
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtMouse_MouseHover(object sender, EventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseHover";
            string eventText = "";
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtMouse_MouseLeave(object sender, EventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseLeave";
            string eventText = "";
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtMouse_MouseUp(object sender, MouseEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseUp";
            string mouseBtn = GetClickedMouse(e);

            string eventText = String.Format("Mouse released: {0}", mouseBtn);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtMouse_MouseClick(object sender, MouseEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseClick";
            string mouseBtn = GetClickedMouse(e);

            string eventText = String.Format("Mouse clicked: {0}", mouseBtn);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtMouse_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseDoubleClick";
            string mouseBtn = GetClickedMouse(e);

            string eventText = String.Format("Mouse double clicked: {0}", mouseBtn);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void txtMouse_MouseCaptureChanged(object sender, EventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseCaptureChanged";
            string eventText = "";
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void btnClickMe_MouseClick(object sender, MouseEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseClick";
            string mouseBtn = GetClickedMouse(e);

            string eventText = String.Format("Mouse clicked: {0}", mouseBtn);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void btnClickMe_MouseCaptureChanged(object sender, EventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseCaptureChanged";
            string eventText = "";
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void btnClickMe_MouseDown(object sender, MouseEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseDown";
            string mouseBtn = GetClickedMouse(e);

            string eventText = String.Format("Mouse down: {0}", mouseBtn);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void btnClickMe_MouseEnter(object sender, EventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseEnter";
            string eventText = "";
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void btnClickMe_MouseHover(object sender, EventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseHover";
            string eventText = "";
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void btnClickMe_MouseLeave(object sender, EventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseLeave";
            string eventText = "";
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private void btnClickMe_MouseUp(object sender, MouseEventArgs e)
        {
            //Prepare params
            string controlName = ((Control)sender).Name;
            string eventName = "MouseUp";
            string mouseBtn = GetClickedMouse(e);

            string eventText = String.Format("Mouse released: {0}", mouseBtn);
            InteractionInfoEventArgs interactInfo = new InteractionInfoEventArgs(controlName, eventName, eventText);

            //Raise event
            OnInteractionOccured(sender, interactInfo);
        }

        private string GetClickedMouse(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                return "Left Mouse";
            }
            else if (e.Button == MouseButtons.Right)
            {
                return "Right Mouse";
            }
            else
            {
                return "Middle Mouse";
            }
        }
    }
}