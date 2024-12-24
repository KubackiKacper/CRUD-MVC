using System;
using System.Diagnostics;
using CRUD_MVC.Data;
using CRUD_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVC.Controllers;

public class CRUD_MVCController : Controller
{
    private readonly NorthwindDbContext _db;

    private readonly ILogger<CRUD_MVCController> _logger;

    public CRUD_MVCController(ILogger<CRUD_MVCController> logger, NorthwindDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        var employeeList = _db.Employees.ToList();
        return View(employeeList);
    }

    [HttpGet]
    public IActionResult AddEmployee()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddEmployee(Employees obj)
    {
        if (ModelState.IsValid)
        {
            _db.Employees.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return Json(obj);
    }

    [HttpGet]
    public IActionResult EditEmployee(int? EmployeeID)
    {
        if (EmployeeID == null || EmployeeID == 0)
        {
            return NotFound();
        }
        var obj = _db.Employees.Find(EmployeeID);
        return View(obj);
    }

    [HttpPost]
    public IActionResult EditEmployee(Employees model)
    {
        if (ModelState.IsValid)
        {
            var existingEmployee = _db.Employees.Find(model.EmployeeID);

            if (existingEmployee != null)
            {
                existingEmployee.LastName = model.LastName;
                existingEmployee.FirstName = model.FirstName;
                existingEmployee.Title = model.Title;
                existingEmployee.TitleOfCourtesy = model.TitleOfCourtesy;
                existingEmployee.BirthDate = model.BirthDate;
                existingEmployee.HireDate = model.HireDate;
                existingEmployee.Address = model.Address;
                existingEmployee.City = model.City;
                existingEmployee.Region = model.Region;
                existingEmployee.PostalCode = model.PostalCode;
                existingEmployee.Country = model.Country;
                existingEmployee.HomePhone = model.HomePhone;
                existingEmployee.Extension = model.Extension;
                existingEmployee.ReportsTo = model.ReportsTo;

                _db.SaveChanges();
            }
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult DeleteEmployee(int id)
    {
        try
        {
            var obj = _db.Employees.Find(id);

            if (obj == null)
            {
                return Json(new { success = false, error = "Record not found." });
            }

            _db.Employees.Remove(obj);
            _db.SaveChanges();

            return RedirectToAction("index");
        }
        catch (Exception ex)
        {
            return Json(new { success = false, error = ex.Message });
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
