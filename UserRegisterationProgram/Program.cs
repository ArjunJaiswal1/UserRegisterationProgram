﻿using UserRegistration;
class program
{
    static void Main(string[] args)
    {
        Pattern pattern = new Pattern();
        //Console.WriteLine(pattern.validateFirstName("Arjun"));
        //Console.WriteLine(pattern.validateLastName("Jaiswal"));
        //Console.WriteLine(pattern.valiadtaeEmail("arjunjaiswal8065@gmail.com"));
        //Console.WriteLine(pattern.valiadtaeEmail("arjunjaiswal8065@gmail.com"));     
        //Console.WriteLine(pattern.validateMobileNumber("91 9821848065"));
        //Console.WriteLine(pattern.validatePaswordRule1("arj@12"));
        //Console.WriteLine(pattern.validatePaswordRule2("arju@345"));

        Console.WriteLine(pattern.validatePaswordRule3("2@bcf"));
    }

}