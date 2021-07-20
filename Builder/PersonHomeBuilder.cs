namespace Builder
{
    public class PersonHomeBuilder : HomeBuilder
    {
        public override void SetWall()
        {
            Home.Wall = new Wall {WallMaterial = "brick"};
        }

        public override void SetFloor()
        {
            Home.Floor = new Floor {FloorMaterial = "concrete"};
        }

        public override void SetRoof()
        {
            Home.Roof = new Roof {RoofMaterial = "roof tiles"};
        }
    }
}