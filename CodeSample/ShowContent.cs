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
    public partial class ShowContent : Form
    {
        private ShowTopic showTopicForm;
        private Content content;
        private string topic;
        public ShowContent()
        {
            InitializeComponent();
        }
        public ShowContent(Content content, string fromtopic, ShowTopic fromShowTopicForm)
        {
            InitializeComponent();
            topic = fromtopic;
            this.content = content;
            this.showTopicForm = fromShowTopicForm;
        }

        private void ShowContent_Load(object sender, EventArgs e)
        {
            lbDate.Text = content.DateTime.ToShortDateString();
            lbProblem.Text = content.Problem;
            rtbContent.Text = content.ContentText;
            lbTopic.Text = topic;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            showTopicForm.Show();
            this.Hide();
        }

        public void Update(Content content, string fromtopic, ShowTopic fromShowTopicForm)
        {
            topic = fromtopic;
            this.content = content;
            this.showTopicForm = fromShowTopicForm;
 
            lbDate.Text = content.DateTime.ToShortDateString();
            lbProblem.Text = content.Problem;
            rtbContent.Text = content.ContentText;
            lbTopic.Text = topic;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
