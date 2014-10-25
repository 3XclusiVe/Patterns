using System;

namespace Comand
{
    /// <summary>
    /// Команда.
    /// </summary>
    public class LighOnCommand : ICommand
    {
        Light light;

        public LighOnCommand(Light light)
        {
            this.light = light;
        }



        #region ICommand implementation

        public void execute()
        {
            light.On();
        }

        #endregion

        public void undo()
        {
            light.Off();
        }
    }
}

