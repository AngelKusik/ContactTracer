﻿// Author:              Angelica Kusik (based on prof Kyle Chapman work)
// Last Modified by:    Angelica Kusik
// Original Date:       March 17, 2021
// Last Modified Date:  March 18, 2022
// Project Name:        ContactTracer.cs
// Course:              NETD 2202
// Description:
//  Lab #4 - ContactTracer.cs event handlers & functions
//  An application created to handle the functionality of a Contact Tracer form that allows the user to enter, see, and modify customer
//  information on a listView while keeping rack of whether the customer have been contacted or not. The application will validate the 
//  customer information according to lab 4 requirements, allow the user to select a customer from the listView and modify their information
//  as well as enter brand new information to the list.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace lab4_ContactTracer
{
    public partial class FormContactTracer : Form
    {
        private List<CustomerClass> customerList = new List<CustomerClass>();
        // This flag is used to indicate whether the program is checking boxes as opposed to a human. Not sure why we need this
        private bool isAutomated = false;
        // Variable representing the current selected index in the ListView.
        // This is being used to simplify a few reference to indexes.
        private int selectedIndex = -1;

        public FormContactTracer()
        {
            InitializeComponent();
        }
        #region "Event Handlers"

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Adds the customer information to the listView as a new customer if information is valid and displays it on the output label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            //Empty the error/output label so it can be filled with new errors or the output depending on the validation process.
            labelOutput.Text = String.Empty;

            // Validate if the information entered is valid.
            if (IsCustomerValid(textBoxFirstName.Text, textBoxLastName.Text, textBoxEmailAddress.Text, textBoxPhoneNumber.Text))
            {
                // Customer details are valid; create a customer object.
                CustomerClass newCustomerToAdd = new CustomerClass(checkBoxContacted.Checked, textBoxFirstName.Text, textBoxLastName.Text, DateTime.Now, textBoxEmailAddress.Text, textBoxPhoneNumber.Text);

                // If a customer is currently selected...
                if (selectedIndex >= 0)
                {
                    // Replace the old version of that customer with the new one!
                    customerList[selectedIndex] = newCustomerToAdd;

                }
                else
                {
                    // Otherwise, add a customer with the entered details to the end of the list.
                    customerList.Add(newCustomerToAdd);

                    //Reset the form to allow user to enter more customers
                    SetDefaults();

                    //Display new Customer information on the output Label
                    labelOutput.Text = "Added new contact: " + newCustomerToAdd.GetStatus();
                }


                // Refresh the entire listView
                PopulateListView(customerList);

                //Reset the form to allow user to enter more customers
                SetDefaults();

                //TODO: get labeloutput to display the getstatus function output??????

            }
        }

        /// <summary>
        /// Resets the form to its default state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            SetDefaults();
        }
        /// <summary>
        /// If the user selects a customer from the listView, it displays the customer's information back on the form so the user can modify and re-submit it. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerSelected(object sender, EventArgs e)
        {
            // If the list is populated and something is selected...
            if (listViewCustomersEntered.Items.Count > 0 && listViewCustomersEntered.FocusedItem != null)
            {
                // ...fill in the entry fields with values based on the selected customer.
                textBoxFirstName.Text = listViewCustomersEntered.FocusedItem.SubItems[1].Text;
                textBoxLastName.Text = listViewCustomersEntered.FocusedItem.SubItems[2].Text;
                textBoxEmailAddress.Text = listViewCustomersEntered.FocusedItem.SubItems[4].Text;
                textBoxPhoneNumber.Text = listViewCustomersEntered.FocusedItem.SubItems[5].Text;
                checkBoxContacted.Checked = listViewCustomersEntered.FocusedItem.Checked;

                // Set the selectedIndex to match the listView.
                selectedIndex = listViewCustomersEntered.FocusedItem.Index;
            }
            else
            {
                // If nothing is selected, set the selectedIndex to -1.
                selectedIndex = -1;
            }
        }

        /// <summary>
        /// When a checkbox in the ListView is checked, say no and don't let the user change it.
        /// </summary>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it's being done by the user.
            if (!isAutomated)
            {
                // Change the new value of the checkbox equal to the old state of the checkbox.
                e.NewValue = e.CurrentValue;
            }
        }
        #endregion
        #region "Functions"
        /// <summary>
        /// Converts the customer passed in to a ListViewItem and adds it to listViewCustomersEntered
        /// </summary>
        /// <param name="newCustomer"></param>
        private void PopulateListView(List<CustomerClass> customerList)
        {
            // Clear the listView to start re-populating it.
            listViewCustomersEntered.Items.Clear();

            foreach (CustomerClass newCustomer in customerList)
            {
                // Declare and instantiate a new ListViewItem.
                ListViewItem customerItem = new ListViewItem();

                // Allow the program to modify the ListView's checkboxes.
                isAutomated = true;
                customerItem.Checked = newCustomer.CustomerContactStatus;

                //Gets the information from the customer properties and add to the customerItems
                customerItem.SubItems.Add(newCustomer.CustomerFirstName);
                customerItem.SubItems.Add(newCustomer.CustomerLastName);
                customerItem.SubItems.Add(newCustomer.EnteredDate);
                customerItem.SubItems.Add(newCustomer.CustomerEmailAddress);
                customerItem.SubItems.Add(newCustomer.CustomerPhoneNumber);


                // Add the customerItem to the ListView.
                listViewCustomersEntered.Items.Add(customerItem);

                // Disallow the user from modifying the ListView's checkboxes.
                isAutomated = false;
            }
        }

        /// <summary>
        /// Reset the form's input fields to their default states.
        /// </summary>
        private void SetDefaults()
        {
            // Resets fields to default state.
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmailAddress.Clear();
            textBoxPhoneNumber.Clear();

            checkBoxContacted.Checked = false;
            listViewCustomersEntered.SelectedItems.Clear();
            labelOutput.Text = String.Empty;
            selectedIndex = -1;

            // Set a default focus.
            textBoxFirstName.Focus();
        }

        /// <summary>
        /// Checks whether the input related to a customer is valid
        /// </summary>
        /// <param name="title">The customer's title as a string</param>
        /// <param name="firstName">The customer's first name as a string</param>
        /// <param name="lastName">The customer's last name as a string</param>
        /// <returns></returns>
        private bool IsCustomerValid(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            // Assume the worker is valid.
            bool isValid = true;
            //According to Lab 4 requirements a valid email or a valid phone number must be entered
            //these flags were created to check this condition.
            bool emailIsValid = true;
            bool phoneIsValid = true;


            // Check the first name input.
            if (firstName == String.Empty)
            {
                // If it's blank, set isValid = false and write an error message.
                isValid &= false;
                labelOutput.Text += "You must enter a first name.\n";
                textBoxFirstName.Focus();
            }
            // This part uses Regular Expression to check if the first name string has anything other than letters.
            else if (!Regex.IsMatch(firstName, "^[A-Za-z]*$"))
            {
                // If first name contains numbers or special characters display an error message
                labelOutput.Text += "First name must be composed only by letters. If you are Elon Musk's kid, sorry not sorry.." + Environment.NewLine;
                textBoxFirstName.Focus();
                textBoxFirstName.SelectAll();
                isValid &= false;
            }

            // Check the last name input.
            if (lastName == String.Empty)
            {
                // If it's not valid, set isValid = false and write an error message.
                isValid &= false;
                labelOutput.Text += "You must enter a last name.\n";
                textBoxFirstName.Focus();
            }
            // This part uses Regular Expression to check if the last name string has anything other than letters.
            else if (!Regex.IsMatch(lastName, "^[A-Za-z]*$"))
            {
                // If last name contains numbers or special characters display an error message
                labelOutput.Text += "Last name must be composed only by letters." + Environment.NewLine;
                textBoxLastName.Focus();
                textBoxLastName.SelectAll();
                isValid &= false;
            }

            // Check the email address input.
            if (emailAddress == String.Empty)
            {
                labelOutput.Text += "The email address cannot be left empty." + Environment.NewLine;
                textBoxEmailAddress.SelectAll();
                textBoxEmailAddress.Focus();
                emailIsValid = false;
            }
            // This part uses Regular Expressions and will require "using System.Text.RegularExpressions;" at the top of your code file.
            else if (!Regex.IsMatch(emailAddress, "[A-Z0-9a-z._%+-]+@[A-Z0-9a-z0-9.-]+\\.[A-Za-z]{2,64}"))
            {
                labelOutput.Text += "The email address is not in a valid format." + Environment.NewLine;
                textBoxEmailAddress.SelectAll();
                textBoxEmailAddress.Focus();
                //isValid = false;
                emailIsValid = false;
            }

            // Check the phone number input.
            if (phoneNumber == String.Empty)
            {
                labelOutput.Text += "The phone number cannot be left empty." + Environment.NewLine;
                textBoxPhoneNumber.SelectAll();
                textBoxPhoneNumber.Focus();
                phoneIsValid = false;
            }
            else if (!Regex.IsMatch(phoneNumber, "[0-9()-]{10,11}"))
            {
                labelOutput.Text += "The phone number is not in a valid format." + Environment.NewLine;
                textBoxPhoneNumber.SelectAll();
                textBoxPhoneNumber.Focus();
                phoneIsValid = false;
            }

            //At least one of a valid email address or phone number must be entered.
            //I am not sure if that is what the lab requirements were asking for, I personally think it makes more sense to make both a valid phone number
            //and a valid email mandatory, but that's how I handled it:
            //
            if (emailIsValid == false && phoneIsValid == false)
            {
                labelOutput.Text += "Both the email and the phone number are not valid. Please enter at least one valid contact information." + Environment.NewLine;
                isValid &= false;
            }


            return isValid;
        }

        #endregion
    }
}
