using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSample
{
    [Serializable]
    class ListOfContent
    {
        private List<Content> listOfContent =new List<Content>();
        public Content GetContentAt(int index)
        {
            return listOfContent.ElementAt(index);
        }
        public void RemoveContent(int index)
        {
            listOfContent.RemoveAt(index);
        }
        public void AddContent(Content content)
        {
            listOfContent.Add(content);
        }
        public Content FindContentForProblem( string problemStr)
        {
            foreach (Content content in listOfContent)
            {
                if (content.Problem == problemStr)
                    return content;
            }
            return null;
        }
        public void AddProblemNameToListBox(System.Windows.Forms.ListBox lBxProblem)
        {
            foreach (Content content in listOfContent)
            {
                lBxProblem.Items.Add(content.Problem);
            }
        }
    }
}
