using JetBrains.Annotations;

namespace Lykke.TemplateFormatter
{
    /// <summary>
    /// Template formatting result message
    /// </summary>
    public interface ITemplateFormatingResult
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
        /// Subject
        /// </summary>
        [CanBeNull] string Subject { get; }

        /// <summary>
        /// Text body
        /// </summary>
        [CanBeNull] string Text { get; }

        /// <summary>
        /// HTML body
        /// </summary>
        [CanBeNull] string Html { get; }
    }
}