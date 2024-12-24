using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AL_Ess_104.Parts
{
    public class Point
    {
        private int _x;
        private int _y;
        private string _name;

        public Point(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }

        public int X => _x;
        public int Y => _y;
        public string Name 
        { 
            get
            { 
                return _name; 
            } 
        }
        
        
    }
}
