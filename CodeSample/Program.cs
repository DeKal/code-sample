using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private  static ListOfTopic listOfTopic = new ListOfTopic();
        private static Menu menu;
        public static Menu Menu
        {
            get
            {
                return menu;
            }
        }
        public static ListOfTopic ListOfTopic
        {
            get
            {
                return listOfTopic;
            }
        }
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                LoadData();
            }
            catch (Exception e){
                SaveData();
                LoadData();
            }
            menu = new Menu();
            Application.Run(menu);
            SaveData();
        }

        private static void SaveData()
        {
            using (Stream output = File.Create("Data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, Program.ListOfTopic);
            }
        }

        private static void LoadData()
        {
            using (Stream input = File.OpenRead("Data.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                listOfTopic = (ListOfTopic)formatter.Deserialize(input);
            }
        }
    }
}
