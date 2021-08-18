using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cateen_Cashier
{
    // Validating TextBoxes
    public static class Validation
    {
        // Validating Product Name, Category Name
        public static bool validateCategoryName(String Input_text)
        {
            String pattren = @"^[A-z 0-9]+$";
            return Regex.IsMatch(Input_text, pattren);
        }

        public static bool validateID(String Input_text)
        {
            String pattren = @"^[0-9]+$";
            return Regex.IsMatch(Input_text, pattren);
        }
        // Validating Price
        public static bool validatePrice(String Input_text)
        {
            String pattern = @"^([1-9][0-9]{,2}(,[0-9]{3})*|[0-9]+)(\.[0-9]{1,2})?$";
            return Regex.IsMatch(Input_text, pattern);
        }

        public static bool validateQuantity(String Input_text)
        {
            String pattern = @"^[1-9][0-9]*$";
            return Regex.IsMatch(Input_text, pattern);
        }

        // Customer Card Validation
        public static bool validateCustCard(String Input_text)
        {
            String pattern = @"^[\d]+$";
            return Regex.IsMatch(Input_text, pattern);
        }

        // Customer ID Validation
        public static bool validateCustID(String Input_text)
        {
            String pattern = @"^[1-9][\d]{2}-[\d]{7}$";
            return Regex.IsMatch(Input_text, pattern);
        }
        // Customer Name Validation
        public static bool validateCustName(String Input_text)
        {
            String pattern = @"^[A-z -]{3,}$";
            return Regex.IsMatch(Input_text, pattern);
        }
        // Customer Email Validation
        public static bool validateCustEmail(String Input_text)
        {
            String pattern = @"^[^-.][\w-.]+@[a-zA-Z]+\.[a-zA-Z]{2,3}(\.[a-zA-Z]{2,3})?$";
            return Regex.IsMatch(Input_text, pattern);
        }
        // Customer Phone Validation
        public static bool validateCustPhone(String Input_text)
        {
            //String pattern = @"^(\+|0)\d{9,12}$";
            String pattern = @"(^07[0-9]{8}$)|(^00937[0-9]{8}$)|(^\+937[0-9]{8}$)|(^\+932[0-9]{8}$)|(^00932[0-9]{8}$)|(^020[1-9]{7}$)";
            return Regex.IsMatch(Input_text, pattern);
        }
        // Search Validation
        public static bool validateSeach(String Input_text)
        {
            String pattern = @"^[\w\d @\.-]+$";
            if (Input_text == "")
            {
                return true;
            }
            else {
                return Regex.IsMatch(Input_text, pattern); }
        }

        public static bool validateAdderss (String Input_text)
        {
            //
            String pattern = @"^[\w-#]{2}[\w -#,.]+$";
                return Regex.IsMatch(Input_text, pattern);
            }

    }
}
