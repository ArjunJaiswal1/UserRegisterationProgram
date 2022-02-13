using UserRegistration;
class program
{
    static void Main(string[] args)
    {
        Pattern pattern = new Pattern();
        //Console.WriteLine(pattern.validateFirstName("Arjun"));
        //Console.WriteLine(pattern.validateLastName("Jaiswal"));
        Console.WriteLine(pattern.valiadtaeEmail("arjunjaiswal8065@gmail.com"));
        //Console.WriteLine(pattern.valiadtaeEmail("arjunjaiswal8065@gmail.com"));     
        Console.WriteLine(pattern.validateMobileNumber("91 9821848065"));
    }

}