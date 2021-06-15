using System;

namespace TugasDuplikasi
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyDataGenerate();
            while (true)
            {
                View();
                int menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (menu == 1)
                {
                    CodingCamp.AddCodingCamp();
                }
                else if (menu == 2)
                {
                    CodingCamp.DeleteCodingCamp();
                }
                else if (menu == 3)
                {
                    CodingCamp.UpdateCodingCamp();
                }
                else if (menu == 4)
                {
                    CodingCamp.ShowCodingCamp();
                }
                else if (menu == 5)
                {
                    CodingCamp.InsertParticipant();
                }
                else if (menu == 6)
                {
                    CodingCamp.DeleteParticipant();
                }
                else if (menu == 7)
                {
                    CodingCamp.UpdateParticipant();
                }
                else if (menu == 8)
                {
                    CodingCamp.SearchParticipant();
                }
                else if (menu == 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void View()
        {
            Console.WriteLine("===MENU===");
            Console.WriteLine("1. Add Coding Camp");
            Console.WriteLine("2. Delete Coding Camp");
            Console.WriteLine("3. Update Coding Camp");
            Console.WriteLine("4. Show Coding Camp");
            Console.WriteLine("5. Add Participant");
            Console.WriteLine("6. Delete Participant");
            Console.WriteLine("7. Update Participant");
            Console.WriteLine("8. Search Participant");
            Console.WriteLine("9. Exit");

            Console.Write("Option (1-4): ");
        }

        private static void DummyDataGenerate()
        {
            CodingCamp codingCamp49 = new CodingCamp("MCC-REG-49-NET", "Coding Camp 49");
            CodingCamp codingCamp48 = new CodingCamp("MCC-REG-48-NET", "Coding Camp 48");
            CodingCamp codingCamp47 = new CodingCamp("MCC-REG-47-Java", "Coding Camp 47");
            CodingCamp codingCamp46 = new CodingCamp("MCC-REG-46-Java", "Coding Camp 46");

            CodingCamp.CampList.Add(codingCamp49);
            CodingCamp.CampList.Add(codingCamp48);
            CodingCamp.CampList.Add(codingCamp47);
            CodingCamp.CampList.Add(codingCamp46);
        }
    }
}