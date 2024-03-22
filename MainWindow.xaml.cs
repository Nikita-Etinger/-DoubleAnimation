using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Windows.Media;

namespace WpfApp4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AnimateCar();
        }

        private void AnimateCar()
        {
            //  путь анимации для координаты X
            PathGeometry pathGeometryX = ((Path)road.Children[0]).Data.GetFlattenedPathGeometry();
            DoubleAnimationUsingPath animationX = new DoubleAnimationUsingPath();
            animationX.PathGeometry = pathGeometryX;
            animationX.Duration = TimeSpan.FromSeconds(10);
            animationX.RepeatBehavior = RepeatBehavior.Forever;
            animationX.Source = PathAnimationSource.X;

            //  путь анимации для координаты Y
            PathGeometry pathGeometryY = ((Path)road.Children[0]).Data.GetFlattenedPathGeometry();
            DoubleAnimationUsingPath animationY = new DoubleAnimationUsingPath();
            animationY.PathGeometry = pathGeometryY;
            animationY.Duration = TimeSpan.FromSeconds(10);
            animationY.RepeatBehavior = RepeatBehavior.Forever;
            animationY.Source = PathAnimationSource.Y;

            car.BeginAnimation(Canvas.LeftProperty, animationX);
            car.BeginAnimation(Canvas.TopProperty, animationY);

        }
    }
}
