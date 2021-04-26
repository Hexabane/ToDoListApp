using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class ViewList : Form
    {

        
        public ViewList()
        {
            InitializeComponent();
            populateListBox();
           
        }
        
        public void populateListBox()
        {
            List<ListData> viewListInfo = ListHandler.userList();
            viewListInfo = viewListInfo.OrderBy(x => x.DateTime).ToList();

            foreach(ListData item in viewListInfo)
            {
                lbListNames.Items.Add("Event/Activity Name :" + item.EventName);
            }
            
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            lbData.Items.Clear();

            string selectedItem = lbListNames.SelectedItem.ToString();

            string[] splitString = selectedItem.Split(':');

            List<ListData> viewListInfo = ListHandler.userList();

            viewListInfo = viewListInfo.Where(t => t.EventName == splitString[1]).ToList();

            foreach (ListData item in viewListInfo)
            {
                lbData.Items.Add("Event/Activity Name : " + item.EventName);
                lbData.Items.Add("Event/Activity Type : " + item.EventType);
                lbData.Items.Add("Event/Activity Date : " + item.DateTime);
            }



        }
    }
}
