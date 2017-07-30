using PetClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetClinic
{
    public class StartUp
    {
        private static Dictionary<string, Pet> allPets = new Dictionary<string, Pet>();
        private static Dictionary<string, Clinic> allClinics = new Dictionary<string, Clinic>();

        public static void Main()
        {
            var commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                var commandArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string commnadType = commandArgs[0];
                commandArgs.RemoveAt(0);

                switch (commnadType)
                {
                    case "Create":
                        CreateEntity(commandArgs);
                        break;

                    case "Add":
                        AddPetToClinic(commandArgs[0], commandArgs[1]);
                        break;

                    case "Release":
                        ReleasePetFromClinic(commandArgs[0]);
                        break;

                    case "HasEmptyRooms":
                        CheckForEmptyRooms(commandArgs[0]);
                        break;

                    case "Print":
                        PrintClinicInfo(commandArgs);
                        break;
                }
            }
        }

        private static void PrintClinicInfo(List<string> commandArgs)
        {
            Clinic clinic = allClinics[commandArgs[0]];
            string result = null;

            if (commandArgs.Count == 1)
            {
                result = clinic.Print();
            }

            else
            {
                int roomIndex = int.Parse(commandArgs[1]) - 1;
                result = clinic.Print(roomIndex);
            }

            Console.WriteLine(result);
        }

        private static void CheckForEmptyRooms(string clinicName)
        {
            Clinic clinic = allClinics[clinicName];
            Console.WriteLine(clinic.HasEmptyRooms());
        }

        private static void ReleasePetFromClinic(string clinicName)
        {
            Clinic clinic = allClinics[clinicName];
            Console.WriteLine(clinic.TryReleasePet());
            
        }

        private static void AddPetToClinic(string petName, string clinicName)
        {
            Pet pet = allPets[petName];
            Clinic clinic = allClinics[clinicName];

            if (clinic.TryAddPet(pet))
            {
                Console.WriteLine(true);
                allPets.Remove(petName);
                return;
            }

            Console.WriteLine(false);
        }

        private static void CreateEntity(List<string> commandArgs)
        {
            var entityType = commandArgs[0];

            if (entityType == "Pet")
            {
                var name = commandArgs[1];
                var age = int.Parse(commandArgs[2]);
                var kind = commandArgs[3];

                allPets.Add(name, new Pet(name, age, kind));
            }

            else
            {
                var name = commandArgs[1];
                var roomsNumber = int.Parse(commandArgs[2]);

                try
                {
                    allClinics.Add(name, new Clinic(name, roomsNumber));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
