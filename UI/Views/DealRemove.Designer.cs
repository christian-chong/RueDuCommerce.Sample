namespace UI.Views
{
    partial class DealRemove
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.dealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(99, 78);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 32);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(153, 78);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(50, 32);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxReference
            // 
            this.textBoxReference.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealBindingSource, "Reference", true));
            this.textBoxReference.Location = new System.Drawing.Point(26, 52);
            this.textBoxReference.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.Size = new System.Drawing.Size(179, 20);
            this.textBoxReference.TabIndex = 5;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dealBindingSource, "Amount", true));
            this.textBoxAmount.Location = new System.Drawing.Point(26, 19);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(179, 20);
            this.textBoxAmount.TabIndex = 4;
            // 
            // dealBindingSource
            // 
            this.dealBindingSource.DataSource = typeof(Business.Entities.Deal);
            // 
            // DealRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxReference);
            this.Controls.Add(this.textBoxAmount);
            this.Name = "DealRemove";
            this.Size = new System.Drawing.Size(238, 116);
            ((System.ComponentModel.ISupportInitialize)(this.dealBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.BindingSource dealBindingSource;
    }
}
