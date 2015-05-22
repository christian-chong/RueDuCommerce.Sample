using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views
{
    public partial class BaseUserControl : UserControl
    {
        public BaseUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Invoke the delegate on winform thread
        /// </summary>
        /// <param name="code">The code.</param>
        public void CrossThreadCall(MethodInvoker code)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(code);
            }
            else
            {
                code.Invoke();
            }
        }

    }
}
