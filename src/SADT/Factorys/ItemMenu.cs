using SADT.Models;
using System.Collections.ObjectModel;

namespace SADT.Factorys
{
    internal interface IItemMenu
    {
        ObservableCollection<CategoryBase> GetItemsMenu();
    }

    internal class TmnItemMenu : IItemMenu
    {
        public ObservableCollection<CategoryBase> GetItemsMenu()
        {
            return new ObservableCollection<CategoryBase>
            {
                new CategoryDefault
                {
                    IsSelected = true,
                    Name = "Техническое задание",
                    Icon =
                        "M14,2H6C4.9,2,4.01,2.9,4.01,4L4,20c0,1.1,0.89,2,1.99,2H18c1.1,0,2-0.9,2-2V8L14,2z M18,20H6V4h7v5h5V20z M8.82,13.05 L7.4,14.46L10.94,18l5.66-5.66l-1.41-1.41l-4.24,4.24L8.82,13.05z",
                    NameModule = "TechnicalTaskWindow"
                },
                new Separator(),
                new CategoryDefault
                {
                    Name = "Общие данные",
                    Icon =
                        "M3 5v14h17V5H3zm4 2v2H5V7h2zm-2 6v-2h2v2H5zm0 2h2v2H5v-2zm13 2H9v-2h9v2zm0-4H9v-2h9v2zm0-4H9V7h9v2z",
                    NameModule = "GeneralDataWindow"
                },
                new CategoryDefault
                {
                    Name = "Обмотки",
                    Icon = "M10 17l5-5-5-5v10z",
                    Children = new ObservableCollection<CategoryDefault>
                    {
                        new CategoryDefault
                        {
                            Name = "Обмотки НН",
                            Icon =
                                "M3 5v14h17V5H3zm4 2v2H5V7h2zm-2 6v-2h2v2H5zm0 2h2v2H5v-2zm13 2H9v-2h9v2zm0-4H9v-2h9v2zm0-4H9V7h9v2z",
                            NameModule = "WindingLowVoltageWindow"
                        },
                        new CategoryDefault
                        {
                            Name = "Обмотки ВН",
                            Icon =
                                "M3 5v14h17V5H3zm4 2v2H5V7h2zm-2 6v-2h2v2H5zm0 2h2v2H5v-2zm13 2H9v-2h9v2zm0-4H9v-2h9v2zm0-4H9V7h9v2z",
                            NameModule = "WindingHighVoltageWindow"
                        },
                        new CategoryDefault
                        {
                            Name = "Обмотки РО",
                            Icon =
                                "M3 5v14h17V5H3zm4 2v2H5V7h2zm-2 6v-2h2v2H5zm0 2h2v2H5v-2zm13 2H9v-2h9v2zm0-4H9v-2h9v2zm0-4H9V7h9v2z",
                            NameModule = "WindingTapVoltageWindow"
                        }
                    }
                },
                new CategoryDefault
                {
                    Name = "Система магнитная",
                    Icon =
                        "M3 5v14h17V5H3zm4 2v2H5V7h2zm-2 6v-2h2v2H5zm0 2h2v2H5v-2zm13 2H9v-2h9v2zm0-4H9v-2h9v2zm0-4H9V7h9v2z",
                    NameModule = "SystemMagneticWindow"
                },
                new CategoryDefault
                {
                    Name = "Тест",
                    Icon =
                        "M3 5v14h17V5H3zm4 2v2H5V7h2zm-2 6v-2h2v2H5zm0 2h2v2H5v-2zm13 2H9v-2h9v2zm0-4H9v-2h9v2zm0-4H9V7h9v2z",
                    NameModule = "StartWindow"
                }
            };
        }
    }

    internal class TmgItemMenu : IItemMenu
    {
        public ObservableCollection<CategoryBase> GetItemsMenu()
        {
            return new ObservableCollection<CategoryBase>
            {
                new CategoryDefault
                {
                    IsSelected = true,
                    Name = "Техническое задание",
                    Icon =
                        "M14,2H6C4.9,2,4.01,2.9,4.01,4L4,20c0,1.1,0.89,2,1.99,2H18c1.1,0,2-0.9,2-2V8L14,2z M18,20H6V4h7v5h5V20z M8.82,13.05 L7.4,14.46L10.94,18l5.66-5.66l-1.41-1.41l-4.24,4.24L8.82,13.05z",
                    NameModule = "TechnicalTaskWindow"
                },
                new Separator()
            };
        }
    }

    internal class TmpngItemMenu : IItemMenu
    {
        public ObservableCollection<CategoryBase> GetItemsMenu()
        {
            return new ObservableCollection<CategoryBase>
            {
                new CategoryDefault
                {
                    IsSelected = true,
                    Name = "Техническое задание №2",
                    Icon =
                        "M14,2H6C4.9,2,4.01,2.9,4.01,4L4,20c0,1.1,0.89,2,1.99,2H18c1.1,0,2-0.9,2-2V8L14,2z M18,20H6V4h7v5h5V20z M8.82,13.05 L7.4,14.46L10.94,18l5.66-5.66l-1.41-1.41l-4.24,4.24L8.82,13.05z",
                    NameModule = "TechnicalTaskWindow"
                },
                new Separator()
            };
        }
    }
}
