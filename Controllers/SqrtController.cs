using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqrtRoot.Models;

namespace SqrtRoot.Controllers
{
    public class SqrtController : Controller
    {
        public ActionResult SqrtRoot(){
            return View();
        }

        [HttpPost]
        public ActionResult SqrtRoot(int firstNumber, int secondNumber)
        {

        
            if ((firstNumber > 0) && (secondNumber > 0) && (firstNumber != secondNumber)){
           double sqrt = 0;
           double large = 0.0;

           double sqrtNum1 = Math.Sqrt(firstNumber);
           double sqrtNum2 = Math.Sqrt(secondNumber);

           if(sqrtNum1 > sqrtNum2){
               sqrt = sqrtNum1;
                large = firstNumber;
           }
           else
           {
               sqrt = sqrtNum2;
               large = secondNumber;
           }
           ViewBag.Sqrt = sqrt;
           ViewBag.Large = large;
            return View();
            
            }
            
         else if ((firstNumber < 0) && (secondNumber < 0)){
            ViewBag.Error = "Please input a positive number";
            return View();
        }

         else if (firstNumber == secondNumber){
            ViewBag.Same = "Numbers entered cannot be equal";
            return View();
        }
        //    double Num1 = double.Parse(firstNumber);
        //    double Num2 = double.Parse(secondNumber);

        else{
            return View();
        }
        }
    }
}