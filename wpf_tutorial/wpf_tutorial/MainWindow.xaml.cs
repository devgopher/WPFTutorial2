using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Controls;

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
			
			// Добавляем обработчик события
			ReHandler += ReDelegate;
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
		
		#region RoutedEvents
		
		public static RoutedEvent Re = EventManager.RegisterRoutedEvent( "Click",
		                                                                RoutingStrategy.Bubble,
		                                                                typeof(RoutedEventHandler),
		                                                                typeof(Button) );
		// "Оборачиваем" наше событие для дальнейшего назначения ему
		// обработчиков
		public event RoutedEventHandler ReHandler
		{
			add { AddHandler(Re, value); }
			remove { RemoveHandler(Re, value); }
		}
		
		private void button1_MouseEnter(object sender, MouseEventArgs e)
		{
			RaiseEvent( new RoutedEventArgs( Re ) );
		}
		
		private void ReDelegate(object sender, RoutedEventArgs a ) {
			MessageBox.Show("Routed Event Executed!");
		}
		
		#endregion
	}
}
