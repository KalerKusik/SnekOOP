using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnekOOP
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            //Border
            wallList = new List<Figure>();
            HorizonalLine top = new HorizonalLine(0, 80, 0, '#');

            VerticalLine left = new VerticalLine(0, 25, 0, '#');

            HorizonalLine bottom = new HorizonalLine(0, 80, 25, '#');

            VerticalLine right = new VerticalLine(0, 25, 80, '#');

            VerticalLine danger1 = new VerticalLine(7, 13, 50, 'l');

            HorizonalLine danger2 = new HorizonalLine(30, 40, 20, '-');

            wallList.Add(top);
            wallList.Add(left);
            wallList.Add(bottom);
            wallList.Add(right);
            wallList.Add(danger1);
            wallList.Add(danger2);
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
