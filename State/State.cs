namespace State
{
    public interface State
    {
        public void Heat(Water water);
        public void Frost(Water water);
    }
}