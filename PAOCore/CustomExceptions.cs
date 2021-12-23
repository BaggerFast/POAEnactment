using System;
using System.Collections.Generic;
using System.Text;

namespace PAOCore
{
    public class EmptyFieldException : Exception
    {
        public EmptyFieldException() { }

        public EmptyFieldException(string FieldName)
            : base($"Необходимо заполнить поле: {FieldName.ToUpper()}")
        {

        }
    }
}
