// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using System;
using System.ComponentModel.DataAnnotations;

namespace PAOCore.Validate
{
    public class LengthInArrayAttribute : ValidationAttribute
    {
        #region Public and private fields and properties

        private readonly int[] _array;

        #endregion

        #region Constructor and destructor

        public LengthInArrayAttribute(int[] array)
        {
            _array = array;
        }

        #endregion

        #region Public and private methods

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            bool ans = false;
            if (Array.IndexOf(_array, strValue.Length) != -1)
                ans = true;
            return ans;
        }

        #endregion
    }
}
