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
    public partial class AddTopic : Form
    {
        private string p;
        private TopicModifier topicModifier;
        private ListOfTopic listTopic;

        public AddTopic()
        {
            InitializeComponent();
        }
        public AddTopic(ListOfTopic listTopic, TopicModifier topicModifier)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.listTopic = listTopic;
            this.topicModifier = topicModifier;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listTopic.AddTopic(new Topic(textBox1.Text));
                this.Hide();
                topicModifier.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            topicModifier.Show();
        }


        public void Update(ListOfTopic listTopic, TopicModifier topicModifier)
        {
            this.textBox1.Text = "";
            this.listTopic = listTopic;
            this.topicModifier = topicModifier;
        }
    }
}
