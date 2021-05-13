using SADT.Core.Enums;
using System;

namespace SADT.Factorys
{
    internal interface IItemMenuFactory
    {
        IItemMenu CreateItems(TransformerType transformerType);
    }

    internal class ItemMenuFactory : IItemMenuFactory
    {
        public IItemMenu CreateItems(TransformerType transformerType)
        {
            return transformerType switch
            {
                TransformerType.Tm => new TmnItemMenu(),
                TransformerType.Tmn => new TmnItemMenu(),
                TransformerType.Tmg => new TmgItemMenu(),
                TransformerType.Tmpng => new TmpngItemMenu(),
                _ => throw new ArgumentOutOfRangeException(nameof(transformerType), transformerType, null)
            };
        }
    }
}
