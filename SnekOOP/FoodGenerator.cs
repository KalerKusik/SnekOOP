using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnekOOP
{
    class FoodGenerator
    {
        int mapWidth;
        int mapHeight;
        char symb;

            Random rnd = new Random();

        public  FoodGenerator(int _mapWidth, int _mapHeight, char _symb)
        {
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            symb = _symb;
        }

        public Point GenerateFood()
        {
            int x = rnd.Next(2, mapWidth - 2);
            int y = rnd.Next(2, mapHeight - 2);
            return new Point(x, y, symb);
        }
    }
}
