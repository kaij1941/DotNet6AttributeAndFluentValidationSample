using DotNet6AttributeAndFluentValidationSample.Models.parameter;
using FluentValidation;


namespace DotNet6AttributeAndFluentValidationSample.Infrastructure.Validator
{
    /// <summary>
    /// TestParameter的驗證器
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator&lt;DotNet6AttributeAndFluentValidationSample.Models.parameter.TestParameter&gt;" />
    public class TestParameterValidator: AbstractValidator<TestParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestParameterValidator"/> class.
        /// </summary>
        public TestParameterValidator()
        {
            RuleFor(x => x.MustLess100).LessThan(100).WithMessage("必需小於100");
            RuleFor(x => x.MustBeTrue).Must(x => x == false).WithMessage("必須為True");
            RuleFor(x => x.NotNullString).NotNull().WithMessage("不可為Null");
        }
    }
}
