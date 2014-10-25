using System;

namespace Comand
{
    public class GarageDoorCloseCommand : ICommand
    {
        GarageDoor Door;

        public GarageDoorCloseCommand(GarageDoor Door)
        {
            this.Door = Door;
        }


        #region ICommand implementation

        public void execute()
        {
            Door.down();
        }

        #endregion

        public void undo()
        {
            Door.up();
        }
    }
}

