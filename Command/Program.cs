using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button();
            var pult = new Invoker(new ButtonCommand(button));
            pult.PressButton();
            pult.PressUndo();
        }
    }
}