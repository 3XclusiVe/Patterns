using System;

namespace Comand
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            this.garageDoor = door;
        }

        #region ICommand implementation

        public void execute()
        {
            garageDoor.up();
        }

        #endregion

        public void undo()
        {
            garageDoor.down();
        }
    }
}

