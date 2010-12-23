using System;

namespace TypedFactoryExample
{
    public interface IView
    {
        void Open();
        event Action Closed;
    }
}