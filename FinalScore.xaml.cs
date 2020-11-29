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
using System.Windows.Shapes;
using System.Xaml;
using System.Reflection;

namespace KidsMathGame
{
    /// <summary>
    /// Interaction logic for FinalScore.xaml
    /// </summary>
    public partial class FinalScore : Window
    {
        #region attributes

        /// <summary>
        /// Class thats holds Player data
        /// </summary>
        private UserCLS CurrentUser;

        #endregion

        #region constructor
        public FinalScore(UserCLS Uclass)
        {
            //exception handling for this constructor
            try
            {
                InitializeComponent();

                // set objects
                CurrentUser = Uclass;

            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        #endregion

        #region methods

        /// <summary>
        /// The method is the button to go back to the Main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FSMainMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            {
                // new main object for next game
                //Main main = new Main();


                // hide final score window
                this.Hide();


                // show dialog on main
                //main.ShowDialog();
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
                // hide final score window
                this.Hide();
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        public void ShowScores()
        {
            //exception handling for this method
            try
            {
                // change label to user's name
                usernameLbl.Content = CurrentUser.UserName;

                // change label to user's age
                userageLbl.Content = CurrentUser.UserAge;

                // change label to amount correct
                userCorrect.Content = CurrentUser.UserRight;

                // change label to amount wrong
                userIncorrect.Content = CurrentUser.UserWrong;

                // change label to clock time after game
                userTiempoLbl.Content = CurrentUser.Timer;

                // assign picture depending on information form user class
                if (CurrentUser.PictureType == 3)
                {
                    // assign winner image 
                    ImageBx.Source = new BitmapImage(new Uri("/Images/winner_pixel.png", UriKind.Relative));

                }
                else if (CurrentUser.PictureType == 2)
                {

                    // assign average image
                    ImageBx.Source = new BitmapImage(new Uri("/Images/AVERAGE2.jpeg", UriKind.Relative));

                }
                else
                {
                    // assign game over 
                    ImageBx.Source = new BitmapImage(new Uri("/Images/game_over_pixel.png", UriKind.Relative));

                }
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
