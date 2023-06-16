using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_App
{
    public partial class form1 : Form
    {
        
        //  private string[] allTask;
        private string addTask;
        //  private List<string> taskList = new List<string>();

        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTask = newTaskBox.Text;
          //  I Tried using a messgae box with a Text Box and decided a checked box would be easier.
          //  MessageBox.Show("You have added a task!");
          //  taskList.Add(addTask);
          //  allTask = taskList.ToArray();
          //  tasksBox.Text = string.Join(System.Environment.NewLine,allTask);
            taskCheckBox.Items.Add(addTask);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (taskCheckBox.CheckedItems.Count > 0)
            {
                taskCheckBox.Items.RemoveAt(taskCheckBox.CheckedIndices[0]);
            }
        }
    }
}
