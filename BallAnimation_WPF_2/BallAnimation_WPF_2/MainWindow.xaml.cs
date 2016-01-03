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

namespace BallAnimation_WPF_2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += physics;
            timer.Interval = TimeSpan.FromSeconds(0.05);
            
        }

        bool goingRight= true;
        bool goingDown = true;

        private void physics(object sender, EventArgs e)
        {
            double x = Canvas.GetLeft(ball);

            double v = 5.0;

            if (chkFast.IsChecked.Value)
            {
                v = 10;
            }
            

            if (goingRight)
            {
                x += v;
            }
            else
            {
                x -= v;
            }

            if (x + ball.Width > myCanvas.ActualWidth)
            {
                goingRight = false;
                x = myCanvas.ActualWidth - ball.Width;
            }
            else if (x < 0.0)
            {
                goingRight = true;
                x = 0.0;
            }

            Canvas.SetLeft(ball, x);

            //----------------------------------------------------------

            double y = Canvas.GetTop(ball);

            if (goingDown)
            {
                y += v;
            }
            else
            {
                y -= v;
            }

            if (y + ball.Height > myCanvas.ActualHeight)
            {
                goingDown = false;
                x = myCanvas.ActualHeight - ball.Height;
            }
            else if (y < 0.0)
            {
                goingDown = true;
                y = 0.0;
            }

            Canvas.SetTop(ball, y);
        }

        private void rbBlue_Click(object sender, RoutedEventArgs e)
        {
            ball.Fill = Brushes.Blue;
        }

        private void rbGreen_Click(object sender, RoutedEventArgs e)
        {
            ball.Fill = Brushes.Green;
        }

        private void rbRed_Click(object sender, RoutedEventArgs e)
        {
            ball.Fill = Brushes.Red;
        }

        private void cmdStartStop_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = !timer.IsEnabled;
        }

        int score;

        private void ball_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (timer.IsEnabled)
            {
                score++;
                lblInfo.Content = score; 
            }
        }
    }
}
