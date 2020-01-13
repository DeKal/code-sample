using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CodeSample
{
    [Serializable]
    public class ListOfTopic
    {
        private Dictionary<string,int> dictionaryOfTopic;
        private List<Topic> listOfTopic;
        public ListOfTopic()
        {
            dictionaryOfTopic = new Dictionary<string, int>();
            listOfTopic=new List<Topic>();
        }
        public bool AddTopic(Topic topic){
            if (dictionaryOfTopic.ContainsKey(topic.TopicName)==false)
            {
                listOfTopic.Add(topic);
                dictionaryOfTopic.Add(topic.TopicName, 0);
                return true;
            }
            else return false;
        }
        public Topic FindTopic(string topicText)
        {
            foreach (Topic Items in listOfTopic)
                if (Items.TopicName == topicText)
                    return Items;
            return null;
        }


        public void AddTopicNameToComboBox(ComboBox combobox)
        {
            foreach(var item in dictionaryOfTopic.Keys){
                combobox.Items.Add(item);
            }
        }
        public void AddTopicNameToListBox(ListBox listbox)
        {
            foreach (var item in dictionaryOfTopic.Keys)
            {
                listbox.Items.Add(item);
            }
        }

        internal void DelTopic(string p)
        {
            listOfTopic.Remove(FindTopic(p));
            dictionaryOfTopic.Remove(p);
        }
    }
}
