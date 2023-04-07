using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public  class Block
    {
        public int width, length, height;


        public Block(int[] dimension)
        {
            this.width = dimension[0];
            this.length = dimension[1];
            this.height = dimension[2];
        }

        public int GetWidth()
        {

            return width;
        }
        public int GetLength()
        {
            return length;
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetVolume()
        {
            return width * length * height;
        }
        public int GetSurfaceArea()
        {
            return 2 * (width * length + width * height + length * height);
        }


    }
    }
       


 
