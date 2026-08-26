using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralTest
{
    public class shape
    {
        public int vertex { get; set; }
        public int color { get; set; }

        public string GetShape()
        {
            return "?";
        }

        public void draw()
        {
            vertex = -1;
        }
    }

    public class polygon:shape
    {
        public string GetShape()
        {
            return "polygon";
        }

    }

    public class triangle : shape
    {
        public int firstangle { get; set; }
        public int secondangle { get; set; }

        public triangle()
        {
            vertex = 3;
        }
  
        public string GetShape()
        {
            return "triangle";
        }
    }

    public class circle : shape
    {
        public circle()
        {
            vertex = 0;
        }

        public string GetShape()
        {
            return "circle";
        }
    }
}
