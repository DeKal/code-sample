namespace CodeSample
{
    partial class ShowTopic
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
            this.lbTopic = new System.Windows.Forms.Label();
            this.lBxProblem = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopic.Location = new System.Drawing.Point(29, 22);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(124, 38);
            this.lbTopic.TabIndex = 0;
            this.lbTopic.Text = "Topic  :";
            this.lbTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBxProblem
            // 
            this.lBxProblem.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lBxProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBxProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBxProblem.ForeColor = System.Drawing.SystemColors.Menu;
            this.lBxProblem.FormattingEnabled = true;
            this.lBxProblem.HorizontalScrollbar = true;
            this.lBxProblem.ItemHeight = 25;
            this.lBxProblem.Location = new System.Drawing.Point(37, 82);
            this.lBxProblem.Name = "lBxProblem";
            this.lBxProblem.Size = new System.Drawing.Size(1077, 475);
            this.lBxProblem.TabIndex = 1;
            this.lBxProblem.SelectedIndexChanged += new System.EventHandler(this.lBxProblem_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(974, 565);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 51);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ShowTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1144, 639);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lBxProblem);
            this.Controls.Add(this.lbTopic);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowTopic";
            this.Load += new System.EventHandler(this.ShowTopic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.ListBox lBxProblem;
        private System.Windows.Forms.Button btnBack;
    }
}