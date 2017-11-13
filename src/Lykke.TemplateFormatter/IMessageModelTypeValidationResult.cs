namespace Lykke.TemplateFormatter
{
    /// <summary>
    /// Message model type validation result
    /// </summary>
    public interface IMessageModelTypeValidationResult
    {
        /// <summary>
        /// True if current message model type schema fits template requirements
        /// </summary>
        bool IsValid { get; }
    }
}