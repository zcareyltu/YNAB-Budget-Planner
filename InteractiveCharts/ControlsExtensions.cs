﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace InteractiveCharts {
    internal static class ControlsExtensions {

        /// <summary>
        /// Executes the Action asynchronously on the UI thread, does not block execution on the calling thread.
        /// </summary>
        /// <param name="control">the control for which the update is required</param>
        /// <param name="action">action to be performed on the control</param>
        internal static void InvokeOnUiThreadIfRequired(this Control control, Action action) {
            //If you are planning on using a similar function in your own code then please be sure to
            //have a quick read over https://stackoverflow.com/questions/1874728/avoid-calling-invoke-when-the-control-is-disposed
            //No action
            if (control.Disposing || control.IsDisposed || !control.IsHandleCreated) {
                return;
            }

            if (control.InvokeRequired) {
                control.BeginInvoke(action);
            } else {
                action.Invoke();
            }
        }

    }
}
