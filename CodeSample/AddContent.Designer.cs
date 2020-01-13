namespace CodeSample
{
    partial class AddContent
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
            this.rtbContentText = new System.Windows.Forms.RichTextBox();
            this.lbTopic = new System.Windows.Forms.Label();
            this.lbProblem = new System.Windows.Forms.Label();
            this.lbContentText = new System.Windows.Forms.Label();
            this.rtbProblem = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbTopic = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbContentText
            // 
            this.rtbContentText.AcceptsTab = true;
            this.rtbContentText.AutoWordSelection = true;
            this.rtbContentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbContentText.Location = new System.Drawing.Point(265, 177);
            this.rtbContentText.Name = "rtbContentText";
            this.rtbContentText.Size = new System.Drawing.Size(1037, 371);
            this.rtbContentText.TabIndex = 0;
            this.rtbContentText.Text = "";
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTopic.Location = new System.Drawing.Point(43, 9);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(85, 32);
            this.lbTopic.TabIndex = 1;
            this.lbTopic.Text = "Topic";
            // 
            // lbProblem
            // 
            this.lbProblem.AutoSize = true;
            this.lbProblem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProblem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbProblem.Location = new System.Drawing.Point(43, 84);
            this.lbProblem.Name = "lbProblem";
            this.lbProblem.Size = new System.Drawing.Size(121, 32);
            this.lbProblem.TabIndex = 2;
            this.lbProblem.Text = "Problem";
            // 
            // lbContentText
            // 
            this.lbContentText.AutoSize = true;
            this.lbContentText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbContentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContentText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbContentText.Location = new System.Drawing.Point(43, 177);
            this.lbContentText.Name = "lbContentText";
            this.lbContentText.Size = new System.Drawing.Size(177, 32);
            this.lbContentText.TabIndex = 3;
            this.lbContentText.Text = "Content Text";
            // 
            // rtbProblem
            // 
            this.rtbProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbProblem.Location = new System.Drawing.Point(265, 81);
            this.rtbProblem.Name = "rtbProblem";
            this.rtbProblem.Size = new System.Drawing.Size(963, 67);
            this.rtbProblem.TabIndex = 5;
            this.rtbProblem.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1234, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 60);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTopic
            // 
            this.cbTopic.FormattingEnabled = true;
            this.cbTopic.Location = new System.Drawing.Point(265, 9);
            this.cbTopic.Name = "cbTopic";
            this.cbTopic.Size = new System.Drawing.Size(121, 24);
            this.cbTopic.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(-8, 498);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(136, 61);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1337, 560);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbTopic);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbProblem);
            this.Controls.Add(this.lbContentText);
            this.Controls.Add(this.lbProblem);
            this.Controls.Add(this.lbTopic);
            this.Controls.Add(this.rtbContentText);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddContent";
            this.Text = "Code Guild";
            this.Load += new System.EventHandler(this.AddContent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContentText;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.Label lbProblem;
        private System.Windows.Forms.Label lbContentText;
        private System.Windows.Forms.RichTextBox rtbProblem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbTopic;
        private System.Windows.Forms.Button btnBack;
    }
}

