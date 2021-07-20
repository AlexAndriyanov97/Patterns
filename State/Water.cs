namespace State
{
    public class Water
    {
        public State State { get; set; }

        public Water(State state)
        {
            State = state;
        }

        public void Heat()
        {
            State.Heat(this);
        }

        public void Frost()
        {
            State.Frost(this);
        }
    }
}