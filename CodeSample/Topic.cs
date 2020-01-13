using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSample
{
    [Serializable]
    public class Topic
    {
        private string topicName;
        private ListOfContent listOfContent;
        
        public Topic(string topicName)
        {
            this.topicName = topicName;
            listOfContent = new ListOfContent();
        }
        public string TopicName
        {
            set
            {
                topicName = value;
            }
            get
            {
                return topicName;
            }
        }
        
        public void AddContent(Content content)
        {
            listOfContent.AddContent(content);
        }
        public void RemoveContent(int index)
        {
            listOfContent.RemoveContent(index);
        }
        public Content ContentAt(int index)
        {
            return listOfContent.GetContentAt(index);
        }

        public void AddProblemNameToListBox(System.Windows.Forms.ListBox lBxProblem)
        {
            listOfContent.AddProblemNameToListBox(lBxProblem);
        }
        public Content FindContentForProblem(string problemStr)
        {
            return listOfContent.FindContentForProblem(problemStr);
        }
    }
}
