namespace Builder
{
    public class Constructor
    {
        public Home Build(HomeBuilder homeBuilder)
        {
            homeBuilder.CreateHome();
            homeBuilder.SetFloor();
            homeBuilder.SetWall();
            homeBuilder.SetRoof();
            return homeBuilder.Home;
        }
    }
}