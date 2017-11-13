using System;
using JetBrains.Annotations;

namespace Lykke.TemplateFormatter
{
    public class TemplateException : Exception
    {
        [NotNull] public string TemplateName { get; }

        internal TemplateException([NotNull] string templateName, [NotNull] string message) : base(message)
        {
            if (string.IsNullOrWhiteSpace(templateName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(templateName));

            TemplateName = templateName;
        }
    }
}
