
namespace WindowsFormsApp1
{
    partial class LoadMultipleApi
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
            this.LoadApiButton = new System.Windows.Forms.Button();
            this.RichTextBoxContainer = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LoadApiButton
            // 
            this.LoadApiButton.Location = new System.Drawing.Point(150, 36);
            this.LoadApiButton.Name = "LoadApiButton";
            this.LoadApiButton.Size = new System.Drawing.Size(443, 33);
            this.LoadApiButton.TabIndex = 0;
            this.LoadApiButton.Text = "Load Multiple Api Asynchronously";
            this.LoadApiButton.UseVisualStyleBackColor = true;
            this.LoadApiButton.Click += new System.EventHandler(this.LoadApiButton_Click);
            // 
            // RichTextBoxContainer
            // 
            this.RichTextBoxContainer.Location = new System.Drawing.Point(150, 132);
            this.RichTextBoxContainer.Name = "RichTextBoxContainer";
            this.RichTextBoxContainer.Size = new System.Drawing.Size(443, 285);
            this.RichTextBoxContainer.TabIndex = 1;
            this.RichTextBoxContainer.Text = "";
            // 
            // LoadMultipleApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBoxContainer);
            this.Controls.Add(this.LoadApiButton);
            this.Name = "LoadMultipleApi";
            this.Text = "LoadMultipleApi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadApiButton;
        private System.Windows.Forms.RichTextBox RichTextBoxContainer;
    }
}