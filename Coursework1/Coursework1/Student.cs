using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1
{
    /// <summary>
    /// Author: Danayal Iftikhar
    /// This class is used to define the parameters for all the methods to be called in the GUI and provide validation for each
    /// Date Modified: 22/10/2015
    /// </summary>
    public class Student
    {
        //Declare variables inside the class
        private string firstName;
        private string surname;
        private DateTime dateofbirth;
        private string course;
        private int matricNumber;
        private int level;
        private int credits;
        private string qualification;

        public Student() //constructor methods
        {

        }

        public string FirstName //property for manipulating first name
        {
            get { return firstName; }

            set
            {
                //check to see if value is blank

                if (value == "")
                {
                    //If blank then show message

                    throw new Exception("Please enter a value");
                }
                else
                {
                    //If not blank then set to entered value

                    firstName = value;
                }
            }
        }

        public string Surname //property for manipulating surname
        {
            get { return surname; }

            set
            {
                //check to see if value is blank

                if (value == "")
                {
                    //If blank then show message

                    throw new Exception("Please enter a value");
                }
                else
                {
                    //If not blank then set to entered value

                    surname = value;
                }
            }

        }

        public DateTime DateofBirth //property for manipulating Date of Birth
        {
            get { return dateofbirth; }

            set
            {
                //check to see if value is null

                if (value == null)
                {
                    //if blank show message

                    throw new Exception("Please enter a value");
                }
                else
                {
                    //if not blank then set to entered value

                    dateofbirth = value;
                }
            }
        }

        public string Course //property for manipulating course
        {
            get { return course; }

            set
            {
                //check to see if value is left blank

                if (value == "")
                {
                    //if blank show message

                    throw new Exception("Please enter a value");
                }
                else
                {
                    //if not blank then set to entered value

                    course = value;
                }
            }
        }

        public int MatricNumber //property for manipulating matriculation number
        {
            get { return matricNumber; }

            set
            {
                //Check to see if the entered value is within parameters

                if (value >= 40000 && value <= 60000)
                {
                    //set matric number to entered value

                    matricNumber = value;
                }
                else
                {
                    //If value is not within parameters, display message

                    throw new Exception("Please enter a value between 40000 and 60000");
                }
            }
        }

        public int Level //property for manipulating level
        {
            get { return level; }

            set
            {
                //Check to see if the entered value is within chosen parameters

                if (value >= 1 && value < 5)
                {
                    //set level to the entered value

                    level = value;
                }
                else
                {
                    //If value is not within parameters, display message

                    throw new Exception("Please enter a value between 1 and 4");
                }
            }
        }

        public int Credits //property for manipulating credits
        {
            get { return credits; }

            set
            {
                //check to see if value is within parameters 

                if (value >= 0 && value < 481)
                {
                    //set credits to entered value

                    credits = value;
                }
                else
                {
                    //If value is not within parameters then display message

                    throw new Exception("Please enter a value between 0 and 480");
                }
            }
        }

        public string Qualification //property for manipulating qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }

        public void Award()
        {
            //Check to see if student has enough credits

            if (Credits < 360)
            {
                //award qualification based on number of credits

                qualification = ("Certificate of Higher Education");
            }
            else if (Credits > 359 || Credits < 480)
            {
                qualification = ("Degree");
            }
            else if (Credits >= 480)
            {
                qualification = ("Honours Degree");
            }
        }

        public void Advance()
        {
            //Checks to see if level is 1

            if (level == 1)
            {
                //Checks to see if the student has sufficient credits for the selected level

                if (Credits >= 120)
                {
                    //increment level

                    level++;
                }
                else
                {
                    //If the student does not have enough credits, display message

                    throw new Exception("You do not have sufficient credits to advance");
                }
            }

            //Checks to see if level is 2

            else if (level == 2)
            {
                if (Credits >= 240)
                {
                    //increment level

                    level++;
                }
                else
                {
                    //if student does not have enough credits, display message

                    throw new Exception("You do not have sufficient credits to advance");
                }
            }

            //Checks to see if level is 3

            else if (level == 3)
            {
                if (Credits >= 360)
                {
                    //increment level

                    level++;
                }
                else
                {
                    //if student does not have enough credits, display message

                    throw new Exception("You do not have sufficient credits to advance");
                }
            }
            //checks to see if level is 4

            else if (level == 4)
            {
                //if student is already at level 4 then display message

                throw new Exception("Student is already in 4th Year");
            }
        }
    }
}
                
            
        
