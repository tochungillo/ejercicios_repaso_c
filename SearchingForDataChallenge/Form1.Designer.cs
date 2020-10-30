namespace SearchingForDataChallenge
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
            this.match = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linebox = new System.Windows.Forms.ListBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // match
            // 
            this.match.Location = new System.Drawing.Point(29, 136);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(222, 22);
            this.match.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Searching for data challenge";
            // 
            // linebox
            // 
            this.linebox.FormattingEnabled = true;
            this.linebox.ItemHeight = 16;
            this.linebox.Location = new System.Drawing.Point(371, 127);
            this.linebox.Name = "linebox";
            this.linebox.Size = new System.Drawing.Size(398, 276);
            this.linebox.TabIndex = 2;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(269, 136);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 3;
            this.searchbutton.Text = "search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.linebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.match);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox match;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox linebox;
        private System.Windows.Forms.Button searchbutton;
    }
}

