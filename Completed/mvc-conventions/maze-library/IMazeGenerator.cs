using System.Drawing;

namespace maze_library
{
    public interface IMazeGenerator
    {
        void GenerateMaze();
        Bitmap GetGraphicalMaze(bool includeHeatMap = false);
        string GetTextMaze(bool includePath = false);
    }
}