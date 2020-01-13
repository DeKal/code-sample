namespace CodeSample
{
    partial class TopicModifier
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
            this.lbAllTOpic = new System.Windows.Forms.Label();
            this.lBxTOpic = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.AddTopic = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAllTOpic
            // 
            this.lbAllTOpic.AutoSize = true;
            this.lbAllTOpic.Font = new System.Drawing.Font("MS Reference Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllTOpic.ForeColor = System.Drawing.Color.White;
            this.lbAllTOpic.Location = new System.Drawing.Point(168, 22);
            this.lbAllTOpic.Name = "lbAllTOpic";
            this.lbAllTOpic.Size = new System.Drawing.Size(227, 53);
            this.lbAllTOpic.TabIndex = 0;
            this.lbAllTOpic.Text = "All Topics";
            // 
            // lBxTOpic
            // 
            this.lBxTOpic.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lBxTOpic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBxTOpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lBxTOpic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBxTOpic.ForeColor = System.Drawing.SystemColors.Window;
            this.lBxTOpic.FormattingEnabled = true;
            this.lBxTOpic.HorizontalScrollbar = true;
            this.lBxTOpic.ItemHeight = 36;
            this.lBxTOpic.Location = new System.Drawing.Point(82, 106);
            this.lBxTOpic.Name = "lBxTOpic";
            this.lBxTOpic.Size = new System.Drawing.Size(292, 216);
            this.lBxTOpic.Sorted = true;
            this.lBxTOpic.TabIndex = 3;
            this.lBxTOpic.Click += new System.EventHandler(this.lBxTOpic_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 470);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 39);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddTopic
            // 
            this.AddTopic.AutoSize = true;
            this.AddTopic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddTopic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddTopic.FlatAppearance.BorderSize = 0;
            this.AddTopic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTopic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddTopic.Location = new System.Drawing.Point(82, 339);
            this.AddTopic.Name = "AddTopic";
            this.AddTopic.Size = new System.Drawing.Size(158, 60);
            this.AddTopic.TabIndex = 5;
            this.AddTopic.Text = "New Topic";
            this.AddTopic.UseVisualStyleBackColor = false;
            this.AddTopic.Click += new System.EventHandler(this.AddTopic_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(489, 106);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(108, 52);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnView.Location = new System.Drawing.Point(489, 164);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(108, 52);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(485, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TopicModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(596, 521);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.AddTopic);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lBxTOpic);
            this.Controls.Add(this.lbAllTOpic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopicModifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Topic Modifier";
            this.Load += new System.EventHandler(this.TopicModifier_Load);
            this.VisibleChanged += new System.EventHandler(this.TopicModifier_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAllTOpic;
        private System.Windows.Forms.ListBox lBxTOpic;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button AddTopic;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;


    }
}