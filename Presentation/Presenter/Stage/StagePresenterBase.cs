﻿using Presentation.View.Interface;

namespace Presentation.Presenter.Stage
{
    public abstract class StagePresenterBase : IStagePresenter
    {
        protected StagePresenterBase(IStageView view)
        {
            View = view;
            View.OnOpened = () => InitializeStage();
        }

        public void OpenStage() => View.OpenStage();

        public void CloseStage() => View.CloseStage();

        protected readonly IStageView View;

        protected abstract void InitializeStage();
    }
}