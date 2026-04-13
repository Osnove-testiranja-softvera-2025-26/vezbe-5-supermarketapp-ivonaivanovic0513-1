namespace OTS_Supermarket
{
    partial class Form1
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.gboxButtons = new System.Windows.Forms.GroupBox();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.btnChair = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.gboxActions = new System.Windows.Forms.GroupBox();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.tbxBudget = new System.Windows.Forms.TextBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gboxButtons.SuspendLayout();
            this.gboxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(22, 157);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(90, 20);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Add to Cart";
            // 
            // gboxButtons
            // 
            this.gboxButtons.Controls.Add(this.btnComputer);
            this.gboxButtons.Controls.Add(this.btnLaptop);
            this.gboxButtons.Controls.Add(this.btnChair);
            this.gboxButtons.Controls.Add(this.btnMonitor);
            this.gboxButtons.Controls.Add(this.btnKeyboard);
            this.gboxButtons.Location = new System.Drawing.Point(18, 182);
            this.gboxButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxButtons.Name = "gboxButtons";
            this.gboxButtons.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxButtons.Size = new System.Drawing.Size(153, 422);
            this.gboxButtons.TabIndex = 1;
            this.gboxButtons.TabStop = false;
            this.gboxButtons.Text = "Items:";
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(9, 188);
            this.btnComputer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(112, 62);
            this.btnComputer.TabIndex = 3;
            this.btnComputer.Text = "Computer";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.Location = new System.Drawing.Point(9, 258);
            this.btnLaptop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(112, 62);
            this.btnLaptop.TabIndex = 2;
            this.btnLaptop.Text = "Lap top";
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.btnLaptop_Click);
            // 
            // btnChair
            // 
            this.btnChair.Location = new System.Drawing.Point(9, 329);
            this.btnChair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChair.Name = "btnChair";
            this.btnChair.Size = new System.Drawing.Size(112, 62);
            this.btnChair.TabIndex = 4;
            this.btnChair.Text = "Computer chair";
            this.btnChair.UseVisualStyleBackColor = true;
            this.btnChair.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(9, 46);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(112, 62);
            this.btnMonitor.TabIndex = 1;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.Location = new System.Drawing.Point(9, 117);
            this.btnKeyboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(112, 62);
            this.btnKeyboard.TabIndex = 0;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = true;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // gboxActions
            // 
            this.gboxActions.Controls.Add(this.tbxDate);
            this.gboxActions.Controls.Add(this.lblDelivery);
            this.gboxActions.Controls.Add(this.btnCalculate);
            this.gboxActions.Controls.Add(this.btnPrint);
            this.gboxActions.Controls.Add(this.btnRestore);
            this.gboxActions.Location = new System.Drawing.Point(224, 182);
            this.gboxActions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxActions.Name = "gboxActions";
            this.gboxActions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gboxActions.Size = new System.Drawing.Size(375, 197);
            this.gboxActions.TabIndex = 5;
            this.gboxActions.TabStop = false;
            this.gboxActions.Text = "Actions:";
            // 
            // tbxDate
            // 
            this.tbxDate.Location = new System.Drawing.Point(9, 157);
            this.tbxDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(331, 26);
            this.tbxDate.TabIndex = 7;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(9, 118);
            this.lblDelivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(161, 20);
            this.lblDelivery.TabIndex = 6;
            this.lblDelivery.Text = "Pick date for  delivery ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(9, 29);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 62);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(123, 29);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 62);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print items";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(237, 29);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(105, 62);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore cart";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(200, 388);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(397, 213);
            this.rtbOutput.TabIndex = 6;
            this.rtbOutput.Text = "";
            // 
            // tbxBudget
            // 
            this.tbxBudget.Location = new System.Drawing.Point(27, 82);
            this.tbxBudget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxBudget.Name = "tbxBudget";
            this.tbxBudget.Size = new System.Drawing.Size(372, 26);
            this.tbxBudget.TabIndex = 7;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(27, 52);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(200, 20);
            this.lblBudget.TabIndex = 8;
            this.lblBudget.Text = "Enter your shoping budget:";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(432, 78);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 35);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 622);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.tbxBudget);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.gboxActions);
            this.Controls.Add(this.gboxButtons);
            this.Controls.Add(this.lblAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxButtons.ResumeLayout(false);
            this.gboxActions.ResumeLayout(false);
            this.gboxActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.GroupBox gboxButtons;
        private System.Windows.Forms.Button btnChair;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnLaptop;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.GroupBox gboxActions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.TextBox tbxBudget;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.RichTextBox rtbOutput;
    }
}

