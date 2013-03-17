namespace DemoApplication.Metadata.Adapters
{
    #region

    using System.Collections.Generic;
    using System.Web.Mvc;
    using Attributes;
    using Rules;

    #endregion

    public class CreditCardAttributeAdapter : DataAnnotationsModelValidator<CreditCardTextboxAttribute>
    {
        public CreditCardAttributeAdapter(ModelMetadata metadata, ControllerContext context, CreditCardTextboxAttribute textboxAttribute)
            : base(metadata, context, textboxAttribute)
        {
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            return new[] { new ModelClientValidationCreditCardRule(ErrorMessage) };
        }
    }
}