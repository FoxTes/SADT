using System;

namespace SADT.Core.Abstractions
{
    /// <summary>
    /// Предоставляет реализацию закрытия окна из другого представления.
    /// </summary>
    public interface ICloseWindows
    {
        /// <summary>
        /// Закрывает окно вручную.
        /// </summary>
        Action Close { get; set; }

        /// <summary>
        /// Метод который определяет, возможно ли закрыть окно.
        /// </summary>
        bool CanClose();
    }
}