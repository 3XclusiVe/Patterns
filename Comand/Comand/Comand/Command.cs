using System;

namespace Comand
{
    public interface ICommand
    {
        void execute();

        void undo();
    }
}

