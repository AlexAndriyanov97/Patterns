namespace Builder
{
    public abstract class HomeBuilder
    {
        public Home Home { get; private set; }

        public void CreateHome()
        {
            Home = new Home();
        }

        public abstract void SetWall();
        public abstract void SetFloor();
        public abstract void SetRoof();
    }
}