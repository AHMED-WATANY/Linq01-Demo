namespace Linq01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Var - Dynamic
            // var Data01 = "Ahmed";
            // dynamic Data02 = null;
            //
            // Data02 = 12;
            // Console.WriteLine(Data02.GetType().Name);
            //
            // Data02 = 1.3;
            // Console.WriteLine(Data02.GetType().Name);
            //
            // Data02 = 1.4f;
            // Console.WriteLine(Data02.GetType().Name);
            //
            // Data02 = 1.5m;
            // Console.WriteLine(Data02.GetType().Name);
            //
            // Data02 = true; 
            #endregion

            #region Anonymous Type
            // var E01 = new { Id = 1, Name = "Ahmed", Salary = 20000 };
            // // var E02 = new { Id = 2, Name = "Ali", Salary = 25000 };
            // var E02 = E01 with { Id = 2 };
            //
            // Console.WriteLine(E01.GetType().Name);
            // Console.WriteLine(E02.GetType().Name);
            //
            // if (E01.Equals(E02))
            //     Console.WriteLine("E01 == E02");
            // else
            //     Console.WriteLine("E01 != E02"); 
            #endregion

            #region Extention
            // int Number = 12345;
            //
            // var result = IntExtention.Reverse(Number);
            //
            // Number.Reverse(); 
            //
            // Console.WriteLine(result); 
            #endregion

            #region Linq

            // List<int> Numbers = new List<int>() {1,2,3,4,5,6,7,8,9 };
            // 
            // var result = Enumerable.Any(Numbers, N => N % 2 == 0);
            // // var result = Enumerable.Range(0, 10);
            // Console.WriteLine(result);

            #endregion

            #region Linq Excutipn ways
            // List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9};
            // var result = Numbers.Where(X => X % 2 == 0).ToList();
            //
            // Numbers.AddRange(new int[] { 11, 22, 33, 44, 55 });
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion


        }
    }
}
