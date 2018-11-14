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
        private bool _isRunning;
        private DispatcherTimer _timer;
        private DateTime _startTime;

        public MainWindow()
        {
            InitializeComponent();
            _isRunning = false;
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(50);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if(_isRunning)
            {
                StartButton.Background = Brushes.LightGray;
                StartButton.Content = "Start";
                _isRunning = false;


                DateTime endTime = DateTime.Now;
                EndTimeList.Items.Add(endTime.ToLongTimeString());
                TimeSpan span = endTime - _startTime;

                TimeCountList.Items.Add($"{span.Hours}:{span.Minutes}:{span.Seconds}");

            }
            else
            {
                StartButton.Background = Brushes.Pink;
                StartButton.Content = "Stop";
                _isRunning = true;

                _startTime = DateTime.Now;
                StartTimeList.Items.Add(_startTime.ToLongTimeString());
            }
            
        }
    }
}
