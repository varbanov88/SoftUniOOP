using System;

namespace OnlineRadioDatabase.ExceptionClasses
{
    public class InvalidSongException : Exception
    {
        private string exceptionMessage = "Invalid song.";

        protected virtual string ExceptionMessage
        {
            set
            {
                this.exceptionMessage = value;
            }
        }

        public override string Message => exceptionMessage;
    }
}
