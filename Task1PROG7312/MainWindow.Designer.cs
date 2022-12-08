namespace Task1PROG7312
{
    partial class MainWindow
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
            this.button3 = new System.Windows.Forms.Button();
            this.idAreaBtn = new System.Windows.Forms.Button();
            this.rpBooksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(580, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 92);
            this.button3.TabIndex = 5;
            this.button3.Text = "Finding call numbers";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // idAreaBtn
            // 
            this.idAreaBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.idAreaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAreaBtn.Location = new System.Drawing.Point(339, 179);
            this.idAreaBtn.Name = "idAreaBtn";
            this.idAreaBtn.Size = new System.Drawing.Size(122, 92);
            this.idAreaBtn.TabIndex = 4;
            this.idAreaBtn.Text = "Identifying areas";
            this.idAreaBtn.UseVisualStyleBackColor = false;
            this.idAreaBtn.Click += new System.EventHandler(this.idAreaBtn_Click);
            // 
            // rpBooksBtn
            // 
            this.rpBooksBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rpBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpBooksBtn.Location = new System.Drawing.Point(99, 179);
            this.rpBooksBtn.Name = "rpBooksBtn";
            this.rpBooksBtn.Size = new System.Drawing.Size(122, 92);
            this.rpBooksBtn.TabIndex = 3;
            this.rpBooksBtn.Text = "Replacing books";
            this.rpBooksBtn.UseVisualStyleBackColor = false;
            this.rpBooksBtn.Click += new System.EventHandler(this.rpBooksBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(847, 519);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.idAreaBtn);
            this.Controls.Add(this.rpBooksBtn);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button idAreaBtn;
        private System.Windows.Forms.Button rpBooksBtn;
    }
}