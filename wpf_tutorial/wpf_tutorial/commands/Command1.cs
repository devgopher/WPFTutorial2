using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Markup;

namespace wpf_tutorial.commands
{
    public class Command1 : ICommand
    {
        public void Execute ( object input )
        {
            MessageBox.Show(String.Format("You entered"));
        }

        public bool CanExecute( object obj )
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
