using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class AddList : Form
    {
        public AddList()
        {
            InitializeComponent();
            dtpWhen.Format = DateTimePickerFormat.Custom;
            dtpWhen.CustomFormat = "dd/MMMM/yyyy";
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
           

            string eventName = tbEventName.Text;
            string eventType = tbEventType.Text;
            string dateTime = dtpWhen.Text;

            ListData data = new ListData(eventName, eventType, dateTime);

            data.populatingTextFile();

        }
    }
}
