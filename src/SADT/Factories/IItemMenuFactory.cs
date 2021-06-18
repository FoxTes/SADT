using System;
using SADT.Core.Enums;

namespace SADT.Factories
{
    /// <summary>
    /// Фабрика для создания элементов меню.
    /// </summary>
    internal interface IItemMenuFactory
    {
        /// <summary>
        /// Создает элементы меню в зависимости от типа трансформатора.
        /// </summary>
        /// <param name="transformerType">Тип трансформатора.</param>
        /// <returns>Элементы меню.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Нет реализации.</exception>
        IItemMenu CreateItems(TransformerType transformerType);
    }

    /// <inheritdoc />
    internal class ItemMenuFactory : IItemMenuFactory
    {
        /// <inheritdoc/>
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
