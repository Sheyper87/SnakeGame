using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class VerticalLines : Figure
    {
        
        public VerticalLines(int x, int yLow, int yHigh, char sym)
        {
            pList = new List<Point>();
            for (int y = yLow; y <= yHigh; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
