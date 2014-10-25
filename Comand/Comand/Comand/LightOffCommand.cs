using System;

namespace Comand
{


    public class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }


        #region ICommand implementation

        public void execute()
        {
            light.Off();
        }

        #endregion

        public void undo()
        {
            light.On();
        }
    }
}

