using System;
using System.Collections.Generic;
using System.Text;

namespace Stroyka
{
    public class Project
    {

        public bool IsBasement = true;
        public int wall = 4;
        public int door = 1;
        public int window = 4;
        public bool roof = true;

        public Project(int wall, int door, int window,bool IsBasement = true, bool roof = true)
        {
            this.wall = wall;
            this.door = door;
            this.window = window;
            this.IsBasement = IsBasement;
            this.roof = roof;
        }
    }
}
