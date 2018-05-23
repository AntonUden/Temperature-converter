namespace Temperature
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
            this.toCelcius = new System.Windows.Forms.RadioButton();
            this.toFahrenheit = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toCelcius
            // 
            this.toCelcius.AutoSize = true;
            this.toCelcius.Location = new System.Drawing.Point(12, 51);
            this.toCelcius.Name = "toCelcius";
            this.toCelcius.Size = new System.Drawing.Size(52, 17);
            this.toCelcius.TabIndex = 0;
            this.toCelcius.TabStop = true;
            this.toCelcius.Text = "To °C";
            this.toCelcius.UseVisualStyleBackColor = true;
            this.toCelcius.CheckedChanged += new System.EventHandler(this.toCelcius_CheckedChanged);
            // 
            // toFahrenheit
            // 
            this.toFahrenheit.AutoSize = true;
            this.toFahrenheit.Location = new System.Drawing.Point(70, 51);
            this.toFahrenheit.Name = "toFahrenheit";
            this.toFahrenheit.Size = new System.Drawing.Size(51, 17);
            this.toFahrenheit.TabIndex = 1;
            this.toFahrenheit.TabStop = true;
            this.toFahrenheit.Text = "To °F";
            this.toFahrenheit.UseVisualStyleBackColor = true;
            this.toFahrenheit.CheckedChanged += new System.EventHandler(this.toFahrenheit_CheckedChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(12, 71);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(79, 13);
            this.output.TabIndex = 2;
            this.output.Text = "Temperature: ?";
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Location = new System.Drawing.Point(12, 25);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(299, 20);
            this.input.TabIndex = 3;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(92, 13);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Temperature in °C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 104);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.input);
            this.Controls.Add(this.output);
            this.Controls.Add(this.toFahrenheit);
            this.Controls.Add(this.toCelcius);
            this.MaximumSize = new System.Drawing.Size(339, 143);
            this.MinimumSize = new System.Drawing.Size(339, 143);
            this.Name = "Form1";
            this.Text = "Temperature converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton toCelcius;
        private System.Windows.Forms.RadioButton toFahrenheit;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label infoLabel;
    }
}

