using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EP_Jewellery.Models;
using EP_Jewellery.Areas.Admin.Repository;
using EP_Jewellery.Areas.Admin.Service;

namespace EP_Jewellery.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]

    public class BrandController : Controller   
    {

        private readonly IBrand _brandService;

        public BrandController(IBrand brand)
        {
            _brandService = brand;
        }

        // GET: Admin/Brand
        public IActionResult Index()
        {
            var brands = _brandService.GetAll();
            return View(brands);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BrandMst brand)
        {
            if (ModelState.IsValid)
            {
                _brandService.Create(brand);
                return RedirectToAction("Index"); // Chuyển hướng đến trang "Index"
            }
            return View(brand);
        }

        // Action để hiển thị form chỉnh sửa
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = _brandService.GetById(id);
            if (brand == null)
            {
                return NotFound();
            }

            return View(brand);
        }

        // Action để xử lý việc chỉnh sửa
        [HttpPost]
        public IActionResult Edit(string id, BrandMst brand)
        {
            if (id != brand.Brand_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _brandService.Update(brand);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        // Action để hiển thị trang xác nhận xóa
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = _brandService.GetById(id);
            if (brand == null)
            {
                return NotFound();
            }

            return View(brand);
        }

        // Action để xác nhận và thực hiện xóa
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string id)
        {
            var brand = _brandService.GetById(id);
            if (brand == null)
            {
                return NotFound();
            }

            _brandService.Delete(id);
            return RedirectToAction("Index");
        }

        private bool BrandExists(string id)
        {
            return _brandService.GetById(id) != null;
        }
    }
}
