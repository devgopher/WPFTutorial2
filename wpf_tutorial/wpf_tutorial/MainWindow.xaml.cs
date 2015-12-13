using System;
using System.Windows;
using System.Windows.Input;


namespace wpf_tutorial
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static commands.Command1 cmd1 = new commands.Command1();
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
            CommandBinding cb = new CommandBinding(Cmd1);
            this.CommandBindings.Add(cb);
        }

        private void view_entered_text_Copy_Click(object sender, RoutedEventArgs e)
        {
            cmd1.Execute( sender );
        }
    }
}
