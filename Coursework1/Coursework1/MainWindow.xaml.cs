using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Coursework1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Author: Danayal Iftikhar
    /// This class provides a GUI to enter values for student details to show in the award window
    /// Last Modified: 22/10/2015
    /// </summary>
    public partial class MainWindow : Window
    {
        Student current = new Student();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAward_Click(object sender, RoutedEventArgs e)
        {
            //if a value has been set for credits 

            if (current.Credits > 0)
            {
                //Instantiate the student class and populate the textblocks with the entered values

                AwardWindow award = new AwardWindow(); //make a new instance of the Award window
                award.Owner = this; //governs award window being owned by main window
                award.Show(); //Show the award window
                Hide(); //Close the current window

                //Access all the objects from the Set event and display them in the Award window

                award.txtFirstname.Text = current.FirstName;
                award.txtSurname.Text = current.Surname;
                award.txtMatricNumber.Text = current.MatricNumber.ToString();
                award.txtCourse.Text = current.Course;
                award.txtLevel.Text = current.Level.ToString();


                //Call the qualification method from the Student class

                current.Award(); //access the award method 
                award.txtAward.Text = current.Qualification;
            }
            else
            {
                //if the credits value does not exist, then show the following message

                MessageBox.Show("Cannot give award until all fields have been completed");
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {

            //Instantiate the the student class

            //Check if firstname is left blank

            if (txtFirstname.Text == "")
            {
                //if blank, display the following message

                MessageBox.Show("Please enter a First name");
            }
            else
            {
                try
                {
                    //try to set the value entered in the textbox

                    current.FirstName = txtFirstname.Text;
                }
                //catch the exception

                catch (Exception firstname_error)
                {
                    //display error message

                    MessageBox.Show(firstname_error.Message);
                }
            }


            //Check if surname is left blank

            if (txtSurname.Text == "")
            {
                //if blank, display the following message

                MessageBox.Show("Please enter a Surname");
            }
            else
            {
                try
                {
                    //try to set the entered value in the textbox

                    current.Surname = txtSurname.Text;
                }
                //catch the exception

                catch (Exception surname_error)
                {
                    //display error message

                    MessageBox.Show(surname_error.Message);
                }
            }


            //Check if Date of Birth is left blank

            if (txtDateofBirth.Text == "")
            {
                //if blank, display the following message

                MessageBox.Show("Please enter a Date of Birth");
            }
            else
            {
                try
                {
                    //try to set the value entered in the textbox

                    current.DateofBirth = DateTime.Parse(txtDateofBirth.Text);
                }
                //catch the exception

                catch (Exception dob_error)
                {
                    //display the error message

                    MessageBox.Show(dob_error.Message);
                }
            }


            //check to see if course is left blank

            if (txtCourse.Text == "")
            {
                //if blank, display the following message

                MessageBox.Show("Please enter a Course");
            }
            else
            {
                try
                {
                    //try to set the value entered in the textbox

                    current.Course = txtCourse.Text;
                }
                //catch the excpetion

                catch (Exception course_error)
                {
                    //display the error message

                    MessageBox.Show(course_error.Message);
                }
            }


            //check to see if the matric number is left blank

            if (txtMatricNumber.Text == "")
            {
                //if blank, display the following message

                MessageBox.Show("Please enter a Matriculation Number");
            }
            else
            {
                try
                {
                    //try to set the value entered into the textbox

                    current.MatricNumber = int.Parse(txtMatricNumber.Text);
                }
                //catch the exception
                catch (Exception matric_error)
                {
                    //display the error message

                    MessageBox.Show(matric_error.Message);
                }
            }


            //check to see if level is left blank

            if (txtLevel.Text == "")
            {
                //if blank, display the following message

                MessageBox.Show("Please enter a Level");
            }
            else
            {
                try
                {
                    //try to set the value entered into the textbox

                    current.Level = int.Parse(txtLevel.Text);
                }
                //catch the exception

                catch (Exception level_error)
                {
                    //display the following error message

                    MessageBox.Show(level_error.Message);
                }
            }


            //check to see if credits is left blank
            if (txtCredits.Text == "")
            {
                //if blank, display the following message

                MessageBox.Show("Please enter Credits");
            }
            else
            {
                try
                {
                    //try to set the value entered into the textbox

                    current.Credits = int.Parse(txtCredits.Text);
                }
                //catch the exception

                catch (Exception credits_error)
                {
                    //display the following error message

                    MessageBox.Show(credits_error.Message);
                }
            }
        }

        private void btnAdvance_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //calls the Advance method from the Student class

                current.Advance();
            }
            catch (Exception advance_error)
            {
                //Uses the validation within the Advance method to display the appropriate error message

                MessageBox.Show(advance_error.Message);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //Clears all the textboxes of entered data

            txtFirstname.Clear();
            txtSurname.Clear();
            txtDateofBirth.Clear();
            txtMatricNumber.Clear();
            txtCourse.Clear();
            txtCredits.Clear();
            txtLevel.Clear();
        }

        private void btnGet_Click(object sender, RoutedEventArgs e)
        {
            //Collects the values stored in the current instance

            txtFirstname.Text = current.FirstName;
            txtSurname.Text = current.Surname;
            txtDateofBirth.Text = current.DateofBirth.ToShortDateString();
            txtMatricNumber.Text = current.MatricNumber.ToString();
            txtCourse.Text = current.Course;
            txtCredits.Text = current.Credits.ToString();
            txtLevel.Text = current.Level.ToString();
        }
    }
}
