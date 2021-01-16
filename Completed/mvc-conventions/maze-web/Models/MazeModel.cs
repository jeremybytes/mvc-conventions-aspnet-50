using maze_library;

namespace maze_web.Models
{
    public class MazeModel
    {
        public int Size { get; set; }
        public string Algo { get; set; }
        public MazeColor Color { get; set; }
    }
}
