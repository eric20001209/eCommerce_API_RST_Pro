using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eCommerce_API.Data;
using eCommerce_API.Services;

namespace eCommerce_API.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        rst374_cloud12Context _context;//= new rst374_cloud12Context();
        private readonly ISetting _isettings;
        public CategoryController(rst374_cloud12Context context, ISetting isettings)
        {
            _context = context;
            _isettings = isettings;
        }

        [HttpGet()]
        public IActionResult categoryList([FromQuery] string cat, [FromQuery] string scat, [FromQuery] string sscat)
        {
            var list = _context.CodeRelations
                .Where(c => c.IsWebsiteItem == true && c.OnLineRetail == true && c.Skip == false)
                .Where(c => !String.IsNullOrEmpty(c.Cat))
                .Where(c => cat != null ? c.Cat == cat : true)
                .Where(c => scat != null ? c.SCat == scat : true)
                .Where(c => sscat != null ? c.SsCat == scat : true)
                .Join(_context.StockQty.Where(sq => sq.BranchId == _isettings.getOnlineShopId() && sq.Qty > 0),
                c=>c.Code,
                sq => sq.Code,
                (c,sq) => new {
                    c.Cat,
                    c.SCat,
                    c.SsCat
                })
                .Distinct()
                .ToList();

            return Ok(list);
        }
    }
}