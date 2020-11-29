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
using System.Timers;
using System.Windows.Threading;
using System.Diagnostics;

namespace KidsMathGame
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        #region Attributes

        /// <summary>
        /// Class thats holds Player data
        /// </summary>
        private UserCLS CurrentUser;

        /// <summary>
        /// Class that runs the Game
        /// </summary>
        private GameLogicCLS CurrentGame;

        /// <summary>
        /// Class thats runs final score window
        /// </summary>
        private FinalScore WinfinalScore;

        /// <summary>
        /// new time clock objects 
        /// </summary>
        private DispatcherTimer dt = new DispatcherTimer();
        private Stopwatch sw = new Stopwatch();

        /// <summary>
        /// variable to store the current time
        /// </summary>
        private string currentTime = string.Empty;

        #endregion

        #region Constructors
        public Game(GameLogicCLS GLclass, UserCLS Uclass, FinalScore Fscore)
        {
            //exception handling for this constructor
            try
            {
                InitializeComponent();

                //time clock constructor
                dt.Tick += new EventHandler(TC_Tick);
                dt.Interval = new TimeSpan(0, 0, 0, 0, 1);

                // set objects
                CurrentGame = GLclass;
                CurrentUser = Uclass;
                WinfinalScore = Fscore;
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
        /// Time clock method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TC_Tick(object sender, EventArgs e)
        {

            //exception handling for this method
            try
            { 

                // if running send to label
                if (sw.IsRunning)
                {
                    // format and assign time objects
                    TimeSpan ts = sw.Elapsed;
                    currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                    ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    TimerLbl.Content = currentTime;
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method is the start button provides first question and starts time clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            //exception handling for this method
            try
            { 
                // start timer
                sw.Start();
                dt.Start();

                // 1st question
                CurrentGame.Question();

                // Change the number labels
                num1Lbl.Content = CurrentGame.Num1;
                num2Lbl.Content = CurrentGame.Num2;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// This method quits to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {

            //exception handling for this method
            try
            {
                // exit to menu
                this.Hide();


            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method validates 1st question, goes to next question and provides a labels for answers 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {

            //exception handling for this method
            try
            { 
                // run game process method 
                GameProcess();
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
        /// method set up the operator for each game using the selection from UserData
        /// </summary>
        public void SetupGame()
        {
            //exception handling for this method
            try
            {
                // assign the correct operator to UI
                operatorLbl.Content = CurrentGame.OperatorLabel;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// restrict text box to take numbers, backspace, delete. Use enter to answer questions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInput_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //exception handling for this method
            try
            {

                //Only allow numbers to be entered
                if (!((e.Key >= Key.D0 && e.Key <= Key.D9) ||
                  e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
                {
                    //Allow the user to use the backspace and delete keys
                    if (!(e.Key == Key.Back || e.Key == Key.Delete))
                    {
                        if (e.Key == Key.Enter)
                        {
                            //No other keys allowed besides numbers, backspace, and delete
                            e.Handled = true;
                            GameProcess();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }
  
        

        /// <summary>
        /// This method runs the game process and interacts with the UI when the GameLogicCLS class makes changes
        /// </summary>
        private void GameProcess()
        {
            //exception handling for this method
            try
            {


                // collect answer from user
                // throw error if not number
                try
                {
                    // assign user's solution to equation
                    CurrentGame.Solution = (Int32.Parse(userTxtBx.Text));
                }
                catch (Exception)
                {
                    // assign error to label and change color of label
                    outcomeLbl.Foreground = Brushes.Yellow;
                    outcomeLbl.Content = "Only numbers";
                    userTxtBx.Text = " ";
                    return;
                }

                // validate question and change to next question
                CurrentGame.CompareAnswer();
                userTxtBx.Text = " ";

                // send outcome to label
                outcomeLbl.Content = CurrentGame.Outcome;

                // change color of outcome label based on... well... the outcome.
                if (CurrentGame.OutcomeColor == true)
                {
                    // change label to green
                    outcomeLbl.Foreground = Brushes.Green;
                }
                else
                {
                    //change label to red
                    outcomeLbl.Foreground = Brushes.Red;
                }

                // counter stop
                if (CurrentGame.Counter == 10)
                {
                    // stop time clock
                    sw.Stop();

                    // send time to label
                    TimerLbl.Content = currentTime;

                    // send time to user
                    CurrentUser.Timer = currentTime;

                    // set the picture 
                    CurrentGame.ScorePicture();

                    // bring up final scores window
                    this.Hide();
                    WinfinalScore.ShowScores();
                    WinfinalScore.ShowDialog();
                    //this.Show();

                }

                // start timer and 1st question
                CurrentGame.Question();

                // Change the number labels
                num1Lbl.Content = CurrentGame.Num1;
                num2Lbl.Content = CurrentGame.Num2;

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
