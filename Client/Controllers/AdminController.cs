﻿using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

		public IActionResult QuanLyDichVu()
		{
			return View();
		}

		public IActionResult QuanLyUser()
		{
			return View();
		}
		public IActionResult BaoCaoThongKe()
		{
			return View();
		}
	}
}
