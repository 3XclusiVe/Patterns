using System;

namespace Comand
{
    public class MacroCommand : ICommand
    {
        ICommand[] commands;

        public MacroCommand(ICommand[] comands)
        {
            this.commands = comands;

        }

        #region ICommand implementation

        public void execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].execute();
            }
        }

        public void undo()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].undo();
            }
        }

        #endregion
    }
}

