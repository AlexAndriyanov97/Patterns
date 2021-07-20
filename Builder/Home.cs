using System.Text;

namespace Builder
{
    public class Home
    {
        public Floor Floor { get; set; }
        public Wall Wall { get; set; }
        public Roof Roof { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
 
            if (Floor != null)
                sb.Append($"Floor: {Floor.FloorMaterial} \n");
            if (Wall != null)
                sb.Append($"Wall: {Wall.WallMaterial} \n");
            if (Roof != null)
                sb.Append($"Roof: {Roof.RoofMaterial} \n");
            return sb.ToString();
        }
    }
}