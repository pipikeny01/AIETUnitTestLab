using System;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestLab1
{
    //重構成可以單元測試驗證service.ValidateMember的邏輯
    //要遵循單元測試只測試一件事
    internal class Program
    {
        private static void Main(string[] args)
        {
            var service = new Service();
            var result = service.ValidateMember("admin", "admin123");

            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}