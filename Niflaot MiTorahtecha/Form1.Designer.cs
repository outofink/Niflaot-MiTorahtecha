namespace Niflaot_MiTorahtecha
{
    partial class mainWindow
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
            this.gregBox = new System.Windows.Forms.CheckBox();
            this.lateBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.NumericUpDown();
            this.goButton = new System.Windows.Forms.Button();
            this.locationText = new System.Windows.Forms.Label();
            this.pasukText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).BeginInit();
            this.SuspendLayout();
            // 
            // gregBox
            // 
            this.gregBox.AutoSize = true;
            this.gregBox.Location = new System.Drawing.Point(120, 12);
            this.gregBox.Name = "gregBox";
            this.gregBox.Size = new System.Drawing.Size(97, 17);
            this.gregBox.TabIndex = 0;
            this.gregBox.Text = "Gregorian Year";
            this.gregBox.UseVisualStyleBackColor = true;
            this.gregBox.CheckedChanged += new System.EventHandler(this.gregBox_CheckedChanged);
            // 
            // lateBox
            // 
            this.lateBox.AutoSize = true;
            this.lateBox.Enabled = false;
            this.lateBox.Location = new System.Drawing.Point(120, 35);
            this.lateBox.Name = "lateBox";
            this.lateBox.Size = new System.Drawing.Size(130, 17);
            this.lateBox.TabIndex = 1;
            this.lateBox.Text = "After Rosh HaShanah";
            this.lateBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year:";
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(50, 20);
            this.yearInput.Maximum = new decimal(new int[] {
            5888,
            0,
            0,
            0});
            this.yearInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(52, 20);
            this.yearInput.TabIndex = 4;
            this.yearInput.Value = new decimal(new int[] {
            5776,
            0,
            0,
            0});
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(297, 58);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 5;
            this.goButton.Text = " Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // locationText
            // 
            this.locationText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationText.Location = new System.Drawing.Point(40, 84);
            this.locationText.Margin = new System.Windows.Forms.Padding(0);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(300, 45);
            this.locationText.TabIndex = 6;
            this.locationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pasukText
            // 
            this.pasukText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pasukText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasukText.Location = new System.Drawing.Point(40, 129);
            this.pasukText.Margin = new System.Windows.Forms.Padding(0);
            this.pasukText.Name = "pasukText";
            this.pasukText.Size = new System.Drawing.Size(300, 100);
            this.pasukText.TabIndex = 7;
            this.pasukText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 238);
            this.Controls.Add(this.pasukText);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.yearInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lateBox);
            this.Controls.Add(this.gregBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Text = "Niflaot MiTorahtecha";
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox gregBox;
        private System.Windows.Forms.CheckBox lateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown yearInput;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label locationText;
        private System.Windows.Forms.Label pasukText;
    }
}

