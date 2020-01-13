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
    public partial class ShowTopic : Form
    {
        private string topic;
        private TopicModifier topicModifier;
        private Topic thisTopic;
        public ShowTopic()
        {
            InitializeComponent();
        }
        public ShowTopic(string topic, TopicModifier topicMod)
        {
            InitializeComponent();
            this.topic = topic;
            topicModifier = topicMod;
        }
        private void ShowTopic_Load(object sender, EventArgs e)
        {
            thisTopic = Program.ListOfTopic.FindTopic(topic);
            lbTopic.Text = "Topic : " + topic;
            thisTopic.AddProblemNameToListBox(lBxProblem);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            topicModifier.Show();
            this.Hide();
        }
        private ShowContent showContentForm;
        private void lBxProblem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lbTmp = (ListBox)sender;
            if (lbTmp.SelectedItem == null) return;
            string problem = lbTmp.SelectedItem.ToString();
            Content content = thisTopic.FindContentForProblem(problem);
            if (showContentForm == null)
                showContentForm = new ShowContent(content, topic, this);
            else
                showContentForm.Update(content, topic, this);
            showContentForm.Show();
            this.Hide();
        }

        public void Update(string topic, TopicModifier topicMod)
        {
            this.topic = topic;
            topicModifier = topicMod;
            thisTopic = Program.ListOfTopic.FindTopic(topic);
            lbTopic.Text = "Topic : " + topic;
            lBxProblem.Items.Clear();
            thisTopic.AddProblemNameToListBox(lBxProblem);
        }
    }
}
