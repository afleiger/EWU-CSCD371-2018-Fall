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

namespace TimeTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsRunning { get; set; }
        private DispatcherTimer Timer { get; set; }
        private TimeManager TimeManager { get; set; }
        private int ListIndex { get; set; }
        private int AnimationFrame { get; set; }
        private bool IsAnimationGoingUp { get; set; }
        public int DeleteIndex { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            TimeManager = new TimeManager(new TimerDateTime()); 
            IsRunning = false;
            Timer = new DispatcherTimer();
            Timer.Interval = TimeSpan.FromMilliseconds(20);
            Timer.Tick += Timer_Tick;
            Timer.Start();
            ListIndex = 0;

            AnimationFrame = 0;
            IsAnimationGoingUp = true;

            TimeManager.UpdateEvent += TimeList_Updated;
            TimeList.GotFocus += TimeList_GotFocus;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = TimeManager.NowString;
            AnimateLine();
        }

        private void TimeList_GotFocus(object sender, RoutedEventArgs e)
        {
            DeleteButton.IsEnabled = true;
            DeleteIndex = TimeList.SelectedIndex;
        }
        
        private void AnimateLine()
        {
            if(IsRunning)
            {
                string str = ((TextBlock)(TimeList.Items[ListIndex])).Text;
                if (AnimationFrame <= 7 && IsAnimationGoingUp)
                {
                    str = str.Substring(0, str.Length - 1);
                    str += " -";
                    AnimationFrame++;
                }
                else
                {
                    IsAnimationGoingUp = false;
                }

                if(AnimationFrame >= 0 && !IsAnimationGoingUp)
                {
                    str = str.Substring(0, str.Length - 1);
                    AnimationFrame--;
                }
                else
                {
                    IsAnimationGoingUp = true;
                }
                ((TextBlock)(TimeList.Items[ListIndex])).Text = str;
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteButton.IsEnabled = false;

            if (IsRunning)
            {
                CurrentTime.Background = Brushes.LightGray;
                CurrentTime.Foreground = Brushes.Black;
                StartButton.Background = Brushes.LightGreen;
                StartButton.Content = "Start";
                IsRunning = false;

                TimeManager.EndTimer();
                ListIndex++;
            }
            else
            {
                AnimationFrame = 0;
                CurrentTime.Background = Brushes.Black;
                CurrentTime.Foreground = Brushes.White;
                StartButton.Background = Brushes.Pink;
                StartButton.Content = "Stop";
                IsRunning = true;

                TextBlock textBlock = new TextBlock();
                textBlock.FontSize = 30;
                textBlock.Text = TimeManager.StartTimer();
                TimeList.Items.Add(textBlock);
            }  
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteButton.IsEnabled = false;

            if(TimeList.SelectedIndex != ListIndex)
            {
                TimeList.Items.RemoveAt(TimeList.SelectedIndex);
                ListIndex--;
            }
        }

        private void TimeList_Updated(object sender, TimeArgs e)
            => ((TextBlock)(TimeList.Items[ListIndex])).Text = e.TimeString;
    }
}
