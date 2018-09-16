using Ledger.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Ledger.Controllers
{
    public class TransactionController : Controller
    {
        private List<Transaction> transactions = new List<Transaction>()
        {
            new Transaction()
            {
                ProductID = Guid.Parse("ef29fc61-abcc-4ac1-9c8c-e5e17b266868"),
                UserID = Guid.Parse("539bf338-e5de-4fc4-ac65-4a91324d8111"),
                OccuredAt = new DateTime(2018, 05, 5),
                PriceAtPointInTime = 36,
                Quantity = 5,
                Total = 180
            },
            new Transaction()
            {
                ProductID = Guid.Parse("ef29fc61-abcc-4ac1-9c8c-e5e17b266868"),
                UserID = Guid.Parse("539bf338-e5de-4fc4-ac65-4a91324d8111"),
                OccuredAt = new DateTime(2017, 10, 5),
                PriceAtPointInTime = 39,
                Quantity = 5,
                Total = 180
            },
            new Transaction()
            {
                ProductID = Guid.Parse("d91d2019-e642-4b00-8b10-2bf07c383787"),
                UserID = Guid.Parse("6b2c4788-e1d5-4ef4-8edf-e7d57e31bf4f"),
                OccuredAt = DateTime.Now,
                PriceAtPointInTime = 36,
                Quantity = 5,
                Total = 180
            }
        };

        [HttpGet("/api/transaction/")]
        public List<Transaction> All()
        {
            return transactions;
        }

        [HttpGet("/api/transaction/getbyuserid/{id}")]
        public List<Transaction> GetByUserID(Guid? id)
        {
            return transactions.Where(t => t.UserID == id)
                               .ToList();
        }
    }
}
