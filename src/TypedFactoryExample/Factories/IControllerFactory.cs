using TypedFactoryExample.Controllers;

namespace TypedFactoryExample.Factories
{
    public interface IControllerFactory
    {
        ISubController CreateSubController(ComplexParameterObject parameter);
        
        void ReleaseController(IController controller);
    }
}