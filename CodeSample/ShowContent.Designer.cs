namespace CodeSample
{
    partial class ShowContent
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
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbProblem = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbContent.ForeColor = System.Drawing.SystemColors.Info;
            this.rtbContent.Location = new System.Drawing.Point(18, 139);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtbContent.Size = new System.Drawing.Size(1091, 437);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Problem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Edit:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(995, 594);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 32);
            this.lbDate.TabIndex = 4;
            // 
            // lbProblem
            // 
            this.lbProblem.AutoSize = true;
            this.lbProblem.Location = new System.Drawing.Point(159, 46);
            this.lbProblem.Name = "lbProblem";
            this.lbProblem.Size = new System.Drawing.Size(0, 32);
            this.lbProblem.TabIndex = 5;
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Location = new System.Drawing.Point(1079, 20);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(0, 32);
            this.lbTopic.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(24, 589);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Black;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(995, 35);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(114, 43);
            this.btEdit.TabIndex = 8;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // ShowContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1163, 660);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.lbProblem);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbContent);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ShowContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowContent";
            this.Load += new System.EventHandler(this.ShowContent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbProblem;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btEdit;
    }
}