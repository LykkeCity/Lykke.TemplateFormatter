using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;

namespace Lykke.TemplateFormatter
{
    public sealed class TemplateNotFoundException : TemplateException
    {
        public TemplateNotFoundException([NotNull] string templateName) : base(templateName, $"Template '{templateName}' not found")
        { }
    }
}
