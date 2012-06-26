using System;
using System.ComponentModel.Composition;
using Microsoft.Data.Entity.Design.Extensibility;

namespace EFEntityNameScrubberExtension
{
    [PartCreationPolicy(CreationPolicy.Shared)]
    [Export(typeof(IModelGenerationExtension))]
    public class EFEntityNameScrubber : IModelGenerationExtension
    {
        public void OnAfterModelGenerated(ModelGenerationExtensionContext context)
        {
            return;
        }

        public void OnAfterModelUpdated(UpdateModelExtensionContext context)
        {
            return;
        }
    }
}
