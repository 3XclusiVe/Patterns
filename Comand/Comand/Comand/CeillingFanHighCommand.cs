using System;

namespace Comand
{
    public class CeillingFanHighCommand : ICommand
    {
        CeilingFan Fan;
        int prevSpeed;

        public CeillingFanHighCommand(CeilingFan Fan)
        {
            this.Fan = Fan;
        }


        #region ICommand implementation

        public void execute()
        {   
            prevSpeed = Fan.Speed;
            Fan.high();
            Console.WriteLine(Fan.Speed);
        }

        public void undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
            {
                Fan.high();
            }
            if (prevSpeed == CeilingFan.LOW)
            {
                Fan.low();
            }
            if (prevSpeed == CeilingFan.MEDIUM)
            {
                Fan.medium();
            }
            if (prevSpeed == CeilingFan.OFF)
            {
                Fan.off();
            }
            Console.WriteLine(Fan.Speed);
        }

        #endregion
    }
}

