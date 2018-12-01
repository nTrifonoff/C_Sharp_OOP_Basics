using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase.Exceptions
{
    class InvalidSongMinutesException : InvalidSongException
    {
        public override string Message
        {
            get { return "Song minutes should be between 0 and 14."; }
        }
    }
}
