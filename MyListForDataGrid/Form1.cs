using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyListForDataGrid
{
    public partial class Form1 : Form
    {
        internal BindingList<StringData> ListOfStringData;
        public Form1()
        {
            InitializeComponent();
            ListOfStringData = new BindingList<StringData>(); //bindingList вместо List
            ListOfStringData.Add(new StringData("some text"));
            ListOfStringData.Add(new StringData("another text"));
            var source = new BindingSource(ListOfStringData,null); // привязка не к листу а к BindingSource
            dataGridView1.DataSource =source;
        }

        private void addElement(object sender, EventArgs e)
        {
            ListOfStringData.Add(new StringData("yet another text"));
        }

        private void removeElement(object sender, EventArgs e)
        {
            ListOfStringData.Remove(ListOfStringData.Last());
        }
    }
    public class StringData //класс для отображения string value и удобным конструктором
    {
        string _textValue;
        public string textValue {
            get { return _textValue; } 
            set { _textValue = value; } 
        }
        public StringData(string s)
        {
            _textValue = s;
        }
    }

    
}
