using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stroyka
{
    public class TeamLeader
    {
        private House House { get; set; }
        private Project Project { get; set; }
        private Worker Worker { get; set; }

        public TeamLeader(House house, Project project, Worker worker)
        {
            House = house;
            Project = project;
            Worker = worker;
        }


        public bool IsWall()
        {
            if (House.Parts.Count < 1 && Project.IsBasement == true)
                return true;
            else
                return false;
        }

        public bool IsDoor()
        {
            if (House.Parts.OfType<Walls>().Count() >= Project.wall && House.Parts.OfType<Door>().Count() != Project.door)
                return true;
            else
                return false;
        }
        public bool IsWindow()
        {
            if (House.Parts.OfType<Walls>().Count() == Project.wall && House.Parts.OfType<Window>().Count() != Project.window)
                return true;
            else
                return false;
        }

        //bool isBildRoof = false;
        public bool IsRoof()
        {
            
            if (House.Parts.OfType<Walls>().Count() == Project.wall && Project.roof == true && !House.Parts.OfType<Roof>().Any())
                return true;
            else
                return false;
        }
        public bool IsComplete()
        {

            if (House.Parts.OfType<Roof>().Any() &&
                House.Parts.OfType<Window>().Count() == Project.window &&
                House.Parts.OfType<Door>().Count() == Project.door)
                return true;
            else
                return false;
        }

        public House BildHouse()
        {
            while(IsComplete()  == true)
            {

            }
    }
}
