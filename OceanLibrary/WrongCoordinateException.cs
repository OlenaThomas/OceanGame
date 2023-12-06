using System;

namespace OceanLibrary
{
    public class WrongCoordinateException : Exception
    {
        public Coordinate Place { get; private set; }

        public WrongCoordinateException() : base()
        {
        }

        public WrongCoordinateException(string message) : base(message)
        {
        }

        public WrongCoordinateException(string message, Coordinate place) : base(message)
        {
            Place = place;
        }

        public WrongCoordinateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
