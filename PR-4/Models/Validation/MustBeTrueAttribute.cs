using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PR_4.Models.Validation
{
    public class MustBeTrueAttribute : ValidationAttribute, IClientModelValidator
    {
        public MustBeTrueAttribute()
        {
            ErrorMessage = "You must agree to event terms and guidelines";
        }

        public override bool IsValid(object? value)
        {
            if (value is bool b)
                return b;
            return false;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            if (context == null) return;
            MergeAttribute(context.Attributes, "data-val", "true");
            MergeAttribute(context.Attributes, "data-val-mustbetrue", ErrorMessage ?? "The field must be checked.");
        }

        private void MergeAttribute(IDictionary<string, string> attributes, string key, string value)
        {
            if (!attributes.ContainsKey(key))
                attributes.Add(key, value);
        }
    }
}
