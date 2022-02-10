﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegisterationProgram
{
    public class Pattern
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Arjun

        //Method for first name 
        public bool validateFirstName(string fname)
        {

            return Regex.IsMatch(fname, REGEX_FIRSTNAME);
        }
        public static string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Jaiswal
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, REGEX_LASTNAME);
        }
    }
}