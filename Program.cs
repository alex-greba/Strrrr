using System;

namespace Stroyka
{
    class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project(4, 1, 4);
            Worker worker = new Worker();
            House house = new House();
            TeamLeader teamLeader = new TeamLeader(house, project, worker);
            
        }
    }
}
