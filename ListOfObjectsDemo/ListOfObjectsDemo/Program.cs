using System;
using System.Collections.Generic;   // for List class

namespace ListOfObjectsDemo
{
    internal class Program
    {
        static void DisplayMainMenu()
        {
            Console.WriteLine(@"---> Meeting Menu <---
1) Set participant name
2) Show current participant
3) Add participant
4) Show all participants
5) End Meeting
0) Exit program
            ");
        }

        static void Main(string[] args)
        {
            // Create a new list of Participant
            List<Participant> participants = new List<Participant>();
            // Create a reference to a the current Participant
            Participant currentParticipant = null;  // null means no Participant created yet
            // Define variable to track selected menu option
            int selectedMenuOption = 0;


            /* Here is a sample of the program:
             * 
             * 1) Set participant name   - Create new Participant
             * 2) Show current participant  - Display the current Participant Name and JoinTime
             * 3) Add participant       - Add current Participant to List of particiapnts
             * 4) Show all participants - Show the Name and JoinTime for each participant in the list
             * 5) End Meeting - Set the LeaveTime for all participants to the current DateTime
             *                - save to a text the list of participants
             * 0) Exit program
             * 
             * */
            //// Create a new list of Participant
            //List<Participant> participants = new List<Participant>();
            //// Create a new Participant for Kevin and set LeaveTime to 5 minutes from now
            //Participant participant1 = new Participant("Kevin");
            //participant1.LeaveTime = DateTime.Now.AddMinutes(5);
            //// Add participant1 to our list of Participant
            //participants.Add(participant1);
            //// Create a new Particiant for Nino and set Leave time to 10 minutes from now
            //Participant participant2 = new Participant("Nino");
            //participant2.LeaveTime = DateTime.Now.AddMinutes(10);
            //// Add participan2 to our list of Participant
            //participants.Add(participant2);
            //// Add a new Participany for Prabin and set Leave time to 15 minutes from now
            //Participant participant3 = new Participant("Prabin");
            //participant3.LeaveTime = DateTime.Now.AddMinutes(15);
            //participants.Add(participant3);

            //// Display the Name, JoinTime, and LeaveTime for each participant
            //foreach(Participant currentParticipant in participants)
            //{
            //    Console.WriteLine($"{currentParticipant.Name, -15} {currentParticipant.JoinTime, -15} {currentParticipant.LeaveTime, -15}");
            //    //Console.WriteLine(currentParticipant);
            //}
            

        }
    }
}
