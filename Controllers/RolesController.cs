using System;
using Garderie.Services;
using Microsoft.AspNetCore.Mvc;

namespace Garderie.Controllers
{
public class RolesController : Controller
{
    private readonly IMvcControllerDiscovery _mvcControllerDiscovery;

    public RolesController(IMvcControllerDiscovery mvcControllerDiscovery)
    {
        _mvcControllerDiscovery = mvcControllerDiscovery;
    }

    // GET: Role/Create
    public ActionResult Create()
    {
        ViewData["Controllers"] = _mvcControllerDiscovery.GetControllers();

        return View();
    }
}
}
