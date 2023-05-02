using AzureFunctionsDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctionsDemo.Services.Implementation
{
    class SumaService : ISumaService
    {
        public int Suma(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
