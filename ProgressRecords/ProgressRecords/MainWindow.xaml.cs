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
using System.Windows.Threading;

namespace ProgressRecords
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /*So this app will be about tracking my progress in my different hobbies. There will be a menu system for navigating through    
      the different panels of each hobby. Each panel will have a calender that I can set goals and important events on and 3 lists: What I learned, what
      I flaw in, and what I want to learn. At the bottom will be the goals I have set and next will be a check and an X, there purpose
     *I don't need to explain. Another spot will be a track of the goals I have accomplished and the background*/
    public partial class MainWindow : Window
    {
        ReminderClass remindInstance;
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimeContent;
            timer.Start();
            DispatcherTimer date = new DispatcherTimer();
            date.Interval = TimeSpan.FromSeconds(1);
            date.Tick += DateContent;
            date.Start();
            remindInstance = new ReminderClass();
        }
        void TimeContent(object sender, EventArgs e)
        {
           TimeLabel.Content = DateTime.Now.ToLongTimeString();
        }
        void DateContent(object sender, EventArgs e)
        {
            DateLabel.Content = DateTime.Now.ToLongDateString();
            
        }

        #region Reminder
        private void ReminderEntryAdd(object sender, RoutedEventArgs e)
        {
            
        }

        private void ReminderEntryDel(object sender, RoutedEventArgs e)
        {
           
        }
        #endregion
    }
}
