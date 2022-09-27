using DotNet6AttributeAndFluentValidationSample.Infrastructure.Validator;
using DotNet6AttributeAndFluentValidationSample.Models.parameter;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DotNet6AttributeAndFluentValidationSample.Infrastructure.Attribute
{
    /// <summary>
    /// TestParameter驗證器的Attribute
    /// </summary>
    /// <seealso cref="System.ComponentModel.DataAnnotations.ValidationAttribute" />
    public class TestParameterAttribute : ValidationAttribute
    {
        private IValidator<TestParameter> _validator;

        public override bool IsValid(object instance)
        {
             this._validator = new TestParameterValidator();

            var validation = _validator.Validate((TestParameter)instance);

            if (!validation.IsValid)
            {
                var msg = string.Empty;
                foreach (var item in validation.Errors)
                {
                    msg += item.ErrorMessage + "  ";
                }
                throw new FluentValidation.ValidationException(msg);
            }
            return true;
        }
    }
}
