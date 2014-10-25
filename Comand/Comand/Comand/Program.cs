using System;
using System.Text.RegularExpressions;

namespace Comand
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SingleRemoteControl Remote = new SingleRemoteControl();
            Light LivingRoomLight = new RoomLight("Living Room");
            Light KitchenLight = new RoomLight("Kitchen");
            Stereo stereo = new Stereo();
            GarageDoor Door = new GarageDoor();
            CeilingFan LivingRoomFan = new CeilingFan("Living Room");

            GarageDoorOpenCommand Open = new GarageDoorOpenCommand(Door);
            GarageDoorCloseCommand close = new GarageDoorCloseCommand(Door);
            LightOffCommand OffLivingRoom = new LightOffCommand(LivingRoomLight);
            LighOnCommand OnLivingRoom = new LighOnCommand(LivingRoomLight);
            LightOffCommand OffKitchen = new LightOffCommand(KitchenLight);
            LighOnCommand OnnKitchen = new LighOnCommand(KitchenLight);
            StereoWithCDCommand OnCd = new StereoWithCDCommand(stereo);
            CeillingFanHighCommand SetHigh = new CeillingFanHighCommand(LivingRoomFan);

            MacroCommand multi = new MacroCommand(new ICommand[] { Open, close, OnCd, SetHigh });

            Remote.SetCommand(0, Open, close);
            Remote.SetCommand(1, OnLivingRoom, OffLivingRoom);
            Remote.SetCommand(2, OffKitchen, OnnKitchen);
            Remote.SetCommand(3, OnCd, OnCd);
            Remote.SetCommand(4, SetHigh, SetHigh);
            Remote.SetCommand(5, multi, multi);

            Console.WriteLine(Remote.ToString());

            Remote.onButtonWasPushed(5);
            Remote.undoButtonWasPushed();
        }
    }
}
