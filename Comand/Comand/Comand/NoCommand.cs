using System;

namespace Comand
{
    public class NoCommand : ICommand
    {
        public NoCommand()
        {
        }

        #region ICommand implementation

        public void execute()
        {
            Console.WriteLine("No_command_initialized");
        }

        #endregion

        public void undo()
        {
           
        }
    }
}

