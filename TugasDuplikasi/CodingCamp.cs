using System;
using System.Collections.Generic;

namespace TugasDuplikasi
{
    class CodingCamp : Participant
    {
        public string CodingCampId { get; set; }
        public string CodingCampName { get; set; }
        public List<Participant> Participants { get; set; }

        public static List<CodingCamp> CampList = new List<CodingCamp>();

        public CodingCamp() {
            Participants = new List<Participant>();
        }

        public CodingCamp(string codingCampId, string codingCampName)
        {
            CodingCampId = codingCampId;
            CodingCampName = codingCampName;
            Participants = new List<Participant>();
        }

        public static void AddCodingCamp()
        {
            try
            {
                CodingCamp newClass = new CodingCamp();

                Console.Write("INSERT ID: ");
                newClass.CodingCampId = Console.ReadLine();

                Console.Write("INSERT NAME: ");
                newClass.CodingCampName = Console.ReadLine();

                CampList.Add(newClass);
                Console.WriteLine("Insert Success!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteCodingCamp()
        {
            if (CampList.Count == 0)
            {
                Console.WriteLine("[NO DATA]");
            }
            else
            {
                int id;
                try
                {
                    ShowCodingCampParticipant();
                    Console.Write("Pilih Kelas: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    CampList.RemoveAt(id - 1);
                    Console.WriteLine("Delete Success!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void UpdateCodingCamp()
        {
            if (CampList.Count == 0)
            {
                Console.WriteLine("[NO DATA]");
            }
            else
            {
                int id;
                try
                {
                    ShowCodingCampParticipant();
                    Console.Write("Pilih Kelas: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"ID: {CampList[id - 1].CodingCampId}\nNAME: {CampList[id - 1].CodingCampName}");
                    Console.Write("INSERT ID: ");
                    CampList[id - 1].CodingCampId = Console.ReadLine();
                    Console.Write("INSERT NAME: ");
                    CampList[id - 1].CodingCampName = Console.ReadLine();
                    Console.WriteLine("Update Success!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void InsertParticipant()
        {
            if (CampList.Count == 0)
            {
                Console.WriteLine("[NO DATA]");
            }
            else
            {
                int choice;
                try
                {
                    ShowCodingCampParticipant();
                    Console.Write("Pilih Kelas: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    Participant data = new Participant();
                    data.CodingCamp = CampList[choice - 1];
                    Console.WriteLine("INPUT PARTICIPANT");

                    Console.Write("NIK: ");
                    data.Nik = Console.ReadLine();

                    Console.Write("NAMA: ");
                    data.ParticipantName = Console.ReadLine();

                    CampList[choice - 1].Participants.Add(data);
                    Console.WriteLine("Insert Success!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void DeleteParticipant()
        {
            if (CampList.Count == 0)
            {
                Console.WriteLine("[NO DATA]");
            }
            else
            {
                int choice;
                int choice2;
                int position = 1;
                try
                {
                    ShowCodingCampParticipant();
                    Console.Write("Pilih Kelas: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (CampList[choice -1].Participants.Count == 0)
                    {
                        Console.WriteLine("[NO DATA]");
                    }
                    else
                    {
                        foreach (Participant parti in CampList[choice - 1].Participants)
                        {
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine($"No. {position}");
                            Console.WriteLine($"NIK : {parti.Nik}");
                            Console.WriteLine($"NAMA : {parti.ParticipantName}");
                            Console.WriteLine();
                            ++position;
                        }
                        Console.Write("Pilih No. Participant: ");
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        CampList[choice - 1].Participants.RemoveAt(choice2 - 1);
                        Console.WriteLine("Delete Success!");
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void UpdateParticipant()
        {
            if (CampList.Count == 0)
            {
                Console.WriteLine("[NO DATA]");
            }
            else
            {
                int choice;
                int choice2;
                int position = 1;
                try
                {
                    ShowCodingCampParticipant();
                    Console.Write("Pilih Kelas: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (CampList[choice - 1].Participants.Count == 0)
                    {
                        Console.WriteLine("[NO DATA]");
                    }
                    else
                    {
                        foreach (Participant parti in CampList[choice - 1].Participants)
                        {
                            if (parti.CodingCamp.CodingCampId.Equals(CampList[choice - 1].CodingCampId))
                            {
                                Console.WriteLine("-----------------------------");
                                Console.WriteLine($"No. {position}");
                                Console.WriteLine($"NIK : {parti.Nik}");
                                Console.WriteLine($"NAMA : {parti.ParticipantName}");
                                Console.WriteLine();
                                ++position;
                            }
                        }
                        Console.Write("Pilih No. Participant: ");
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"NIK: {CampList[choice - 1].Participants[choice2 - 1].Nik}\nNAME: {CampList[choice - 1].Participants[choice2 - 1].ParticipantName}");
                        Console.Write("INSERT NIK: ");
                        CampList[choice - 1].Participants[choice2 - 1].Nik = Console.ReadLine();
                        Console.Write("INSERT NAMA: ");
                        CampList[choice - 1].Participants[choice2 - 1].ParticipantName = Console.ReadLine();
                        Console.WriteLine("Update Success!");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void SearchParticipant()
        {
            if (CampList.Count == 0)
            {
                Console.WriteLine("[NO DATA]");
            }
            else
            {
                string search;
                int index = 0;
                try
                {
                    Console.Write("Cari Nama: ");
                    search = Console.ReadLine();
                    if (CampList.Count == 0)
                    {
                        Console.WriteLine("[NO DATA]");
                    }
                    else
                    {
                        foreach (var camp in CampList)
                        {
                            if (CampList[index].Participants.Count > 0)
                            {
                                int index2 = 0;
                                foreach (Participant parti in CampList[index].Participants)
                                {
                                    if (CampList[index].Participants[index2].ParticipantName.Contains(search))
                                    {
                                        Console.WriteLine("-----------------------------");
                                        Console.WriteLine($"NIK : {parti.Nik}");
                                        Console.WriteLine($"NAMA : {parti.ParticipantName}");
                                        Console.WriteLine($"CODING CAMP: {camp.CodingCampName}");
                                    }
                                    ++index2;
                                }
                            }
                            ++index;
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void ShowCodingCamp()
        {
            int index = 0;
            if (CampList.Count == 0)
            {
                Console.WriteLine("[NO DATA]");
            }
            else
            {
                try
                {
                    foreach (CodingCamp kelas in CampList)
                    {
                        Console.WriteLine($"ID: {kelas.CodingCampId} ");
                        Console.WriteLine($"NAME: {kelas.CodingCampName} ");
                        Console.WriteLine("  ===Daftar Participant===   ");
                        if (CampList[index].Participants.Count == 0)
                        {
                            Console.WriteLine("[NO DATA]");
                        }
                        else
                        {
                            foreach (Participant parti in CampList[index].Participants)
                            {
                                Console.WriteLine("-----------------------------");
                                Console.WriteLine($"NIK : {parti.Nik}");
                                Console.WriteLine($"NAMA : {parti.ParticipantName}");
                            }
                        }
                        Console.WriteLine();
                        ++index;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void ShowCodingCampParticipant()
        {
            try
            {
                int position = 1;
                Console.WriteLine("  ===Daftar Coding Camp===   ");
                if (CampList.Count == 0) 
                {
                    Console.WriteLine("[NO DATA]");
                }
                else
                {
                    foreach (CodingCamp kelas in CampList)
                    {
                        Console.WriteLine($"No. {position}");
                        Console.WriteLine($"ID: {kelas.CodingCampId} ");
                        Console.WriteLine($"NAME: {kelas.CodingCampName} ");
                        Console.WriteLine();
                        ++position;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}