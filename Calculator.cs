using System;
using System.Data;

namespace FirstAdaTask
{
    public class Calculator
    {
        private readonly DataTable _dataTable;
        
        public Calculator()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Initiating Calculator...");
            _dataTable = new DataTable();
        }

        public object ComputeMath(string equation)
        {
            return _dataTable.Compute(equation, "");
        }
    }
}