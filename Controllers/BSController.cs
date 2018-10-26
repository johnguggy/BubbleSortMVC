using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BubbleSortMVC.Controllers
{
    public class BSController : Controller
    {
        // GET: BS
        public ActionResult Index()
        {
            int[] nums = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = randNum.Next(100);
            }
            ViewBag.nums = BubbleSort(nums);
            return View();
        }
        int[] BubbleSort(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return numbers;
        }
    }
}