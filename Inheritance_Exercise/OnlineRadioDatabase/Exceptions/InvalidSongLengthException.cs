using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase.Exceptions
{
    class InvalidSongLengthException : InvalidSongException
    {
        public override string Message
        {
            get { return "Invalid song length."; }
        }
    }
}
