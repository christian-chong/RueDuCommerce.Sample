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
    public partial class DealRemove : BaseUserControl, IBaseView
    {
        public Deal Deal { get; set; }
        public DealRemove()
        {
            InitializeComponent();
        }
      
        public void Prepare()
        {
            dealBindingSource.DataSource = Deal;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            dealBindingSource.EndEdit();
            ServiceLocator.Instance().DealService.Remove(Deal.Id);

            ParentForm.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

    }
}
