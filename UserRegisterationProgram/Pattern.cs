﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace UserRegistration
{
    public class Pattern
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Arjun
        //Method for first name 
        public bool validateFirstName(string fname)
        {
            return Regex.IsMatch(fname, REGEX_FIRSTNAME);
        }
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$"; //Jaiswal
        // method for last name
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, LAST_NAME_REGEX);
        }
        public static string REGEX_EMAIL = "^[a-zA-Z0-9.]+@[A-Za-z0-9]+.[A-Za-z]{1,4}$"; //arjunjaiswal8065@gmail.com
        //Method for email address
        public bool valiadtaeEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }

        public static string REGEX_MOBILENUMBER = "^+[1-9]{2}[ ][6-9]{1}[0-9]{9}$";

        // method for valid phone number
        public bool validateMobileNumber(string mnumber)
        {
            return Regex.IsMatch(mnumber, REGEX_MOBILENUMBER);

        }


    }
}