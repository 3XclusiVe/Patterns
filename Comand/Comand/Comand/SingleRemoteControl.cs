using System;
using System.Text;

namespace Comand
{
    /// <summary>
    /// Заказчик
    /// </summary>
    public class SingleRemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand prevCommand;


        public SingleRemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            prevCommand = noCommand;

        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {   
            onCommands[slot].execute();
            prevCommand = onCommands[slot];
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
            prevCommand = offCommands[slot];
        }

        public void undoButtonWasPushed()
        {
            prevCommand.undo();
        }

        public String ToString()
        {
            StringBuilder String = new StringBuilder();
            String.Append("\n---------Remote Control----------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                String.Append("slot" + i + " : " + onCommands[i].ToString() +
                    "    " + offCommands[i].ToString() + "\n");

            }

            return String.ToString();
        }

    }
}

