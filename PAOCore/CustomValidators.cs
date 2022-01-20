using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PAOCore
{
    public class LengthInArrayAttribute: ValidationAttribute
    {
        private int[] array;

        public LengthInArrayAttribute(int[] array)
        {
            this.array = array;
        }

        public override bool IsValid(object value)
        {
            string strValue = value as string;
            bool ans = false;
            if (System.Array.IndexOf(array, strValue.Length) != -1)
                ans = true;
            return ans;
        }
    }

    public class SyncTwoAttribute : ValidationAttribute
    {
        private string attributeName;

        public SyncTwoAttribute(string attributeName)
        {
            this.attributeName = attributeName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            PropertyInfo otherPropertyInfo = validationContext.ObjectType.GetProperty(attributeName);
            
            if (otherPropertyInfo == null)
            {
                throw new ArgumentException($"Object {validationContext.ObjectType} has not attribite: {attributeName}");
            }
            if (Equals(value, otherPropertyInfo))
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return null;
        }
    }
}
