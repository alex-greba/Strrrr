using System;
using System.Collections.Generic;
using System.Text;

namespace Stroyka
{
    public class Worker:IWorker
    {
        public Worker() { }
        public void BildBasement(House house)
        {
            house.Parts.Add(new Basement());
        }
        public void BildWall(House house)
        {
            house.Parts.Add(new Walls());
        }
        public void BildDoor(House house)
        {
            house.Parts.Add(new Door());
        }
        public void BildWindow(House house)
        {
            house.Parts.Add(new Window());
        }
        public void BildRoof(House house)
        {
            house.Parts.Add(new Roof());
        }
    }
}
