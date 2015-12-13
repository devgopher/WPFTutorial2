using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

namespace wpf_tutorial
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ICommand cmd1 = new commands.Command1();
        public static ICommand Cmd1
        {
            get
            {
                return cmd1;
            }
            private set { }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CanExecuteCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
            e.Handled = true;
        }

        public void Action1( object sender, ExecutedRoutedEventArgs a )
        {
            MessageBox.Show("Event executed!");
        }
    }
}
