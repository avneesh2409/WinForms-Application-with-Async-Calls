
namespace WindowsFormsApp1
{
    partial class ApiDemo
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
            this.Prev = new System.Windows.Forms.Button();
            this.LoadImageAsync = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.TextBox();
            this.Transcript = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Prev
            // 
            this.Prev.Location = new System.Drawing.Point(75, 45);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(154, 48);
            this.Prev.TabIndex = 0;
            this.Prev.Text = "Prev";
            this.Prev.UseVisualStyleBackColor = true;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // LoadImageAsync
            // 
            this.LoadImageAsync.Location = new System.Drawing.Point(289, 45);
            this.LoadImageAsync.Name = "LoadImageAsync";
            this.LoadImageAsync.Size = new System.Drawing.Size(164, 49);
            this.LoadImageAsync.TabIndex = 1;
            this.LoadImageAsync.Text = "LoadImageAsync";
            this.LoadImageAsync.UseVisualStyleBackColor = true;
            this.LoadImageAsync.Click += new System.EventHandler(this.LoadImageAsync_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(522, 44);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(167, 49);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(167, 70);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(277, 178);
            this.ImageBox.TabIndex = 3;
            this.ImageBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.ImageBox);
            this.panel1.Location = new System.Drawing.Point(75, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 261);
            this.panel1.TabIndex = 4;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(113, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(484, 22);
            this.Title.TabIndex = 0;
            // 
            // Transcript
            // 
            this.Transcript.Location = new System.Drawing.Point(205, 117);
            this.Transcript.Name = "Transcript";
            this.Transcript.Size = new System.Drawing.Size(484, 22);
            this.Transcript.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transcript";
            // 
            // ApiDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transcript);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.LoadImageAsync);
            this.Controls.Add(this.Prev);
            this.Name = "ApiDemo";
            this.Text = "ApiDemo";
            this.Load += new System.EventHandler(this.ApiDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button LoadImageAsync;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Transcript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}