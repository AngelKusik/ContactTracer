// Author:              Angelica Kusik (based on prof Kyle Chapman work)
// Last Modified by:    Angelica Kusik
// Original Date:       March 17, 2021
// Last Modified Date:  March 17, 2022
// Project Name:        CustomerClass.cs
// Course:              NETD 2202
// Description:
//  Lab #4
//  A class designed to record of an individual custormer,
//  including if they were contacted or not.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_ContactTracer
{
    /// <summary>
    /// A class designed to record individual customers, including if they were contacted or not.
    /// </summary>
    class CustomerClass
    {
        //Static Private readonly variable to hold the number of customers. 
        //TODO: Should it include readonly??
        private static int Count = 0;

        //Private readonly variable to hold the customers unique id.
        //TODO: Should it include read only??
        private readonly int Id = 0;

        //Private variable to hold the customer's first name.
        private string FirstName = String.Empty;

        //Private variable to hold the customer's last name.
        private string LastName = String.Empty;

        //Private variable to hold the customer's email address.
        private string EmailAddress = String.Empty;

        //Private variable to hold the customer's phone number.
        private string PhoneNumber = String.Empty;

        //Private readonly date time variable to determine the time 
        //TODO: Should it include read only?
        private readonly DateTime Date = DateTime.Now;

        //Private boolean variable to determine if the customer was contacted or not.
        private bool ContactStatus = false;

        /// <summary>
        /// Default Constructor - creates a new customer obj.
        /// </summary>
        public CustomerClass()
        {
            Count += 1; 
            Id = Count;

        }

        /// <summary>
        /// Parameterized Constructor - creates a new obj based on the parameters being passed. 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="contactStatus"></param>
        public CustomerClass(string firstName, string lastName, string emailAddress, string phoneNumber, bool contactStatus) : this()
        {
            //The ": this()" above calls the default constructor where the the count and id are set.

            // Set the private variables declared within the class to the values being passed to the constructor.
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            ContactStatus = contactStatus;
        }

        /// <summary>
        /// Get for the readOnly Count static property value. 
        /// </summary>
        public int CustomerCount
        {
            get
            {
                return Count;
            }
        }

        /// <summary>
        /// Get for the readOnly Id property value. 
        /// </summary>
        public int CustomerId
        {
            get
            {
                return Id;
            }
        }

        /// <summary>
        /// Gets and sets the value of the FirstName Property
        /// </summary>
        public string CustomerFirstName { get => FirstName; set => FirstName = value; }

        /// <summary>
        /// Gets and sets the value of the LastName Property
        /// </summary>
        public string CustomerLastName { get => LastName; set => LastName = value; }

        /// <summary>
        /// Gets and sets the value of the EmailAddress Property
        /// </summary>
        public string CustomerEmailAddress { get => EmailAddress; set => EmailAddress = value; }

        /// <summary>
        /// Gets and sets the value of the PhoneNumber Property
        /// </summary>
        public string CustomerPhoneNumber { get => PhoneNumber; set => PhoneNumber = value; }

        /// <summary>
        /// Gets and sets the value of the date Property
        /// </summary>
        public DateTime EnteredDate => Date;

        /// <summary>
        /// Gets and sets the value of the ContactStatus Property
        /// </summary>
        public bool CustomerContactStatus { get => ContactStatus; set => ContactStatus = value; }



        /// <summary>
        /// GetStatus is a function that returns the status of the customer obj by returning a string with the value of its properties.
        /// </summary>
        /// <returns></returns>
        public string GetStatus()
        {
            return FirstName + " " + LastName + " (" + EmailAddress + " / " + PhoneNumber + ") " + " from " + Date.ToString() + " " + (ContactStatus ? "has been contacted" : "has not been contacted");
        }
    }
}
