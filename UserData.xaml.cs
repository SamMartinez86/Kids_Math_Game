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
using System.Reflection;

namespace KidsMathGame
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class UserData : Window
    {

        #region Attributes


        /// <summary>
        /// checks to see if radio button is clicked
        /// </summary>
        private bool flag = false;

        /// <summary>
        /// Class thats holds Player data
        /// </summary>
        private UserCLS CurrentUser;

        /// <summary>
        /// Class that runs the Game
        /// </summary>
        private GameLogicCLS CurrentGame;

        #endregion

        #region constructor

        /// <summary>
        /// Constructor pass in UseCLS and GameLogicCLS
        /// </summary>
        /// <param name="GLclass"></param>
        /// <param name="Uclass"></param>
        public UserData(GameLogicCLS GLclass, UserCLS Uclass)
        {
            //exception handling for this constructor
            try
            {
                InitializeComponent();

                // set objects
                CurrentGame = GLclass;
                CurrentUser = Uclass;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }



        }
        #endregion

        #region Methods

        /// <summary>
        /// If addition radio button checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRadio_Checked(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            {
                // set game type if this radio button is checked
                CurrentGame.GameType = 1;
                flag = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }
        /// <summary>
        /// If subtraction radio button checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubRadio_Checked(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            {
                // set game type if this radio button is checked
                CurrentGame.GameType = 2;
                flag = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// If multiplication radio button checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiRadio_Checked(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            {
                // set game type if this radio button is checked
                CurrentGame.GameType = 3;
                flag = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// If division radio button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivRadio_Checked(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            {
                // set game type if this radio button is checked
                CurrentGame.GameType = 4;
                flag = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Begin click game button method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            {
                // input name into User class
                // alert user if name not entered
                if (nameTxt.Text == "")
                {
                    // ask user to enter name
                    nameErrLbl.Content = "Enter your name";
                    return;
                }
                else
                {
                    // assign user's name
                    CurrentUser.UserName = nameTxt.Text;
                }


                // clear name label error message
                nameErrLbl.Content = "";

                // input age into user class 
                // alert user if age is incorrect
                try
                {
                    // assign user's age make sure it's an integer
                    CurrentUser.UserAge = (Int32.Parse(ageTxt.Text));
                }
                catch (Exception)
                {
                    // tell the user to enter a integer
                    ageErrLbl.Content = "Enter a number between (3 & 10)";
                    return;
                }

                if (CurrentUser.UserAge < 3 || CurrentUser.UserAge > 10)
                {
                    // make  sure the integer is between 3 and 10
                    ageErrLbl.Content = "Enter a number between (3 & 10)";
                    return;
                }

                // clear name label error message
                ageErrLbl.Content = "";

                // make sure user chooses a game type 
                if (flag == false)
                {
                    // tell user to choose a game
                    radioErrLbl.Content = "Choose a game";
                    return;
                }

                // hide window
                this.Hide();

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// When User exits with "x' at top right. This is used so the Object doesn't get destroyed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //exception handling for this method
            try
            { 
                // hide window
                this.Hide();
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }



        /// <summary>
        /// Exception handler method. Handles the Error.
        /// </summary>
        /// <param name="sClass">The class in which the error occurred in.</param>
        /// <param name="sMethod">The method in which the error occurred in.</param>
        /// <param name="sMessage">The message for the error.</param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + "->" + sMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }

        #endregion
    }
}

