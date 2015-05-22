using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Business.Entities;

namespace UI.Views
{
    public partial class DealList : BaseUserControl, IBaseView
    {
        public DealList()
        {
            InitializeComponent();
        }

        public void Prepare()
        {
            CrossThreadCall(() =>
            {


                bindingSource.DataSource = ServiceLocator.Instance().DealService.GetAll();
                //dataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                bindingSource.ResetBindings(false);
                dataGrid.DataSource = bindingSource.DataSource;
                dataGrid.Refresh();
            });


        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Deal deal = new Deal();
            DealDetail detail = new DealDetail();
            detail.Deal = deal;
            dataGrid.DataSource = "";
            dataGrid.Refresh();
            ServiceLocator.Instance().MainForm.OpenForm(detail,true);
            Prepare();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Deal deal = (Deal)bindingSource.Current;
            DealRemove dealRemove = new DealRemove();
            dealRemove.Deal = deal;

            dataGrid.DataSource = "";
            dataGrid.Refresh();
            
            ServiceLocator.Instance().MainForm.OpenForm(dealRemove, true);
            
            Prepare();

        }


       

    }
}
