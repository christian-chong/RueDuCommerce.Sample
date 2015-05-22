using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;

namespace UI.Views
{
    public partial class DealDetail : BaseUserControl, IBaseView
    {

        public Deal Deal { get; set; }

        public DealDetail()
        {
            InitializeComponent();
        }

        public void Prepare()
        {
            bindingSource.DataSource = Deal;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            ServiceLocator.Instance().DealService.Add((Deal)bindingSource.DataSource);
            ParentForm.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void textBoxReference_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
