using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSample
{
    public partial class TopicModifier : Form
    {
        private ListOfTopic listTopic= Program.ListOfTopic;
        private ShowTopic showTopicForm;
        public TopicModifier()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Menu.Show();
        }

        private void lBxTOpic_Click(object sender, EventArgs e)
        {
            
            
        }
        private AddContent addContentForm;

        private AddTopic addTopicForm;
        private void AddTopic_Click(object sender, EventArgs e)
        {
            if (addTopicForm == null)
                addTopicForm = new AddTopic(listTopic, this);
            else
                addTopicForm.Update(listTopic, this);
            this.Hide();
            addTopicForm.Show();
            
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lBxTOpic.SelectedItem == null)
                return;
            if (addContentForm == null)
                addContentForm = new AddContent(this, lBxTOpic.SelectedItem.ToString());
            else
                addContentForm.Update(lBxTOpic.SelectedItem.ToString());
            addContentForm.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lBxTOpic.SelectedItem == null)
                return;
            if (showTopicForm == null)
                showTopicForm = new ShowTopic(lBxTOpic.SelectedItem.ToString(), this);
            else
                showTopicForm.Update(lBxTOpic.SelectedItem.ToString(), this);
            this.Hide();
            showTopicForm.Show();
        }

        private void TopicModifier_VisibleChanged(object sender, EventArgs e)
        {
            lBxTOpic.Items.Clear();
            listTopic.AddTopicNameToListBox(lBxTOpic);
        }

        private void TopicModifier_Load(object sender, EventArgs e)
        {
            listTopic.AddTopicNameToListBox(lBxTOpic);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lBxTOpic.SelectedItem == null)
                return;
            listTopic.DelTopic(lBxTOpic.SelectedItem.ToString());
            lBxTOpic.Items.Remove(lBxTOpic.SelectedItem);
        }

    }
}
