using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Views;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openDealsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DealList maDealList = new DealList();

            OpenForm(maDealList, false);
        }


        public void OpenForm(Control control, bool modal )
        {
            var form = new Form();
            form.Controls.Add(control);
            form.ClientSize = control.Size;
            form.StartPosition = FormStartPosition.CenterParent;
            control.Dock = DockStyle.Fill;
           


            if (control is IBaseView)
            {
                ((IBaseView)control).Prepare();
            }

            if (modal)
            {
                using (form)
                {
                    form.ShowDialog(this);
                }
            }
            else
            {
                form.MdiParent = this;
                form.Show();
            }

        }

    }
}
