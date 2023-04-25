using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            GuideManager guideManager = new GuideManager(new EfGuideDal());
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
