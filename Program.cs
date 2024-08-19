int i;
for (i = 0; i < 7; i++)
{
    // ask a question
    Console.WriteLine("Enter a course (Y/N)?");
    // input the response
    string? resp = Console.ReadLine()?.ToUpper();
    // if the response is anything other than "Y", stop asking
    if (resp != "Y")
    {
        break;
    }
    // prompt for course name
    Console.WriteLine("Enter the course name.");
    Console.ReadLine();
    // prompt for course grade
    Console.WriteLine("Enter the course grade.");
    Console.ReadLine();
}
