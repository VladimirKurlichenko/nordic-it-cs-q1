using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CityApp.WiewModels
{
    public class NotCompareAttribute : ValidationAttribute
    {
        public string Property { get; set; }
        public NotCompareAttribute(string property)
        {
            Property = property;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(Property);

            var propertyValue = property.GetValue(validationContext.ObjectInstance);

            if (Equals(value, propertyValue))
            {
                return new ValidationResult($"Значение свойства {Property} совпадаент");
            }

            return ValidationResult.Success;
        }
    }
}
