using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NavigatorChallenge.Controllers
{
    public class FileUploadController : Controller
    {

        [HttpPost("FileUpload")]
        public async Task<IActionResult> Index(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            var filePaths = new List<string>();
            var orderList = new List<Models.TestOrder.Orders>();
            var tradingPartnerList = new List<string>();
            var totalLineItemsList = new List<int>();
            var totalAmountList = new List<decimal>();

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var filePath = Path.GetTempFileName();
                    filePaths.Add(filePath);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            foreach (var filePath in filePaths)
            {
                System.Xml.Serialization.XmlSerializer s = new System.Xml.Serialization.XmlSerializer(typeof(Models.TestOrder.Orders));

                using (StreamReader sr = new StreamReader(filePath))
                {
                    Models.TestOrder.Orders o = (Models.TestOrder.Orders)s.Deserialize(sr);

                    int lineItemCount = o.Order.Summary.TotalLineItemNumber;
                    decimal totalAmount = o.Order.Summary.TotalAmount;

                    int matchingTradingPartnerIndex = orderList.FindIndex(x => x.Order.Header.OrderHeader.TradingPartnerId
                                                                             == o.Order.Header.OrderHeader.TradingPartnerId);

                    if (matchingTradingPartnerIndex == -1)
                    {
                        tradingPartnerList.Add(o.Order.Header.OrderHeader.TradingPartnerId);
                        totalLineItemsList.Add(o.Order.Summary.TotalLineItemNumber);
                        totalAmountList.Add(o.Order.Summary.TotalAmount);
                    }
                    else
                    {
                        int m = tradingPartnerList.FindIndex(x => x == o.Order.Header.OrderHeader.TradingPartnerId);
                        totalLineItemsList[m] += lineItemCount;
                        totalAmountList[m] += totalAmount;
                    }

                    orderList.Add(o);
                }
            }

            List<Models.TestOrder.Orders> sortedOrderList = orderList.OrderBy(x => x.Order.Header.OrderHeader.TradingPartnerId).ToList();
            List<string> sortedTradingPartnerList = tradingPartnerList.OrderBy(x => x).ToList();
            List<int> sortedTotalLineItemsList = new List<int>();
            List<decimal> sortedTotalAmountList = new List<decimal>();

            foreach (string t in sortedTradingPartnerList)
            {
                int m = tradingPartnerList.FindIndex(x => x == t);
                sortedTotalLineItemsList.Add(totalLineItemsList[m]);
                sortedTotalAmountList.Add(totalAmountList[m]);
            }

            //ViewData["totalLineItemsList"] = sortedTotalLineItemsList;
            //ViewData["totalAmountList"] = sortedTotalAmountList;

            TempData["orderList"] = JsonConvert.SerializeObject(sortedOrderList);
            TempData["totalLineItemsList"] = JsonConvert.SerializeObject(sortedTotalLineItemsList);
            TempData["totalAmountList"] = JsonConvert.SerializeObject(sortedTotalAmountList);

            return Redirect("Home/OrderDisplay");
        }
    }
}