using System;

namespace Comand
{
    public class RoomLight : Light
    {
        private string RoomName;

        public RoomLight(string Name)
        {
            this.RoomName = Name;
        }

        public override void Off()
        {   
            Console.Write(RoomName);
            base.Off();
        }

        public override void On()
        {
            Console.Write(RoomName);
            base.On();
        }

    }
}

