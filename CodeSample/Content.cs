using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSample
{
    [Serializable]
    public class Content
    {
        private string contentText;
        private DateTime? dateTime;
        private string problem;
        public Content(string contentText = null, string problem = null)
        {
            this.contentText = contentText;
            this.dateTime = DateTime.UtcNow;
            this.problem = problem;
        }
        public void EditContent(string contentText = null, string problem = null)
        {
            this.contentText = contentText;
            this.dateTime = DateTime.UtcNow;
            this.problem = problem;
        }
        
        public string ContentText
        {
            private set{}
            get
            {
                return contentText;
            }
        }
        public string Problem
        {
            private set { }
            get
            {
                return problem;
            }
        }
        public DateTime DateTime
        {
            private set { }
            get
            {
                return (DateTime) dateTime;
            }
        }
    }
}
