using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace CodeSample
{
    public partial class Menu : Form
    {
        private TopicModifier TopicModifier;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTopic_Click(object sender, EventArgs e)
        {
            TopicModifier = new TopicModifier();
            this.Hide();
            TopicModifier.Show();
        }

    }
}
