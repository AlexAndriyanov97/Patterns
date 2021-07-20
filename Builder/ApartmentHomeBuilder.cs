namespace Builder
{
    public class ApartmentHomeBuilder : HomeBuilder
    {
        public override void SetWall()
        {
            Home.Wall = new Wall {WallMaterial = "concrete plates"};
        }

        public override void SetFloor()
        {
            Home.Floor = new Floor {FloorMaterial = "concrete"};
        }

        public override void SetRoof()
        {
            Home.Roof = new Roof {RoofMaterial = "concrete plates"};
        }
    }
}