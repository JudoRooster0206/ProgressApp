using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ProgressRecords
{
    public class ReminderClass
    {
        /*So all I need is the instructions for when you push the plus button, you add the reminder that's in the textbox and the urgency next to it
          and if you press the minus you delete the selected reminder else you'll be asked to select it and have check mark buttons next to the text.*/
        
        public void Add_the_Entry(Button AddButton, Button DeleteButton, ListBox List_of_Reminders, TextBox NewEntry)
        { 
        if(NewEntry.Text.Length==0)
            {
              MessageBox.Show("Please enter an entry into the box.");
            }
        else
            List_of_Reminders.Items.Add(NewEntry.Text);
        }
        public void Delete_the_Entry(Button AddButton, Button DeleteButton, ListBox List_of_Reminders, TextBox NewEntry)
        {
              List_of_Reminders.SelectedItem = null;
            
        }

    }
}
