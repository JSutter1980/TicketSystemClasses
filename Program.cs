﻿string file = "TicketData.txt";
string choice;
do
{
    //declare ticket list
    //List ticketList = new List<Ticket>
    //if(file exists){
        //read each line
        //create new ticket obj
        //add to list
    //}
    Console.WriteLine("1) Read Ticket Information.");
    Console.WriteLine("2) Create New Ticket.");
    Console.WriteLine("Enter any other key to exit.");
    
    choice = Console.ReadLine();

    if (choice == "1")
    {
        //MAKE SURE THE FILE IS EMPTY
        //loop through ticket list
        //for(ticket in ticketList){
            //print ticket data
            //write to file
        //}
    }
    else if (choice == "2")
    {
        Ticket ticket = new Ticket();

        Console.WriteLine("Ticket Summery");
        ticket.summary = Console.ReadLine();

        Console.WriteLine("Enter Ticket Status");
        ticket.status = Console.ReadLine();

        Console.WriteLine("Enter Ticket Priority");
        ticket.priority = Console.ReadLine();

        Console.WriteLine("Who Submitted Ticket?");
        ticket.owner = Console.ReadLine();

        Console.WriteLine("Who To Assign to Ticket?");
        ticket.assign = Console.ReadLine();

        Console.WriteLine("Who is Watching Ticket?");
        ticket.watch = Console.ReadLine();

        //add ticket to list
    }
} while (choice == "1" || choice == "2");