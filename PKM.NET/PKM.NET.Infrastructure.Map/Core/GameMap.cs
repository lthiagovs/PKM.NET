namespace PKM.NET.Infrastructure.Map.Core
{
    public class GameMap
    {

        public readonly string Name;

        public readonly int SizeX;

        public readonly int SizeY;

        public int[][] MapData { get; private set; }

        public int GetAt(int x, int y)
        {
            return this.MapData[y][x];
        }

    }
}
