// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PAOCore.Validate
{
    public class SyncTwoAttribute : ValidationAttribute
    {
        #region Public and private fields and properties

        private readonly string _attributeName;

        #endregion

        #region Constructor and destructor

        public SyncTwoAttribute(string attributeName)
        {
            _attributeName = attributeName;
        }

        #endregion

        #region Public and private methods

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            PropertyInfo otherPropertyInfo = validationContext.ObjectType.GetProperty(_attributeName);

            if (otherPropertyInfo == null)
            {
                throw new ArgumentException($"Object {validationContext.ObjectType} has not attribite: {_attributeName}");
            }

            object otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);

            if (Equals(value, otherPropertyValue))
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return null;
        }

        #endregion
    }
}
