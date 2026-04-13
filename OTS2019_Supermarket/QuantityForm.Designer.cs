namespace OTS_Supermarket
{
    partial class QuantityForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.rbtnAddMultiptle = new System.Windows.Forms.RadioButton();
            this.rbtnAddOne = new System.Windows.Forms.RadioButton();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.gboxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(31, 31);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(35, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "label1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(215, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gboxOptions
            // 
            this.gboxOptions.Controls.Add(this.rbtnAddMultiptle);
            this.gboxOptions.Controls.Add(this.rbtnAddOne);
            this.gboxOptions.Location = new System.Drawing.Point(34, 47);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(153, 63);
            this.gboxOptions.TabIndex = 2;
            this.gboxOptions.TabStop = false;
            this.gboxOptions.Text = "Choose Option";
            // 
            // rbtnAddMultiptle
            // 
            this.rbtnAddMultiptle.AutoSize = true;
            this.rbtnAddMultiptle.Location = new System.Drawing.Point(6, 40);
            this.rbtnAddMultiptle.Name = "rbtnAddMultiptle";
            this.rbtnAddMultiptle.Size = new System.Drawing.Size(111, 17);
            this.rbtnAddMultiptle.TabIndex = 1;
            this.rbtnAddMultiptle.TabStop = true;
            this.rbtnAddMultiptle.Text = "Add Multiple Items";
            this.rbtnAddMultiptle.UseVisualStyleBackColor = true;
            this.rbtnAddMultiptle.CheckedChanged += new System.EventHandler(this.rbtnAddMultiptle_CheckedChanged);
            // 
            // rbtnAddOne
            // 
            this.rbtnAddOne.AutoSize = true;
            this.rbtnAddOne.Location = new System.Drawing.Point(6, 19);
            this.rbtnAddOne.Name = "rbtnAddOne";
            this.rbtnAddOne.Size = new System.Drawing.Size(89, 17);
            this.rbtnAddOne.TabIndex = 0;
            this.rbtnAddOne.TabStop = true;
            this.rbtnAddOne.Text = "Add One item";
            this.rbtnAddOne.UseVisualStyleBackColor = true;
            this.rbtnAddOne.CheckedChanged += new System.EventHandler(this.rbtnAddOne_CheckedChanged);
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(34, 123);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(153, 20);
            this.tbxInput.TabIndex = 3;
            // 
            // QuantityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 275);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblQuantity);
            this.Name = "QuantityForm";
            this.Text = "QuantityForm";
            this.Load += new System.EventHandler(this.QuantityForm_Load);
            this.gboxOptions.ResumeLayout(false);
            this.gboxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gboxOptions;
        private System.Windows.Forms.RadioButton rbtnAddMultiptle;
        private System.Windows.Forms.RadioButton rbtnAddOne;
        private System.Windows.Forms.TextBox tbxInput;
    }
}