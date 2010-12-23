using TypedFactoryExample.Factories;
using TypedFactoryExample.Views;

namespace TypedFactoryExample.Controllers
{
    public class SubController : ISubController
    {
        readonly ISubView subView;
        readonly ComplexParameterObject parameter;

        public SubController(ISubView subView, ComplexParameterObject parameter)
        {
            this.subView = subView;
            this.parameter = parameter;

            subView.ClickHereButtonClicked += SetText;
        }

        public void Run()
        {
            subView.Open();
        }

        void SetText()
        {
            subView.SetText(parameter.Text);
        }
    }
}