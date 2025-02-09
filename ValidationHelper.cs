﻿using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace EventaDesktop
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Validates if the input is a valid email address.
        /// </summary>
        /// <param name="email">The email address to validate.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        public static bool IsValidEmail(string email, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Email can't be empty!";
                return false;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern, RegexOptions.Compiled);

            if (!regex.IsMatch(email))
            {
                errorMessage = "Specify a valid email!";
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validates if the input is a valid username.
        /// </summary>
        /// <param name="username">The username to validate.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        public static bool IsValidUsername(string username, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Username can't be empty!";
                return false;
            }

            if (username.Length < 5 || username.Length > 15)
            {
                errorMessage = "Username must be 5-15 characters in length.";
                return false;
            }

            return true;
        }

        public static bool IsValidPassword(string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Password can't be empty!";
                return false;
            }

            if (password.Length < 5 || password.Length > 15)
            {
                errorMessage = "Password must be 5-15 characters in length.";
                return false;
            }

            // Check if the password contains at least one digit.
            if (!password.Any(char.IsDigit))
            {
                errorMessage = "Password must contain at least one digit.";
                return false;
            }

            return true;
        }

        public static bool ValidateEventDetails(
            string eventName,
            string eventDescription,
            string eventLocation,
            Image eventPhoto,
            string startDate,
            string eventPrice,
            out string errorMessage
            )
        {
            errorMessage = string.Empty;

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(eventName) ||
                string.IsNullOrWhiteSpace(eventDescription) ||
                string.IsNullOrWhiteSpace(eventLocation) ||
                eventPhoto == null ||
                string.IsNullOrWhiteSpace(eventPrice))
            {
                errorMessage = "Please fill all blank fields.";
                return false;
            }

            // Validate date comparison
            if (!DateTime.TryParse(startDate, out DateTime startDateParsed))
            {
                errorMessage = "Enter valid start date.";
                return false;
            }


            // Validate price
            if (!float.TryParse(eventPrice, out float price) || price < 0)
            {
                errorMessage = "Enter a valid price greater than or equal to zero.";
                return false;
            }

            // If everything is valid
            return true;
        }


    }
}
