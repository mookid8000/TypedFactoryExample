using TypedFactoryExample.Factories;
using TypedFactoryExample.Views;

namespace TypedFactoryExample.Controllers
{
    public class MainController : IMainController
    {
        readonly IMainView mainView;
        readonly IControllerFactory controllerFactory;

        public MainController(IMainView mainView, IControllerFactory controllerFactory)
        {
            this.mainView = mainView;
            this.controllerFactory = controllerFactory;

            mainView.ShowSubFormClicked += ShowSubForm;
        }

        public void Run()
        {
            mainView.Open();
        }

        void ShowSubForm()
        {
            var parameter = new ComplexParameterObject {Text = "parameter from MainController"};
            var subController = controllerFactory.CreateSubController(parameter);
            
            subController.Run();
            
            controllerFactory.ReleaseController(subController);
        }
    }
}