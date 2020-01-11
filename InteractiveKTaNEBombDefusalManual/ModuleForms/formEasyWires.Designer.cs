namespace InteractiveKTaNEBombDefusalManual.ModuleForms
{
    partial class FormEasyWires
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RichEasyWires = new System.Windows.Forms.RichTextBox();
            this.FocusLabel = new System.Windows.Forms.Label();
            this.EpigraphBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InteractiveKTaNEBombDefusalManual.Properties.Resources.easyWires;
            this.pictureBox1.Location = new System.Drawing.Point(613, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RichEasyWires
            // 
            this.RichEasyWires.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichEasyWires.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichEasyWires.Location = new System.Drawing.Point(12, 12);
            this.RichEasyWires.Name = "RichEasyWires";
            this.RichEasyWires.ReadOnly = true;
            this.RichEasyWires.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RichEasyWires.Size = new System.Drawing.Size(595, 561);
            this.RichEasyWires.TabIndex = 3;
            this.RichEasyWires.Text = "";
            this.RichEasyWires.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.RichEasyWires_ContentsResized);
            this.RichEasyWires.Enter += new System.EventHandler(this.RichEasyWires_Enter);
            this.RichEasyWires.Leave += new System.EventHandler(this.RichEasyWires_Leave);
            // 
            // FocusLabel
            // 
            this.FocusLabel.AutoSize = true;
            this.FocusLabel.Location = new System.Drawing.Point(788, 560);
            this.FocusLabel.Name = "FocusLabel";
            this.FocusLabel.Size = new System.Drawing.Size(0, 13);
            this.FocusLabel.TabIndex = 4;
            // 
            // EpigraphBox
            // 
            this.EpigraphBox.BackColor = System.Drawing.SystemColors.Control;
            this.EpigraphBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EpigraphBox.Location = new System.Drawing.Point(613, 193);
            this.EpigraphBox.Name = "EpigraphBox";
            this.EpigraphBox.Size = new System.Drawing.Size(175, 364);
            this.EpigraphBox.TabIndex = 6;
            this.EpigraphBox.Text = "";
            // 
            // FormEasyWires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.EpigraphBox);
            this.Controls.Add(this.FocusLabel);
            this.Controls.Add(this.RichEasyWires);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEasyWires";
            this.Text = "FormEasyWires";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEasyWires_FormClosing);
            this.Load += new System.EventHandler(this.FormEasyWires_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox RichEasyWires;
        private System.Windows.Forms.Label FocusLabel;
        private System.Windows.Forms.RichTextBox EpigraphBox;
    }
}