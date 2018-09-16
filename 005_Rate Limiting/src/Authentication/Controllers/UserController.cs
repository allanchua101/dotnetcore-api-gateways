using Authentication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Authentication.Controllers
{
    public class UserController : Controller
    {
        #region Private Methods
        private List<User> users = new List<User>()
        {
            new User() {FirstName = "Allan", LastName = "Chua", UserId = Guid.Parse("539bf338-e5de-4fc4-ac65-4a91324d8111")},
            new User() {FirstName = "Burr", LastName = "Sutter", UserId = Guid.Parse("6b2c4788-e1d5-4ef4-8edf-e7d57e31bf4f")},
            new User() {FirstName = "Josh", LastName = "Long", UserId = Guid.Parse("3a4149fa-32e9-4d4a-a051-5c49b7ed2fca")}
        };
        #endregion

        [HttpGet("/api/user/")]
        public List<User> All()
        {
            return users;
        }

        [HttpGet("/api/user/getbyid/{id}")]
        public User GetByID(Guid? id)
        {
            return users.FirstOrDefault(u => u.UserId == id);
        }
    }
}
