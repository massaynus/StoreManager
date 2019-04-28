using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Store_Manager
{
    public partial class Logs : UserControl
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            XmlDocument Log = new XmlDocument();
            Log.Load("C:\\Users\\Yassine\\Documents\\Mes Projets C#\\Fun Projects\\Store Manager\\Store Manager\\Log.xml");

            foreach(XmlNode node in Log.DocumentElement.ChildNodes)
            {
                textBox1.Text += @"
" + node.InnerText;
            }
        }
    }
}
