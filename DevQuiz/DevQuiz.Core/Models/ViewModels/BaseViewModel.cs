﻿using DevQuiz.Core.Services.Interfaces;
using System;

namespace DevQuiz.Core.Models.ViewModels
{
    public class BaseViewModel
    {
        public IGameWebService GameService
        {
            get { return ServiceContainer.Resolve<IGameWebService>(); }
        }

        public delegate void BussyHandler(object sender, EventArgs e);
        public event BussyHandler OnBusyChanged = delegate { };

        private bool _isBussy;

        public bool IsBussy
        {
            get { return _isBussy; }
            set
            {
                _isBussy = value;
                OnBusyChanged(this, EventArgs.Empty);
            }
        }
    }
}

