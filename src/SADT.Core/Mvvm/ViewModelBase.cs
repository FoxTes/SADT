﻿using Prism.Mvvm;
using Prism.Navigation;

namespace SADT.Core.Mvvm
{
    /// <summary>
    /// Базовая ViewModel.
    /// </summary>
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        /// <summary>
        /// Освобождает ресурсы, используемые View/ViewModel.
        /// </summary>
        public virtual void Destroy()
        {

        }
    }
}
