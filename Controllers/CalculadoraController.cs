using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea3.Models;


namespace Tarea3.Controllers
{
    
    public class CalculadoraController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

   public String    suma(int n1=5,  int n2=4)
        {  int n3=n1+n2;
            string mensaje="El resultado de sumar "+ n1  +"+" +n2+"Es igual a  "+n3;
            return mensaje;
        }
       
        public String    multiplicacion(int n1=5,  int n2=4)
        {  int n3=n1*n2;
            string mensaje="El resultado de multiplicar"+ n1  +"+" +n2+"Es igual a  "+n3;
            return mensaje;
        }

    public String    resta(int n1=5,  int n2=4)
        {  int n3=n1-n2;
            string mensaje="El resultado de restar "+ n1  +"+" +n2+"Es igual a  "+n3;
            return mensaje;
        }
       
        public String    division(int n1=5,  int n2=4)
        {  int n3=n1/n2;
            string mensaje="El resultado de dividir"+ n1  +"+" +n2+"Es igual a  "+n3;
            return mensaje;
        }
    
}
}
