using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongException : Exception
    {
        public override string Message
        {
            get { return "Invalid song."; }
        }
    }
}
