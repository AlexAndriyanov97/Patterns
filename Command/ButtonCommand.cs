namespace Command
{
    public class ButtonCommand : ICommand
    {
        private Button _button;

        public ButtonCommand(Button button)
        {
            _button = button;
        }

        public void Execute()
        {
            _button.EnableButton();
        }

        public void Undo()
        {
            _button.DisableButton();
        }
    }
}