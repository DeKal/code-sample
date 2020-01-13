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
    public partial class AddContent : Form
    {

        private ListOfTopic ListOfTopic = Program.ListOfTopic;
        private TopicModifier topicModSender;
        private string topicName;
        
        public AddContent(TopicModifier topicModifier, string topicName)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.topicModSender = topicModifier;
            this.topicName = topicName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string contentText = rtbContentText.Text;
            string problemText = rtbProblem.Text;
            string topicText = cbTopic.SelectedItem.ToString();

            Topic topic = ListOfTopic.FindTopic(topicText);
            topic.AddContent(new Content(contentText, problemText));

            this.Hide();
            topicModSender.Show();
        }

        private void AddContent_Load(object sender, EventArgs e)
        {
            cbTopic.Items.Clear();
            ListOfTopic.AddTopicNameToComboBox(cbTopic);
            cbTopic.SelectedItem = topicName;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            topicModSender.Show();            
        }

        public void Update(string p)
        {
            this.topicName = p;
            cbTopic.Items.Clear();
            ListOfTopic.AddTopicNameToComboBox(cbTopic);
            cbTopic.SelectedItem = topicName;
        }
        
    }
}
