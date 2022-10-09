using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    //Create an console application to book train tickets.
    //Create a Passanger class with (Name, Age)
    //write a function called TicketBooking(int no_of_tickets) that takes no.of tickets to be booked.
    //If the no of tickets is > 2 per booking, raise an user defined exception, and print "cannot book more than 2 tickets".
    //Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.

    class Program2
    {
        static void Main()
        {
            Program2 program2 = new Program2();
            Console.ReadLine();
        }
    }

namespace Assignment_5
    {
        //Create an console application to book train tickets.
        //Create a Passanger class with (Name, Age)
        //write a function called TicketBooking(int no_of_tickets) that takes no.of tickets to be booked.
        //If the no of tickets is > 2 per booking, raise an user defined exception, and print "cannot book more than 2 tickets".
        //Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.

        class Program2

        {
            static void Main()
            {
                Passenger passenger = new Passenger();
                bool IsBookingFailed;
                do //once booking failed it will asks for book tickets again until the IsbookingFailed == false
                {
                    IsBookingFailed = false;

                    string name1;
                    string name2;
                    int age2;
                    int age1;
                    Console.WriteLine("Enter How Many Tickets");
                    try
                    {
                        int noOfTickets = Convert.ToInt32(Console.ReadLine());

                        if (noOfTickets > 2) //greater than two tickets throws exception
                        {
                            passenger.TicketBooking(noOfTickets);
                        }

                        else if (noOfTickets == 2) //if two tickets gets two passanger details
                        {
                            Console.WriteLine("Enter the Name of the Passanger: ");
                            name1 = Console.ReadLine();
                            Console.WriteLine("Enter the Age of the Passanger: ");
                            age1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Name of the Passanger: ");
                            name2 = Console.ReadLine();
                            Console.WriteLine("Enter the Age of the Passanger: ");
                            age2 = Convert.ToInt32(Console.ReadLine());
                            passenger.TwoPassanger(name1, name2, age1, age2);
                            passenger.TicketBooking(noOfTickets);
                        }
                        else //if one ticket gets one passenger details.
                        {
                            Console.WriteLine("Enter the Name of the Passanger: ");
                            name1 = Console.ReadLine();
                            Console.WriteLine("Enter the Age of the Passanger: ");
                            age1 = Convert.ToInt32(Console.ReadLine());
                            passenger.OnePassenger(name1, age1);
                            passenger.TicketBooking(noOfTickets);

                        }
                    }
                    catch (NoOfPersonExceedsException NE) //no of person exceeds than 2 userdefine exception occurs
                    {
                        Console.WriteLine("Ticket Booking Failed: " + NE.Message);
                        IsBookingFailed = true;
                    }
                    catch (FormatException) //user gives worng type of input this exception occurs
                    {
                        Console.WriteLine("Invalid details");
                        IsBookingFailed = true;
                    }
                } while (IsBookingFailed == true); //if it is true it will ask for book tickets after failed booking

                Console.ReadLine();
            }

        }
        class Passenger
        {
            string Name1;
            string Name2;
            int Age1;
            int Age2;
            public void OnePassenger(string Name1, int Age1)
            {
                this.Name1 = Name1;
                this.Age1 = Age1;
            }
            public void TwoPassanger(string Name1, string Name2, int Age1, int Age2)
            {

                this.Name1 = Name1;
                this.Age1 = Age1;
                this.Age2 = Age2;
                this.Name2 = Name2;


            }
            public void TicketBooking(int noOfTickets)
            {
                if (noOfTickets > 2)
                {
                    throw (new NoOfPersonExceedsException("Cannot book more than two tickets "));
                }
                else
                {

                    TicketStatus(noOfTickets);
                }
            }
            public void TicketStatus(int noOfTickets) //Displaying Tickets
            {
                if (noOfTickets == 2) //printing ticket if two tickets are there
                {
                    Console.WriteLine();
                    Console.WriteLine("***********Thank you for booking tickets********");
                    Console.WriteLine("Passenger Name: " + Name1);
                    Console.WriteLine("Passanger Age: " + Age1);
                    Console.WriteLine("Passenger Name: " + Name2);
                    Console.WriteLine("Passanger Age: " + Age2);
                    Console.WriteLine("Total number of passangers: " + noOfTickets);
                    Console.WriteLine();

                    Console.WriteLine("*********Ticket Booked Successfully*********");
                }
                else  //printing ticket if one ticket is there
                {
                    Console.WriteLine();
                    Console.WriteLine("***********Thank you for booking tickets********");
                    Console.WriteLine("Passenger Name: " + Name1);
                    Console.WriteLine("Passanger Age: " + Age1);
                    Console.WriteLine("Total number of passangers: " + noOfTickets);
                    Console.WriteLine("*********Ticket Booked Successfully*********");
                }
            }
        }
        class NoOfPersonExceedsException : ApplicationException  //UserDefinedException
        {
            public NoOfPersonExceedsException(string msg) : base(msg)
            {

            }
        }
    }

    public Program2()
    {

        bool IsBookingFailed;


        Passenger passenger = new Passenger();
        // Console.WriteLine("Enter the Name And Age");
        do
        {
            IsBookingFailed = false;

            string name;
            int age;
            Console.WriteLine("Enter How Many Tickets");
            try
            {
                int noOfTickets = Convert.ToInt32(Console.ReadLine());

                if (noOfTickets > 2)
                {
                    passenger.TicketBooking(noOfTickets);
                }

                else if (noOfTickets == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("Enter the Name of the Passanger: {0}", i + 1);
                        name = Console.ReadLine();
                        Console.WriteLine("Enter the Age of the Passanger: {0}", i + 1);
                        age = Convert.ToInt32(Console.ReadLine());
                        passenger.TwoPassanger(name, age, i);
                    }
                    passenger.TicketBooking(noOfTickets);
                }
                else
                {
                    Console.WriteLine("Enter the Name of the Passanger: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the Age of the Passanger: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    passenger.OnePassenger(name, age);
                    passenger.TicketBooking(noOfTickets);

                }
            }
            catch (NoOfPersonExceedsException NE)
            {
                Console.WriteLine("Ticket Booking Failed: " + NE.Message);
                IsBookingFailed = true;
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Invalid details");
                IsBookingFailed = true;
            }
        } while (IsBookingFailed == true); // used for get the user inputs again to book the tickets after getting exception

    }
}
class Passenger
{
    private string[] Name = new string[2];
    private int[] Age = new int[2];
    public void OnePassenger(string Name, int Age)
    {
        this.Name[0] = Name;
        this.Age[0] = Age;
    }
    public void TwoPassanger(string Name, int Age, int i)
    {

        this.Name[i] = Name;
        this.Age[i] = Age;

    }
    public void TicketBooking(int noOfTickets)
    {
        if (noOfTickets > 2)
        {
            throw (new NoOfPersonExceedsException("Cannot book more than two tickets "));
        }
        else
        {

            TicketStatus(noOfTickets);// calling the method to print the ticket status along with no of tickets only ticket booking is successfully done.
        }
    }
    public void TicketStatus(int noOfTickets) //Displaying Tickets based on no of tickets booked 
    {
        if (noOfTickets == 2)
        {

            for (int i = 0; i < 2; i++)// if it is two, print the two passenger details and Ticketstatus 
            {
                Console.WriteLine("Passenger Name: " + Name[i]);
                Console.WriteLine("Passanger Age: " + Age[i]);
                Console.WriteLine("Total number of passangers: " + noOfTickets);
                Console.WriteLine();
            }
            Console.WriteLine("*********Ticket Booked Successfully*********");
        }
        else //if it is one, print the two passenger details and Ticketstatus
        {
            Console.WriteLine("Passenger Name: " + Name[0]);
            Console.WriteLine("Passanger Age: " + Age[0]);
            Console.WriteLine("Total number of passangers: " + noOfTickets);
            Console.WriteLine("*********Ticket Booked Successfully*********");
        }
    }
}
class NoOfPersonExceedsException : ApplicationException  //UserDefinedException
{
    public NoOfPersonExceedsException(string msg) : base(msg)
    {

    }
}
}
