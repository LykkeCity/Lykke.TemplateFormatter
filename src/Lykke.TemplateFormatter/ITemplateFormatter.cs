using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Lykke.TemplateFormatter
{
    public interface ITemplateFormatter
    {
        /// <summary>
        /// Validate if message model type fits template requirements
        /// </summary>
        /// <param name="messageModelType">Message model type to validate</param>
        /// <param name="templateName">Template name</param>
        /// <returns>Returns message model type validation result</returns>
        /// <exception cref="TemplateNotFoundException"></exception>
        [NotNull] Task<IMessageModelTypeValidationResult> ValidateMessageModelTypeAsync([NotNull] Type messageModelType, [NotNull] string templateName);

        /// <summary>
        /// Format message using model and template
        /// </summary>
        /// <param name="model"></param>
        /// <param name="templateName"></param>
        /// <param name="partnerId">Partner whos template to use. If template is not found for partner, default template is used</param>
        /// <param name="language">What language template to use. If template is not found for partner, EN template is used</param>
        /// <returns></returns>
        /// <exception cref="TemplateNotFoundException"></exception>
        [NotNull] Task<IFormattedMessage> FormatAsync([NotNull] object model, [NotNull] string templateName, [NotNull] string partnerId, [NotNull] string language);
    }
}
