namespace UI.Views
{
    partial class DealDetail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.baseUserControl1 = new UI.Views.BaseUserControl();
            this.baseUserControl2 = new UI.Views.BaseUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Amount", true));
            this.textBoxAmount.Location = new System.Drawing.Point(22, 16);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(179, 20);
            this.textBoxAmount.TabIndex = 0;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Business.Entities.Deal);
            // 
            // textBoxReference
            // 
            this.textBoxReference.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Reference", true));
            this.textBoxReference.Location = new System.Drawing.Point(22, 49);
            this.textBoxReference.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.Size = new System.Drawing.Size(179, 20);
            this.textBoxReference.TabIndex = 1;
            this.textBoxReference.TextChanged += new System.EventHandler(this.textBoxReference_TextChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(149, 79);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(50, 15);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(95, 79);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 15);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // baseUserControl1
            // 
            this.baseUserControl1.Location = new System.Drawing.Point(0, 0);
            this.baseUserControl1.Name = "baseUserControl1";
            this.baseUserControl1.Size = new System.Drawing.Size(18, 16);
            this.baseUserControl1.TabIndex = 5;
            // 
            // baseUserControl2
            // 
            this.baseUserControl2.Location = new System.Drawing.Point(0, 0);
            this.baseUserControl2.Name = "baseUserControl2";
            this.baseUserControl2.Size = new System.Drawing.Size(18, 16);
            this.baseUserControl2.TabIndex = 7;
            // 
            // DealDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseUserControl2);
            this.Controls.Add(this.baseUserControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxReference);
            this.Controls.Add(this.textBoxAmount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DealDetail";
            this.Size = new System.Drawing.Size(216, 113);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private BaseUserControl baseUserControl1;
        private BaseUserControl baseUserControl2;
    }
}
