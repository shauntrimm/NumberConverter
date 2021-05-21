using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConversionApp
{

 /*
 * FrmConversion.cs
 * Code for the main conversion form
 * Created By: Shaun Trimm
 * Created On: 12-3-2020
 * Last Modified By: Shaun Trimm
 * Last Modified On: 12-11-2020
 * Assignment: A290 NET Individual Final Project Phase 3
*/
    public partial class FrmConversion : Form
    {
        //variable to hold string input
        string input = "";
        //Holds an integer value corresponding with the chosen input type, 0 for decimal, 1 for binary, 2 for hex, 3 for octal, -1 for none chosen
        int inputType = -1;
        //Output variables
        string decimalOutput = "";
        string binaryOutput = "";
        string hexOutput = "";
        string octalOutput = "";
        //Variable that determines whether the input is a negative number
        bool isNegative = false;

        //Regexes to check for input validity
        static readonly Regex binary = new Regex("^[01]+$", RegexOptions.Compiled);
        static readonly Regex octal = new Regex("^[01234567]+$", RegexOptions.Compiled);
        static readonly Regex dec = new Regex("^[0123456789]+$", RegexOptions.Compiled);
        static readonly Regex hex = new Regex("^[0123456789aAbBcCdDeEfF]+$", RegexOptions.Compiled);

        public FrmConversion()
        {
            InitializeComponent();
        }

        //Is called when the user clicks on btnConvert
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Check for empty string in input
            if (input == "")
            {
                //Building the error message
                string message = "No value entered, please enter a number that corresponds with your chosen base and try again.";
                string caption = "Invalid Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, caption, buttons, icon);
                txtInput.Focus();
            }
            //check for a default value in inputType
            else if (inputType == -1)
            {
                //Building the error message
                string message = "No base selected, please select a base and try again.";
                string caption = "Invalid Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(message, caption, buttons, icon);
                cmbxBase.Focus();
            }
            else 
            {
                //Check if input is negative
                if (isNegative == true) {
                    //Removes - from the input
                    input = input.Substring(1, (input.Length - 1));
                }
                //Determine input type
                if (inputType == 0) {

                        //Validate input
                        if (dec.IsMatch(input))
                        {
                            //Set the decimal value string
                            decimalOutput = input;

                            //Convert to binary
                            binaryOutput = Conversions.decimalToBinary(input);

                            //Convert to hex
                            hexOutput = Conversions.decimalToHex(input);

                            //Convert to octal
                            octalOutput = Conversions.decimalToOctal(input);
                        }
                        else {
                            //Building the error message
                            string message = "The value entered is invalid for decimal input, ensure that the values for each digit are between 1-9, " +
                            "and if the input is negative that the '-' is at the beginning of the input.";
                            string caption = "Invalid Input";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBoxIcon icon = MessageBoxIcon.Error;
                            MessageBox.Show(message, caption, buttons, icon);
                            txtInput.Focus();
                        }
                    
                }
                else if (inputType == 1) {
                        //Validate input
                        if (binary.IsMatch(input))
                        {
                            //Set the binary value string
                            binaryOutput = input;

                            //Convert to decimal, and store decimal value
                            decimalOutput = Conversions.binaryToDecimal(input);

                            //Convert to hex, using decimal value
                            hexOutput = Conversions.decimalToHex(decimalOutput);

                            //Convert to octal, using decimal value
                            octalOutput = Conversions.decimalToOctal(decimalOutput);
                        }
                        else
                        {
                            //Building the error message
                            string message = "The value entered is invalid for binary input, ensure that the values for each digit are either 0 or 1, " +
                            "and if the input is negative that the '-' is at the beginning of the input.";
                            string caption = "Invalid Input";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBoxIcon icon = MessageBoxIcon.Error;
                            MessageBox.Show(message, caption, buttons, icon);
                            txtInput.Focus();
                        }

                    


                }
                else if (inputType == 2) {
                        //Validate input
                        if (hex.IsMatch(input))
                        {
                            //Set the hex value string
                            hexOutput = input;

                            //Convert to decimal, and store decimal value
                            decimalOutput = Conversions.hexToDecimal(input);

                            //Convert to binary, using decimal value
                            binaryOutput = Conversions.decimalToBinary(decimalOutput);

                            //Convert to octal, using decimal value
                            octalOutput = Conversions.decimalToOctal(decimalOutput);
                        }
                        else
                        {
                            //Building the error message
                            string message = "The value entered is invalid for hexadecimal input, " +
                            "ensure that the values are either between 1-9, or are one of the characters (a, A, b, B, c, C, d, D, e, E, f, F) , for each digit, " +
                            "and if the input is negative that the '-' is at the beginning of the input.";
                            string caption = "Invalid Input";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBoxIcon icon = MessageBoxIcon.Error;
                            MessageBox.Show(message, caption, buttons, icon);
                            txtInput.Focus();
                        }
                    
                }
                else if (inputType == 3) {
                        //Validate Input
                        if (octal.IsMatch(input))
                        {
                            //Set the octal value string
                            octalOutput = input;

                            //Convert to decimal, and store decimal value
                            decimalOutput = Conversions.octalToDecimal(input);

                            //Convert to binary, using decimal value
                            binaryOutput = Conversions.decimalToBinary(decimalOutput);

                            //Convert to hex, using decimal value
                            hexOutput = Conversions.decimalToHex(decimalOutput);
                        }
                        else
                        {
                        //Building the error message
                        string message = "The value entered is invalid for octal input, ensure that the values for each digit are between 1-7, " +
                        "and if the input is negative that the '-' is at the beginning of the input.";
                        string caption = "Invalid Input";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBox.Show(message, caption, buttons, icon);
                        txtInput.Focus();
                    }
                    
                }

                //Set string values and make them the values for the outputs, based on whether the input was negative
                if (isNegative == true)
                {
                    txtDecimal.Text = "-" + decimalOutput;
                    txtBinary.Text = "-" + binaryOutput;
                    txtHex.Text = "-" + hexOutput;
                    txtOctal.Text = "-" + octalOutput;
                }
                else
                {
                    txtDecimal.Text = decimalOutput;
                    txtBinary.Text = binaryOutput;
                    txtHex.Text = hexOutput;
                    txtOctal.Text = octalOutput;
                }
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //Updates the input based on the text put into txtInput
            if (txtInput.Text.Trim().StartsWith('-'))
            {
                isNegative = true;
            }
            else {
                isNegative = false;
            }
            input = txtInput.Text.Trim();
        }

        private void cmbxBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Changes index value based on the value chosen in cmbxBase
            inputType = cmbxBase.SelectedIndex;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.StartPosition = FormStartPosition.CenterParent;
            about.ShowDialog(this);
        }
    }

    //Used to store conversion functions
    public class Conversions {

        //Converts a decimal string to a binary string
        public static string decimalToBinary(string num) {
            long number = long.Parse(num);
            string result = "";
            Stack numbers = new Stack();
            //Performing integer division to fill the stack of numbers
            while (number != 0) {
                long remainder = number % 2;
                numbers.Push(remainder);
                number = number / 2;
            }
            //Building the output string
            while (numbers.Count > 0) {
                result = result + numbers.Pop().ToString();
            }
            return result;
        }

        //Converts a decimal string to a hex string
        public static string decimalToHex(string num)
        {
            long number = long.Parse(num);
            string result = "";
            Stack numbers = new Stack();
            //Performing integer division to fill the stack of numbers
            while (number != 0)
            {
                long remainder = number % 16;
                numbers.Push(remainder);
                number = number / 16;
            }
            //Building the output string
            while (numbers.Count > 0)
            {
                //Converting numbers greater than 9 to their hex equivalents
                if ((long)numbers.Peek() > 9)
                {
                    if ((long)numbers.Peek() == 10) 
                    {
                        result = result + "A";
                    }
                    else if ((long)numbers.Peek() == 11)
                    {
                        result = result + "B";
                    }
                    else if ((long)numbers.Peek() == 12) {
                        result = result + "C";
                    }
                    else if ((long)numbers.Peek() == 13) {
                        result = result + "D";
                    }
                    else if ((long)numbers.Peek() == 14) 
                    {
                        result = result + "E";
                    }
                    else if ((long)numbers.Peek() == 15) 
                    {
                        result = result + "F";
                    }
                    numbers.Pop();
                }
                else
                {
                    result = result + numbers.Pop().ToString();
                }
            }
            return result;
        }

        //Converts a decimal string to an octal string
        public static string decimalToOctal(string num)
        {
            long number = long.Parse(num);
            string result = "";
            Stack numbers = new Stack();
            //Performing integer division to fill the stack of numbers
            while (number != 0)
            {
                long remainder = number % 8;
                numbers.Push(remainder);
                number = number / 8;
            }
            //Building the output string
            while (numbers.Count > 0)
            {
                result = result + numbers.Pop().ToString();
            }
            return result;
        }

        //Converts a binary string to a decimal string
        public static string binaryToDecimal(string num) {
            long result = 0;
            char[] chars = num.ToCharArray();
            //Summing together 2 to the power of each index to get the conversion result
            for (int i = 0; i < chars.Length; i++) {
                result = result + (long.Parse(chars[(chars.Length - 1) - i].ToString()) * (long)Math.Pow(2, i));
            }
            return result.ToString();
        }

        //Converts a hexadecimal string to a decimal string
        public static string hexToDecimal(string num)
        {
            long result = 0;
            char[] chars = num.ToCharArray();
            //Summing together 16 to the power of each index to get the conversion result
            for (int i = 0; i < chars.Length; i++)
            {
                long value = 0;
                //change value in char array based on the value of the hex character
                if (chars[chars.Length - 1 - i] =='a' || chars[chars.Length - 1 - i] == 'A')
                {
                    value = 10;
                    result = result + (value * (long)Math.Pow(16, i));
                    MessageBox.Show(result.ToString());
                }
                else if (chars[chars.Length - 1 - i] == 'b' || chars[chars.Length - 1 - i] == 'B')
                {
                    value = 11;
                    result = result + (value * (long)Math.Pow(16, i));
                }
                else if (chars[chars.Length - 1 - i] == 'c' || chars[chars.Length - 1 - i] == 'C')
                {
                    value = 12;
                    result = result + (value * (long)Math.Pow(16, i));
                }
                else if (chars[chars.Length - 1 - i] == 'd' || chars[chars.Length - 1 - i] == 'D')
                {
                    value = 13;
                    result = result + (value * (long)Math.Pow(16, i));
                }
                else if (chars[chars.Length - 1 - i] == 'e' || chars[chars.Length - 1 - i] == 'E')
                {
                    value = 14;
                    result = result + (value * (long)Math.Pow(16, i));
                }
                else if (chars[chars.Length - 1 - i] == 'f' || chars[chars.Length - 1 - i] == 'F')
                {
                    value = 15;
                    result = result + (value * (long)Math.Pow(16, i));
                }
                else {
                    //If the current character is a digit
                    result = result + (long.Parse(chars[chars.Length - 1 - i].ToString()) * (long)Math.Pow(16, i));
                }
            }
            return result.ToString();
        }

        //Converts an octal string to a decimal string
        public static string octalToDecimal(string num)
        {
            long result = 0;
            char[] chars = num.ToCharArray();
            //Summing together 8 to the power of each index to get the conversion result
            for (int i = 0; i < chars.Length; i++)
            {
                result = result + (long.Parse(chars[(chars.Length - 1) - i].ToString()) * (long)Math.Pow(8, i));
            }
            return result.ToString();
        }
    }
}
