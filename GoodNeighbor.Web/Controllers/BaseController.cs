using GoodNeighbor.Models.ViewModels;
using System.Web.Mvc;

namespace GoodNeighbor.Web.Controllers
{
    public class BaseController : Controller
    {
        protected T GetViewModel<T>() where T : BaseViewModel, new()
        {
            T model = new T();

            //customize base view model here

            return model;
        }
    }
}
