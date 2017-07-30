using System;
using System.Text;

namespace PetClinic.Entities
{
    public class Clinic
    {
        private int roomsNumber;
        private RoomsRegister roomsRegister;
        private int occupiedRooms;

        public Clinic(string name, int roomsNumber)
        {
            this.roomsRegister = new RoomsRegister(roomsNumber);
            this.Name = name;
            this.RoomsNumber = roomsNumber;
        }

        public string Name { get; private set; }

        public int RoomsNumber
        {
            get
            {
                return this.roomsNumber;
            }

            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }

                this.roomsNumber = value;
            }
        }

        public bool TryAddPet(Pet pet)
        {
            foreach (var roomIndex in this.roomsRegister)
            {
                if (this.roomsRegister[roomIndex] == null)
                {
                    this.roomsRegister[roomIndex] = pet;
                    this.occupiedRooms++;
                    return true;
                }
            }

            return false;
        }

        public bool TryReleasePet()
        {
            int centralRoomIndex = this.RoomsNumber / 2;
            for (int i = 0; i < this.RoomsNumber; i++)
            {
                int currIndex = (centralRoomIndex + i) % this.RoomsNumber;
                if (this.roomsRegister[currIndex] != null)
                {
                    this.roomsRegister[currIndex] = null;
                    this.occupiedRooms--;
                    return true;
                }
            }

            return false;
        }

        public string Print()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < this.RoomsNumber; i++)
            {
                sb.AppendLine(this.Print(i));
            }

            return sb.ToString().Trim();
        }

        public string Print(int roomIndex)
        {
            return this.roomsRegister[roomIndex]?.ToString() ?? "Room empty";
        }

        public bool HasEmptyRooms()
        {
            return this.occupiedRooms < this.RoomsNumber;
        }
    }
}
