using System;
using System.Collections.Generic;

namespace PlingPlangPlong_Code
{
    public class PlingPlangPlongCode
    {
        public string PlingPlangPlong(int num)
        {
            var returnString = "";

            if (num < 0)
            {
                if (num % -3 == 0) returnString += "Pling";
                if (num % -5 == 0) returnString += "Plang";
                if (num % -7 == 0) returnString += "Plong";
                else if (num % -3 != 0 && num % -5 != 0) return num.ToString();
            }
            else if (num == 0)
            {
                return "PlingPlangPlong";
            }
            else
            {
                if (num % 3 == 0) returnString += "Pling";
                if (num % 5 == 0) returnString += "Plang";
                if (num % 7 == 0) returnString += "Plong";
                else if (num % 3 != 0 && num % 5 != 0) return num.ToString();
            }
            return returnString;
        }
    }
}
