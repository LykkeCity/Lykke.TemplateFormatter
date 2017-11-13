using JetBrains.Annotations;

namespace Lykke.TemplateFormatter
{
    /// <summary>
    /// Formatted message
    /// </summary>
    public interface IFormattedMessage
    {
        /// <summary>
        /// Template name used for formatting
        /// </summary>
        [NotNull] string TemplateName { get; }

        /// <summary>
        /// Partner whos template was finally used for formatting. Null if default template was used
        /// </summary>
        [CanBeNull] string PartnerId { get; }

        /// <summary>
        /// Template language used for formatting
        /// </summary>
        [NotNull] string Language { get; }

        /// <summary>
        /// Formatted message subject
        /// </summary>
        [CanBeNull] string Subject { get; }

        /// <summary>
        /// Formatted message body as plain text
        /// </summary>
        [CanBeNull] string Text { get; }

        /// <summary>
        /// Formatted message body as HTML
        /// </summary>
        [CanBeNull] string Html { get; }
    }
}