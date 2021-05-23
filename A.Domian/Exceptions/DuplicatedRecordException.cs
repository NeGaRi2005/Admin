using System;

namespace A.Domian.Exceptions
{
    public class DuplicatedRecordException: Exception
    {

        public DuplicatedRecordException()
        {
        }

        public DuplicatedRecordException(string message) : base(message)
        {
        }
    }
}
