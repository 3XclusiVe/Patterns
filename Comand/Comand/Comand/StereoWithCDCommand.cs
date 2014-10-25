using System;

namespace Comand
{
    public class StereoWithCDCommand : ICommand
    {
        Stereo Stereo;

        public StereoWithCDCommand(Stereo Stereo)
        {
            this.Stereo = Stereo;
        }

        #region ICommand implementation

        public void execute()
        {
            Stereo.on();
            Stereo.SetCD();
            Stereo.SetVolume();
        }

        #endregion

        public void undo()
        {
            Stereo.SetVolume();
            Stereo.SetCD();
            Stereo.off();
        }
    }
}

