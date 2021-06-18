namespace SADT.Core.Enums
{
    /// <summary>
    /// Тип события загрузки данных для приложения.
    /// </summary>
    public enum LoadEventType
    {
        /// <summary>
        /// Открыт существующий проект из файла.
        /// </summary>
        OpenProject,

        /// <summary>
        /// Создан новый проект.
        /// </summary>
        NewProject,

        /// <summary>
        /// Проект был закрыт.
        /// </summary>
        CloseProject,

        /// <summary>
        /// Проект сохранен в текущий файл.
        /// </summary>
        SaveProject,

        /// <summary>
        /// Проект сохранен как.
        /// </summary>
        SaveAsProject,

        /// <summary>
        /// Проект загружен без кода.
        /// </summary>
        Default
    }
}
