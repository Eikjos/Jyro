using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Jyro.API.Attribute
{
    public class PasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            ValidationResult result = new ValidationResult("");
            var errorsMessage = new List<string>();

            if (value == null)
                return new ValidationResult("password.required");

            string password = value.ToString();

            if (password.Length < 8)
                errorsMessage.Add("password.length");

            if (!Regex.IsMatch(password, "[A-Z]"))
                errorsMessage.Add("password.upper.letter.required");

            if (!Regex.IsMatch(password, "[a-z]"))
                errorsMessage.Add("password.lower.letter.required");

            if (!Regex.IsMatch(password, "[0-9]"))
                errorsMessage.Add("password.digit.required");

            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
                errorsMessage.Add("password.special.character.required");

            if (!errorsMessage.Any())
                return ValidationResult.Success;

            return new ValidationResult(string.Join(", ", errorsMessage));
        }
    }
}
