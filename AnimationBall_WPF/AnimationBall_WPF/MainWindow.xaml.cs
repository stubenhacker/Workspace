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

namespace AnimationBall_WPF
{
   
    public partial class MainWindow : Window
    {

        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

        double vx = 3.0;
        double vy = 4.0;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(0.05);
            timer.IsEnabled = true;
            timer.Tick += animate;
        }

        void animate(object sender, EventArgs e)
        {
            double x = Canvas.GetLeft(ball);
            double y = Canvas.GetTop(ball);
            x += vx + timer.Interval.TotalSeconds;

            if (x <= leftPaddle.Width && y >= Canvas.GetTop(leftPaddle) && y + ball.Height <= Canvas.GetTop(leftPaddle) + leftPaddle.Height)
            {
                vx = -vx;
            }

            if (x + ball.Width >= myCanvas.ActualWidth - Canvas.GetRight(rightPaddle) - rightPaddle.Width && y >= Canvas.GetTop(rightPaddle) && y + ball.Height <= Canvas.GetTop(rightPaddle) + rightPaddle.Height)
            {
                vx = -vx;
            }
            Canvas.SetLeft(ball, x);

            y += vy + timer.Interval.TotalSeconds;

            if (y <= 0.0 || y >= myCanvas.ActualHeight - ball.Height)
            {
                vy = -vy;
            }
            Canvas.SetTop(ball, y);
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            Title = p.X.ToString();

            Canvas.SetTop(leftPaddle, p.Y);
            Canvas.SetTop(rightPaddle, p.Y);
        }
    }
}
