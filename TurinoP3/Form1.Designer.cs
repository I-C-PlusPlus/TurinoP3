namespace TurinoP3
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
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblNumberOfItems = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtNumberOfItems = new System.Windows.Forms.TextBox();
            this.gbItemType = new System.Windows.Forms.GroupBox();
            this.lblTextToEngrave = new System.Windows.Forms.Label();
            this.txtTextToEngrave = new System.Windows.Forms.TextBox();
            this.cbLogo = new System.Windows.Forms.CheckBox();
            this.lblNumberOfColors = new System.Windows.Forms.Label();
            this.txtNumberOfColors = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOrderSummary = new System.Windows.Forms.TextBox();
            this.rbUSB = new System.Windows.Forms.RadioButton();
            this.rbMug = new System.Windows.Forms.RadioButton();
            this.rbPen = new System.Windows.Forms.RadioButton();
            this.gbItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(33, 13);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(92, 16);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number";
            // 
            // lblNumberOfItems
            // 
            this.lblNumberOfItems.AutoSize = true;
            this.lblNumberOfItems.Location = new System.Drawing.Point(36, 51);
            this.lblNumberOfItems.Name = "lblNumberOfItems";
            this.lblNumberOfItems.Size = new System.Drawing.Size(104, 16);
            this.lblNumberOfItems.TabIndex = 1;
            this.lblNumberOfItems.Text = "Number of items";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(146, 7);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(200, 22);
            this.txtOrderNumber.TabIndex = 2;
            // 
            // txtNumberOfItems
            // 
            this.txtNumberOfItems.Location = new System.Drawing.Point(146, 45);
            this.txtNumberOfItems.Name = "txtNumberOfItems";
            this.txtNumberOfItems.Size = new System.Drawing.Size(200, 22);
            this.txtNumberOfItems.TabIndex = 3;
            // 
            // gbItemType
            // 
            this.gbItemType.Controls.Add(this.rbPen);
            this.gbItemType.Controls.Add(this.rbMug);
            this.gbItemType.Controls.Add(this.rbUSB);
            this.gbItemType.Location = new System.Drawing.Point(146, 86);
            this.gbItemType.Name = "gbItemType";
            this.gbItemType.Size = new System.Drawing.Size(200, 100);
            this.gbItemType.TabIndex = 4;
            this.gbItemType.TabStop = false;
            this.gbItemType.Text = "Item Type";
            // 
            // lblTextToEngrave
            // 
            this.lblTextToEngrave.AutoSize = true;
            this.lblTextToEngrave.Location = new System.Drawing.Point(39, 188);
            this.lblTextToEngrave.Name = "lblTextToEngrave";
            this.lblTextToEngrave.Size = new System.Drawing.Size(132, 16);
            this.lblTextToEngrave.TabIndex = 5;
            this.lblTextToEngrave.Text = "Text to engrave/print:";
            // 
            // txtTextToEngrave
            // 
            this.txtTextToEngrave.Location = new System.Drawing.Point(39, 208);
            this.txtTextToEngrave.Multiline = true;
            this.txtTextToEngrave.Name = "txtTextToEngrave";
            this.txtTextToEngrave.Size = new System.Drawing.Size(280, 49);
            this.txtTextToEngrave.TabIndex = 6;
            // 
            // cbLogo
            // 
            this.cbLogo.AutoSize = true;
            this.cbLogo.Location = new System.Drawing.Point(119, 264);
            this.cbLogo.Name = "cbLogo";
            this.cbLogo.Size = new System.Drawing.Size(67, 20);
            this.cbLogo.TabIndex = 7;
            this.cbLogo.Text = "Logo?";
            this.cbLogo.UseVisualStyleBackColor = true;
            this.cbLogo.CheckedChanged += new System.EventHandler(this.cbLogo_CheckedChanged);
            // 
            // lblNumberOfColors
            // 
            this.lblNumberOfColors.AutoSize = true;
            this.lblNumberOfColors.Location = new System.Drawing.Point(39, 298);
            this.lblNumberOfColors.Name = "lblNumberOfColors";
            this.lblNumberOfColors.Size = new System.Drawing.Size(109, 16);
            this.lblNumberOfColors.TabIndex = 8;
            this.lblNumberOfColors.Text = "Number of colors";
            // 
            // txtNumberOfColors
            // 
            this.txtNumberOfColors.Location = new System.Drawing.Point(154, 295);
            this.txtNumberOfColors.Name = "txtNumberOfColors";
            this.txtNumberOfColors.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfColors.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(36, 355);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(163, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOrderSummary
            // 
            this.txtOrderSummary.Location = new System.Drawing.Point(36, 395);
            this.txtOrderSummary.Multiline = true;
            this.txtOrderSummary.Name = "txtOrderSummary";
            this.txtOrderSummary.Size = new System.Drawing.Size(370, 89);
            this.txtOrderSummary.TabIndex = 12;
            // 
            // rbUSB
            // 
            this.rbUSB.AutoSize = true;
            this.rbUSB.Location = new System.Drawing.Point(7, 22);
            this.rbUSB.Name = "rbUSB";
            this.rbUSB.Size = new System.Drawing.Size(56, 20);
            this.rbUSB.TabIndex = 0;
            this.rbUSB.TabStop = true;
            this.rbUSB.Text = "USB";
            this.rbUSB.UseVisualStyleBackColor = true;
            // 
            // rbMug
            // 
            this.rbMug.AutoSize = true;
            this.rbMug.Location = new System.Drawing.Point(7, 49);
            this.rbMug.Name = "rbMug";
            this.rbMug.Size = new System.Drawing.Size(54, 20);
            this.rbMug.TabIndex = 1;
            this.rbMug.TabStop = true;
            this.rbMug.Text = "Mug";
            this.rbMug.UseVisualStyleBackColor = true;
            // 
            // rbPen
            // 
            this.rbPen.AutoSize = true;
            this.rbPen.Location = new System.Drawing.Point(7, 76);
            this.rbPen.Name = "rbPen";
            this.rbPen.Size = new System.Drawing.Size(52, 20);
            this.rbPen.TabIndex = 2;
            this.rbPen.TabStop = true;
            this.rbPen.Text = "Pen";
            this.rbPen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 594);
            this.Controls.Add(this.txtOrderSummary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNumberOfColors);
            this.Controls.Add(this.lblNumberOfColors);
            this.Controls.Add(this.cbLogo);
            this.Controls.Add(this.txtTextToEngrave);
            this.Controls.Add(this.lblTextToEngrave);
            this.Controls.Add(this.gbItemType);
            this.Controls.Add(this.txtNumberOfItems);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.lblNumberOfItems);
            this.Controls.Add(this.lblOrderNumber);
            this.Name = "Form1";
            this.Text = "Logo Items Order";
            this.gbItemType.ResumeLayout(false);
            this.gbItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblNumberOfItems;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtNumberOfItems;
        private System.Windows.Forms.GroupBox gbItemType;
        private System.Windows.Forms.Label lblTextToEngrave;
        private System.Windows.Forms.TextBox txtTextToEngrave;
        private System.Windows.Forms.CheckBox cbLogo;
        private System.Windows.Forms.Label lblNumberOfColors;
        private System.Windows.Forms.TextBox txtNumberOfColors;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOrderSummary;
        private System.Windows.Forms.RadioButton rbPen;
        private System.Windows.Forms.RadioButton rbMug;
        private System.Windows.Forms.RadioButton rbUSB;
    }
}

