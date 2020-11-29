using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Media;
using System.Timers;
using System.Windows;

namespace KidsMathGame
{
    /// <summary>
    /// This is the Logic for the game window
    /// </summary>
    public class GameLogicCLS
    {
        #region Attributes

        /// <summary>
        /// holds user choice for game type
        /// </summary>
        private int gameType;

        /// <summary>
        /// Class thats holds Player data
        /// </summary>
        private UserCLS CurrentUser;

        //change all of these to private

        /// <summary>
        /// 1st random number for equations
        /// </summary>
        private Random ranNum1 = new Random();

        /// <summary>
        /// seed second random number for more variability 
        /// </summary>
        private static Random ranNumNum = new Random();

        /// <summary>
        /// 2nd random number for equations
        /// </summary>
        private Random ranNum2 = new Random(ranNumNum.Next(1, 11));

        /// <summary>
        /// counter for number of questions
        /// </summary>
        private int counter;

        /// <summary>
        /// boolean controls outcome color of wrong or right answer
        /// </summary>
        private bool outcomeColor;

        /// <summary>
        /// controls the outcome string
        /// </summary>
        private string outcome;

        /// <summary>
        /// stores  user's solution to problem
        /// </summary>
        private int solution;

        /// <summary>
        /// stores number for use with division operation
        /// </summary>
        private int numerator { get; set; }

        /// <summary>
        /// holds correct answer to problems
        /// </summary>
        private int Answer { get; set; }

        /// <summary>
        /// holds randomly generated number 1
        /// </summary>
        private int num1;

        /// <summary>
        /// holds randomly generated number 2
        /// </summary>
        private int num2;

        /// <summary>
        /// holds label of operator
        /// </summary>
        private string operatorLabel;

        #endregion

        #region constructor
        public GameLogicCLS(UserCLS Uclass)
        {
            //exception handling for this constructor
            try
            {
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

        #region Properties

        /// <summary>
        /// Game type property holds the type of game from UserData
        /// </summary>
        public int GameType
        {
            get
            {
                return gameType;
            }
            set
            {
                gameType = value;
            }
        }

        /// <summary>
        /// property for counter variable
        /// </summary>
        public int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                counter = value;
            }
        }

        /// <summary>
        /// Game type property holds the type of game from UserData
        /// </summary>
        public bool OutcomeColor
        {
            get
            {
                return outcomeColor;
            }
            set
            {
                outcomeColor = value;
            }
        }

        /// <summary>
        /// property for outcome string
        /// </summary>
        public string Outcome
        {
            get
            {
                return outcome;
            }
            set
            {
                outcome = value;
            }
        }

        /// <summary>
        /// property for user solution
        /// </summary>
        public int Solution
        {
            get
            {
                return solution;
            }
            set
            {
                solution = value;
            }
        }

        /// <summary>
        /// property for randomly generated number 1
        /// </summary>
        public int Num1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }

        /// <summary>
        /// property for randomly generated number 2
        /// </summary>
        public int Num2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }

        /// <summary>
        /// property for operator label
        /// </summary>
        public string OperatorLabel
        {
            get
            {
                return operatorLabel;
            }
            set
            {
                operatorLabel = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// pass type of game in and get game setup
        /// </summary>
        public void Run()
        {
            //exception handling for this method
            try
            {
                // call "GameChoice" method and pass integer that represent's the user's game choice
                GameChoice(gameType);
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// This method takes the user's game choice and decides which game to play
        /// </summary>
        public void GameChoice(int type)
        {
            // if type equals specific integer than choose specific operator
            //exception handling for this method
            try
            {
                // if type equals integer than choose specific game
                if (type == 1)
                {
                    //call addition method
                    OperatorLabel = "+";
                }
                else if (type == 2)
                {
                    //call subtraction method
                    OperatorLabel = "-";
                }
                else if (type == 3)
                {
                    //call multiplication method
                    OperatorLabel = "x";
                }
                else // type == 4
                {
                    OperatorLabel = "/";
                    // call division game
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// This method is the question
        /// </summary>
        public void Question()
        {
            //exception handling for this method
            try
            {
                //generate number between 1 - 10
                int sNum1 = ranNum1.Next(1, 11);
                int sNum2 = ranNum2.Next(1, 11);

                // if game type equals specific operator than find answer
                if (gameType == 1)// addition
                {
                    // assign labels
                    Num1 = sNum1;
                    Num2 = sNum2;
                    // compute answer
                    Answer = sNum1 + sNum2;
                }
                else if (gameType == 2) // subtraction
                {
                    // make sure we don't get negative numbers
                    if (sNum2 > sNum1)
                    {
                        // assign labels
                        Num1 = sNum2;
                        Num2 = sNum1;
                        // compute answer
                        Answer = sNum2 - sNum1;
                    }
                    else
                    {
                        //switch labels and assign labels
                        Num1 = sNum1;
                        Num2 = sNum2;
                        //compute answer
                        Answer = sNum1 - sNum2;
                    }
                }
                else if (gameType == 3)
                {
                    // assign labels
                    Num1 = sNum1;
                    Num2 = sNum2;
                    // compute answer
                    Answer = sNum1 * sNum2; // multiplication
                }
                else // gameType == 4
                {
                    // find multiplication outcome of the two numbers
                    numerator = sNum1 * sNum2;

                    // assign multiplication outcome and other number to labels
                    Num1 = numerator;
                    Num2 = sNum2;

                    // compute answer
                    Answer = numerator / sNum2; // division
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// This method i the answer
        /// </summary>
        public void CompareAnswer()
        {
            
            //exception handling for this method
            try
            {
                // If the answer is correct 
                if (Solution == Answer)
                {
                    // assign to label
                    Outcome = "Correct";
                    // boolean for use with assigning label
                    OutcomeColor = true;
                    // increment the amount of questions right
                    CurrentUser.UserRight++;
                }
                else // If the answer is incorrect 
                {
                    // assign to label
                    Outcome = "Incorrect";
                    // boolean for use with assigning label
                    OutcomeColor = false;
                    // increment the amount of questions wrong
                    CurrentUser.UserWrong++;
                }

                // increment counter
                counter++;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// This method chooses an integer to send to FinalScore for an image choice
        /// </summary>
        public void ScorePicture()
        {

            //exception handling for this method
            try
            {
                // if the amount right equals a certain amount assign specific picture
                if (CurrentUser.UserRight >= 8)
                {
                    // high score picture
                    CurrentUser.PictureType = 3;
                }
                else if (CurrentUser.UserRight >= 5 && CurrentUser.UserRight <= 7)
                {
                    // average score picture
                    CurrentUser.PictureType = 2;
                }
                else
                {
                    // low score picture
                    CurrentUser.PictureType = 1;
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

