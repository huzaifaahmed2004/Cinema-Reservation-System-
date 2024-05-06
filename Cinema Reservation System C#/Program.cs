using System;
using System.IO;

namespace ConsoleApp43
{
    class Program
    { static void User(String Name,String Pass)
        {
            int Uchoice;
            do
            {
                do
                {
                    Console.Clear();
                    var MovieF1 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 1.txt";
                    var MovieF2 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 2.txt";
                    var MovieF3 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 3.txt";
                    var MovieF4 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 4.txt";
                    var MovieF5 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 5.txt";
                    Console.Write("\tHome\n===========================\n\n1)View Movies\n2)Account Info\n3)Logout\n\n===========================\n\nEnter your Choice:");
                    Uchoice = int.Parse(Console.ReadLine());
                    string[] Mov = new string[5];
                    string[] Act = new string[5];
                    string[] Abt = new string[5];
                    string[] GPrice = new string[5];
                    string[] PPrice = new string[5];
                    string[] datnTime = new string[5];
                    string[] Location = new string[5];
                    {//Movie1
                        StreamReader san = new StreamReader(File.Open(MovieF1, FileMode.Open));
                        {
                            Mov[0] = san.ReadLine();
                            Act[0] = san.ReadLine();
                            Abt[0] = san.ReadLine();
                            GPrice[0] = san.ReadLine();
                            PPrice[0] = san.ReadLine();
                            datnTime[0] = san.ReadLine();
                            Location[0] = san.ReadLine();
                        }
                        san.Close();
                    }

                    {//Movie2
                        StreamReader sa = new StreamReader(File.Open(MovieF2, FileMode.Open));
                        {
                            Mov[1] = sa.ReadLine();
                            Act[1] = sa.ReadLine();
                            Abt[1] = sa.ReadLine();
                            GPrice[1] = sa.ReadLine();
                            PPrice[1] = sa.ReadLine();
                            datnTime[1] = sa.ReadLine();
                            Location[1] = sa.ReadLine();
                        }
                        sa.Close();
                    }
                    {//Movie3
                        StreamReader saa = new StreamReader(File.Open(MovieF3, FileMode.Open));
                        {
                            Mov[2] = saa.ReadLine();
                            Act[2] = saa.ReadLine();
                            Abt[2] = saa.ReadLine();
                            GPrice[2] = saa.ReadLine();
                            PPrice[2] = saa.ReadLine();
                            datnTime[2] = saa.ReadLine();
                            Location[2] = saa.ReadLine();
                        }
                        saa.Close();
                    }
                    {//Movie4
                        StreamReader sar = new StreamReader(File.Open(MovieF4, FileMode.Open));
                        {
                            Mov[3] = sar.ReadLine();
                            Act[3] = sar.ReadLine();
                            Abt[3] = sar.ReadLine();
                            GPrice[3] = sar.ReadLine();
                            PPrice[3] = sar.ReadLine();
                            datnTime[3] = sar.ReadLine();
                            Location[3] = sar.ReadLine();
                        }
                        sar.Close();
                    }
                    { //Movie5
                        StreamReader saw = new StreamReader(File.Open(MovieF5, FileMode.Open));
                        {
                            Mov[4] = saw.ReadLine();
                            Act[4] = saw.ReadLine();
                            Abt[4] = saw.ReadLine();
                            GPrice[4] = saw.ReadLine();
                            PPrice[4] = saw.ReadLine();
                            datnTime[4] = saw.ReadLine();
                            Location[4] = saw.ReadLine();
                        }
                        saw.Close();
                    }
                    Console.Clear();
                    switch (Uchoice)
                    {
                        case 1:
                            Console.WriteLine("\tMovies\n===========================\n\n");
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine(i + 1 + ") " + Mov[i]);
                            }
                            Console.WriteLine("\n\n===========================\n\n1)View details of the Movie\n2)Go Back");
                            Console.Write("\nEnter Your Coice: ");
                            int opt = int.Parse(Console.ReadLine());
                            if (opt == 1)
                            {
                                Console.Write("\nSelect Movie: ");
                                int chice = int.Parse(Console.ReadLine());
                                Console.Clear();
                                for (int l = 0; l < 5; l++)
                                {
                                    if (chice == l + 1)
                                    {
                                        Console.WriteLine("================================\nMovie Name: {0}\n\nActors: {1}\n\nAbout:\n{2}\n\nDate & Time: {3}\n\nLocation: {4}\n\nPrice of Golden Class = {5} Rs\nPrice of Platinum Class = {6} Rs\n\n================================", Mov[l], Act[l], Abt[l], datnTime[l], Location[l], GPrice[l], PPrice[l]);
                                    }
                                }
                                Console.WriteLine("\n\n1)Buy Ticket\n2)Go Back");
                                Console.Write("\nEnter your Choice: ");
                                int option = int.Parse(Console.ReadLine());
                                if (option == 1)
                                {
                                    Console.Write("\nYou want Ticket in: \n\n1)Gold class (Price = {0})\n2)Platinum Class (Price = {1})\n\nEnter Your Choice:", GPrice[chice - 1], PPrice[chice - 1]);
                                    int optionnn = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    if (optionnn == 1)
                                    {

                                        Console.WriteLine("\t\tTicket\n\t======================================================\n\tName          : {0}\n\tMovie Title   : {1}\n\tAmount        : {2} Rs\n\tLocation      : {3}\n\tDate & Time   : {4}\n\tTicket Class  : Gold\n\n\t======================================================", Name, Mov[chice - 1], GPrice[chice - 1], Location[chice - 1], datnTime[chice - 1]);
                                        Console.Write("\nPress Enter to Continue");
                                        string Enter = Console.ReadLine();
                                    }
                                    else if (optionnn == 2)
                                    {

                                        Console.WriteLine("\t\tTicket\n\t======================================================\n\tName          : {0}\n\tMovie Title   : {1}\n\tAmount        : {2} Rs\n\tLocation      : {3}\n\tDate & Time   : {4}\n\tTicket Class  : Platinum\n\n\t======================================================", Name, Mov[chice - 1], PPrice[chice - 1], Location[chice - 1], datnTime[chice - 1]);
                                        Console.Write("\nPress Enter to Continue");
                                        string Enter = Console.ReadLine();
                                    }

                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("\tProfile\n=======================\n\nUsername = {0}\nPassword = {1}\n\n=======================", Name, Pass);
                            Console.WriteLine("Press Enter to Continue");
                            string ENTER = Console.ReadLine();
                            break;
                    }
                } while (Uchoice == 1 || Uchoice == 2);
            } while (Uchoice != 3);
        }
        static void DeletingMovie(string b)
        {
            using (var fs = new FileStream(b, FileMode.Truncate))
            {
            }
        }
        static void Writtingfile(string a)
        {
            {//Writing Movie
                StreamWriter sw = File.AppendText(a);
                {//Movie Name
                    Console.Write("Enter Movie Name: ");
                    string MName = Console.ReadLine();
                    sw.WriteLine(MName);
                    //Actor Name
                    Console.Write("Enter Name of Actors in {0}: ", MName);
                    string AName = Console.ReadLine();
                    sw.WriteLine(AName);
                    //About movie
                    Console.Write("Enter About {0}: ", MName);
                    string ABOUT = Console.ReadLine();
                    sw.WriteLine(ABOUT);
                    //Golden Ticket Price
                    Console.Write("Enter price of Golden Class Ticket: ");
                    string Price = Console.ReadLine();
                    sw.WriteLine(Price);
                    Console.Write("Enter price of Platinum Class Ticket: ");
                    Price = Console.ReadLine();
                    sw.WriteLine(Price);
                    //DatenTime
                    Console.Write("Enter Date & Time:  ");
                    string DatenTime = Console.ReadLine();
                    sw.WriteLine(DatenTime);
                    //Location
                    Console.Write("Enter Location: ");
                    string Location = Console.ReadLine();
                    sw.WriteLine(Location);
                }
                Console.Write("\n\nPress Enter to Continue");
                string enter = Console.ReadLine();
                sw.Close();
            }
        }

        static void Main(string[] args)
        {
            int Choice;
            do
            {
                string AN, APass, SAN = "Admin", SAPass = "0900";
                var MyFile = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Signups.txt";
                Console.WriteLine("1) Signup\n2) Login as User\n3) Login as Admin\n4) Exit");

                Console.Write("\nEnter Your Choice (1,2,3): ");
                 Choice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (Choice)
                {
                    case 1:
                        {
                           
                            string SUN, SPass = string.Empty;
                            
                            Console.WriteLine("Signup\n");
                            Console.Write("Username = ");
                            SUN = Console.ReadLine();
                            Console.Write("Password = ");
                            SPass = Console.ReadLine();
                            StreamWriter sw = File.AppendText(MyFile);
                            {

                                sw.WriteLine(SUN);
                                sw.WriteLine(SPass);
                                sw.Close();
                            }
                            Console.WriteLine("Succesful");
                            Console.WriteLine("Press enter to continue");
                            string Enter = Console.ReadLine();
                            Console.Clear();
                            User(SUN, SPass);
                        }

                        break;
                    case 2:
                        {
                            string UN, Pass = string.Empty;
                            string[] UN1 = new string[10];
                            string[] Pass1 = new string[10];
                            do
                            {
                                Console.WriteLine("Login\n");

                                Console.Write("Username = ");
                                UN = Console.ReadLine();
                                Console.Write("Password = ");
                                Pass = Console.ReadLine();
                                StreamReader sr = new StreamReader(File.Open(MyFile, FileMode.Open));
                                {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        UN1[i] = sr.ReadLine();
                                        Pass1[i] = sr.ReadLine();
                                    }

                                }
                                sr.Close();

                                if ((UN == UN1[0] && Pass == Pass1[0]) || (UN == UN1[1] && Pass == Pass1[1]) || (UN == UN1[2] && Pass == Pass1[2]) || (UN == UN1[3] && Pass == Pass1[3]) || (UN == UN1[4] && Pass == Pass1[04]) || (UN == UN1[5] && Pass == Pass1[5]) || (UN == UN1[6] && Pass == Pass1[6]) || (UN == UN1[7] && Pass == Pass1[7]) || (UN == UN1[8] && Pass == Pass1[8]) || (UN == UN1[9] && Pass == Pass1[9]))
                                {
                                    Console.WriteLine("Successful");
                                    Console.WriteLine("Press enter to continue");
                                    string Enter = Console.ReadLine();
                                    Console.Clear();
                                    User(UN, Pass);
                                }
                                else
                                {
                                    Console.WriteLine("\nEntered Name or Password is wrong\n\nTry Again\n");
                                    Console.WriteLine("Press enter to continue");
                                    string Enter = Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            while ((UN != UN1[0] || Pass != Pass1[0]) && (UN != UN1[1] || Pass != Pass1[1]) && (UN != UN1[2] || Pass != Pass1[2]) && (UN != UN1[3] || Pass != Pass1[3]) && (UN != UN1[4] || Pass != Pass1[04]) && (UN != UN1[5] || Pass != Pass1[5]) && (UN != UN1[6] || Pass != Pass1[6]) && (UN != UN1[7] || Pass != Pass1[7]) && (UN != UN1[8] || Pass != Pass1[8]) && (UN != UN1[9] || Pass != Pass1[9]));
                        }

                        break;
                    case 3:
                        {
                            do
                            {
                                Console.WriteLine("\tLogin\n===========================\n");
                                Console.Write("Admin Name = ");
                                AN = Console.ReadLine();
                                Console.Write("Password = ");
                                APass = Console.ReadLine();
                                Console.WriteLine("\n===========================");
                                if (AN == SAN && APass == SAPass)
                                {
                                    Console.WriteLine("Successful");
                                    Console.WriteLine("Press enter to continue");
                                    string Enter = Console.ReadLine();
                                    Console.Clear();
                                    int cho;
                                    do
                                    {
                                        do
                                        {
                                            var MovieF1 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 1.txt";
                                            var MovieF2 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 2.txt";
                                            var MovieF3 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 3.txt";
                                            var MovieF4 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 4.txt";
                                            var MovieF5 = @"C:\Users\Huzaifa Ahmed\OneDrive\Desktop\Project CP\Movie 5.txt";

                                            Console.WriteLine("\tAdmin\n===========================\n\n1)View Movies\n2)Add Movie\n3)Delete Movie\n4)Logout\n\n===========================");
                                            Console.Write("\n\nEnter Your Choice: ");
                                            cho = int.Parse(Console.ReadLine());
                                            Console.Clear();
                                            string[] Mov = new string[5];
                                            string[] Act = new string[5];
                                            string[] Abt = new string[5];
                                            string[] GPrice = new string[5];
                                            string[] PPrice = new string[5];
                                            string[] datnTime = new string[5];
                                            string[] Location = new string[5];
                                            {//Movie1
                                                StreamReader san = new StreamReader(File.Open(MovieF1, FileMode.Open));
                                                {
                                                    Mov[0] = san.ReadLine();
                                                    Act[0] = san.ReadLine();
                                                    Abt[0] = san.ReadLine();
                                                    GPrice[0] = san.ReadLine();
                                                    PPrice[0] = san.ReadLine();
                                                    datnTime[0] = san.ReadLine();
                                                    Location[0] = san.ReadLine();
                                                }
                                                san.Close();
                                            }

                                            {//Movie2
                                                StreamReader sa = new StreamReader(File.Open(MovieF2, FileMode.Open));
                                                {
                                                    Mov[1] = sa.ReadLine();
                                                    Act[1] = sa.ReadLine();
                                                    Abt[1] = sa.ReadLine();
                                                    GPrice[1] = sa.ReadLine();
                                                    PPrice[1] = sa.ReadLine();
                                                    datnTime[1] = sa.ReadLine();
                                                    Location[1] = sa.ReadLine();
                                                }
                                                sa.Close();
                                            }
                                            {//Movie3
                                                StreamReader saa = new StreamReader(File.Open(MovieF3, FileMode.Open));
                                                {
                                                    Mov[2] = saa.ReadLine();
                                                    Act[2] = saa.ReadLine();
                                                    Abt[2] = saa.ReadLine();
                                                    GPrice[2] = saa.ReadLine();
                                                    PPrice[2] = saa.ReadLine();
                                                    datnTime[2] = saa.ReadLine();
                                                    Location[2] = saa.ReadLine();
                                                }
                                                saa.Close();
                                            }
                                            {//Movie4
                                                StreamReader sar = new StreamReader(File.Open(MovieF4, FileMode.Open));
                                                {
                                                    Mov[3] = sar.ReadLine();
                                                    Act[3] = sar.ReadLine();
                                                    Abt[3] = sar.ReadLine();
                                                    GPrice[3] = sar.ReadLine();
                                                    PPrice[3] = sar.ReadLine();
                                                    datnTime[3] = sar.ReadLine();
                                                    Location[3] = sar.ReadLine();
                                                }
                                                sar.Close();
                                            }
                                            { //Movie5
                                                StreamReader saw = new StreamReader(File.Open(MovieF5, FileMode.Open));
                                                {
                                                    Mov[4] = saw.ReadLine();
                                                    Act[4] = saw.ReadLine();
                                                    Abt[4] = saw.ReadLine();
                                                    GPrice[4] = saw.ReadLine();
                                                    PPrice[4] = saw.ReadLine();
                                                    datnTime[4] = saw.ReadLine();
                                                    Location[4] = saw.ReadLine();
                                                }
                                                saw.Close();
                                            }
                                            switch (cho)
                                            {
                                                case 1:
                                                    {
                                                        for (int i = 0; i < 5; i++)
                                                        {
                                                            Console.WriteLine(i + 1 + ") " + Mov[i]);
                                                        }
                                                        Console.WriteLine("\n\n1)View details of the Movie\n2)Go Back");
                                                        Console.Write("\nEnter Your Coice: ");
                                                        int opt = int.Parse(Console.ReadLine());
                                                        if (opt == 1)
                                                        {


                                                            Console.Write("\nSelect Movie: ");
                                                            int chice = int.Parse(Console.ReadLine());
                                                            Console.Clear();

                                                            for (int i = 0; i < 5; i++)
                                                            {
                                                                if (chice == i + 1)
                                                                {
                                                                    Console.WriteLine("================================\nMovie Name: {0}\n\nActors:\n{1}\n\nAbout:\n{2}\n\nDate & Time: {3}\n\nLocation: {4}\n\nPrice of Golden Class = {5} Rs\nPrice of Platinum Class = {6} Rs\n\n================================", Mov[i], Act[i], Abt[i],datnTime[i], Location[i], GPrice[i], PPrice[i]);
                                                                }
                                                            }

                                                            Console.Write("\n\nPress Enter to Continue");
                                                            string enter = Console.ReadLine();
                                                        }
                                                    }
                                                    break;
                                                case 2:
                                                    {
                                                        if (Mov[0] == null)
                                                        {
                                                            Writtingfile(MovieF1);
                                                        }
                                                        else if (Mov[1] == null)
                                                        {
                                                            Writtingfile(MovieF2);
                                                        }
                                                        else if (Mov[2] == null)
                                                        {
                                                            Writtingfile(MovieF3);
                                                        }
                                                        else if (Mov[3] == null)
                                                        {
                                                            Writtingfile(MovieF4);
                                                        }
                                                        else if (Mov[4] == null)
                                                        {
                                                            Writtingfile(MovieF5);
                                                        }


                                                    }
                                                    break;
                                                case 3:
                                                    {
                                                        for (int i = 0; i < 5; i++)
                                                        {
                                                            Console.WriteLine(i + 1 + ") " + Mov[i]);
                                                        }


                                                        Console.Write("\nSelect Movie you want to delete: ");
                                                        int chice = int.Parse(Console.ReadLine());
                                                        Console.Clear();
                                                        if (chice == 1)
                                                        {
                                                            DeletingMovie(MovieF1);
                                                        }
                                                        else if (chice == 2)
                                                        {
                                                            DeletingMovie(MovieF2);
                                                        }
                                                        else if (chice == 3)
                                                        {
                                                            DeletingMovie(MovieF3);
                                                        }
                                                        else if (chice == 4)
                                                        {
                                                            DeletingMovie(MovieF4);
                                                        }
                                                        else if (chice == 5)
                                                        {
                                                            {
                                                                DeletingMovie(MovieF5);
                                                            }
                                                        }


                                                    }
                                                    break;
                                            }
                                            Console.Clear();
                                        } while (cho == 1 || cho == 2 || cho == 3);
                                    } while (cho != 4);
                                }
                                else if (AN != SAN || APass != SAPass)
                                {
                                    Console.WriteLine("\nEntered Name or Password is wrong\n\nTry Again\n");
                                    Console.WriteLine("Press enter to continue");
                                    string Enter = Console.ReadLine();
                                    Console.Clear();
                                }
                            } while (AN != SAN || APass != SAPass);
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice");
                        break;
                }

            } while (Choice == 1 || Choice == 3 || Choice == 2);
    }
    } }