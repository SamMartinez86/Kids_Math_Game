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
using System.Reflection;

namespace KidsMathGame
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {

        #region attributes

        /// <summary>
        /// Class thats holds Player data
        /// </summary>
        private UserCLS CurrentUser;

        /// <summary>
        /// Class that runs the Game
        /// </summary>
        private GameLogicCLS CurrentGame;

        /// <summary>
        /// Class for User Data window
        /// </summary>
        private UserData WinUserData;

        /// <summary>
        /// class for Game data window
        /// </summary>
        private Game WinGameData;

        /// <summary>
        /// class for Final Score window
        /// </summary>
        private FinalScore WinfinalScore;

        #endregion

        #region constructor
        public Main()
        {
            // exception handling for this constructor
            try
            {

                InitializeComponent();

                // needs this because application won't close
                Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;


                //New UserCLS object
                CurrentUser = new UserCLS();

                //New UserCLS object
                CurrentGame = new GameLogicCLS(CurrentUser);

                //New UserCLS object
                WinfinalScore = new FinalScore(CurrentUser);

                //New UserCLS object
                WinUserData = new UserData(CurrentGame, CurrentUser);

                //New UserCLS object
                WinGameData = new Game(CurrentGame, CurrentUser, WinfinalScore);
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
        /// This methods is a button to see FinalScore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalScrBtn_Click(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            {

                // hide this window
                this.Hide();

                // load scores into final score window
                WinfinalScore.ShowScores();

                // run show dialog for final score window
                WinfinalScore.ShowDialog();

                // show main window
                this.ShowDialog();



            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// This method is a button to access UserData
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserDtaBtn_Click(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            {
         
                // hide this window
                this.Hide();

                // show dialog for User data window
                WinUserData.ShowDialog();

                // show main window
                this.ShowDialog();
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method is a button to access Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayGmBtn_Click(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            {

                    // hide this window
                    this.Hide();

                    // run the run method for GameLogicCLS
                    CurrentGame.Run();

                    // run setup game for game window
                    WinGameData.SetupGame();

                    // show dialog 
                    WinGameData.ShowDialog();

                    // show main window
                    this.ShowDialog();


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
