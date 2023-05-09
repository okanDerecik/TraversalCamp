﻿using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _LastDestinations : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _LastDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetLastForDestinations();
            return View(values);
        }
    }
}
