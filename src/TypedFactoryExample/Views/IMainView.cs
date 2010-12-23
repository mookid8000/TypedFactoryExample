using System;

namespace TypedFactoryExample.Views
{
    public interface IMainView : IView
    {
        event Action ShowSubFormClicked;
    }
}