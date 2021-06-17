using System.Collections.Generic;

namespace CivCampusExercise_2021.models
{
    public class TeachingBuilding : Building
    {

        public List<Room> Rooms { get; set; }

        
        public TeachingBuilding(string buildingId) : base(buildingId)
        {
            this.Rooms = new List<Room>();
        }

        public void AddRoom(int capacity, int roomNo) {
            //TODO: make roomId a string created from buildingId + RoomNo as text
            string roomId = buildingid + roomNo;
            
            //TODO: fix the below to add the new room to the rooms list
            Room r1 = new Room(0, 0, null);
            Rooms.Add(r1);
        }

        /// <summary>
        /// Returns a string with the list of rooms seperated by commas
        /// </summary>
        /// <returns>A string representing the rooms</returns>
        public string ListRooms() {
            string output = "";

            foreach(var room in Rooms) {
                output += $"{room.RoomId}, {room.Capacity}\n";
            }
            return output;
        }

        public int GetBuildingCapacity() {
            int total = 0;
            return total; 
         }   
           
        // TODO: calculate and store into total all of the room capacities for the building combined
        public int GetBuildingsTotal() {
            foreach(var BuildingId in Building) {
                buildingstotal += $"{BuildingId.Building}, {total.GetBuildingCapacity}\n";
            }
            return buildingstotal;
        }
        
    }
}