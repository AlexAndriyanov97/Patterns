namespace Command
{
    public class Invoker
    {
        private readonly ICommand _command;

        public Invoker(ICommand command)
        {
            _command = command;
        }
        
        public void PressButton()
        {
            _command.Execute();
        }
        public void PressUndo()
        {
            _command.Undo();
        }
    }
}