using System;

namespace TypedFactoryExample.Views
{
    public interface ISubView : IView
    {
        void SetText(string text);
        event Action ClickHereButtonClicked;
    }
}