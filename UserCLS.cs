using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace KidsMathGame
{
    /// <summary>
    /// Holds user data 
    /// </summary>
    public class UserCLS
    {

        #region attributes

        /// <summary>
        /// holds user's name
        /// </summary>
        private static string userName;

        /// <summary>
        /// holds user's age
        /// </summary>
        private static int userAge;

        /// <summary>
        /// hold's questions answer right
        /// </summary>
        private static int userRight;

        /// <summary>
        /// holds questions answered wrong
        /// </summary>
        private static int userWrong;

        /// <summary>
        /// holds questions answered wrong
        /// </summary>
        private static string timer;

        /// <summary>
        /// send integer to call up type of picture for final score
        /// </summary>
        private int pictureType;

        #endregion

        #region properties
        /// <summary>
        /// Property for User name
        /// </summary>
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        /// <summary>
        /// property for user age
        /// </summary>
        public int UserAge
        {
            get
            {
                return userAge;
            }
            set
            {
                userAge = value;
            }
        }

        /// <summary>
        /// property for user Wrong
        /// </summary>
        public int UserWrong
        {
            get
            {
                return userWrong;
            }
            set
            {
                userWrong = value;
            }
        }

        /// <summary>
        /// property for user right
        /// </summary>
        public int UserRight
        {
            get
            {
                return userRight;
            }
            set
            {
                userRight = value;
            }
        }

        /// <summary>
        /// property for user age
        /// </summary>
        public string Timer
        {
            get
            {
                return timer;
            }
            set
            {
                timer = value;
            }
        }

        /// <summary>
        /// property for counter variable
        /// </summary>
        public int PictureType
        {
            get
            {
                return pictureType;
            }
            set
            {
                pictureType = value;
            }
        }

        #endregion

    }
}
