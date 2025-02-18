namespace Assignment2_LINQ;

using Demo01.Data;
using System.Collections.Generic;
using static Assignment2_LINQ.ListGenerator;

internal class Program
{
    static void Main(string[] args)
    {

        #region  LINQ - Aggregate Operators

        #region 1. Get the total units in stock for each product category.
        ///   var Result = ProductList.GroupBy(P => P.Category).Select(P => new
        ///   {
        ///     Category = P.Key,
        ///     Total = P.Sum(P => P.UnitsInStock)
        ///    });
        ///   foreach(var item in Result) 
        ///       Console.WriteLine(item);

        #endregion

        #region 2. Get the cheapest price among each category's products
        ///  var Result = ProductList.GroupBy(P => P.Category).Select(P => new
        ///   {
        ///     Category = P.Key,
        ///     MinPrice = P.Min(P => P.UnitPrice)
        ///    });
        ///
        ///   foreach(var item in Result) 
        ///      Console.WriteLine(item);


        #endregion

        #region 3. Get the products with the cheapest price in each category (Use Let)
        /// var Result = from P in ProductList
        ///              group P by P.Category
        ///             into ProductGroup
        ///              let MinPrice = ProductList.Min(P => P.UnitPrice)
        ///              from P in ProductList
        ///              where P.UnitPrice == MinPrice
        ///              select new
        ///              {
        ///                  P.Category,
        ///                  P.ProductName,
        ///                  P.UnitPrice,
        ///              };
        ///
        ///        foreach (var Product in Result)
        ///                     Console.WriteLine(Product);
        #endregion

        #region 4. Get the most expensive price among each category's products.

        ///  var Result = ProductList.GroupBy(P => P.Category).Select(P => new
        ///  {
        ///      CategoryName = P.Key,
        ///      MostExpensivePrice = P.Max( P => P.UnitPrice)
        ///  });
        /// 
        ///    foreach (var Product in Result)
        ///           Console.WriteLine(Product);
        /// 




        #endregion

        #region  5. Get the products with the most expensive price in each category.

        ///   var Result = from P in ProductList
        ///                group P by P.Category
        ///                 into Categorys
        ///                let MaxPrice = ProductList.Max(P => P.UnitPrice)
        ///                from P in Categorys
        ///                where P.UnitPrice == MaxPrice
        ///                select new
        ///                {
        ///                    P.Category,
        ///                    P.ProductName,
        ///                    P.UnitPrice,
        ///                };
        ///
        ///
        ///   foreach (var Product in Result)
        ///       Console.WriteLine(Product);


        #endregion



        #endregion


        #region LINQ - Set Operators

        #region  1. Find the unique Category names from Product List
        ///  var Result = ProductList.Select(P => P.Category)
        ///                       .Distinct();
        /// 
        /// 
        ///            foreach (var Product in Result)
        ///                Console.WriteLine(Product); 
        #endregion

        #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

        /// var Result = ProductList.Select(P => P.ProductName.First())
        ///                       .Union(CustomerList.Select(C => C.CustomerName.First()))
        ///                       .Distinct();
        /// 
        ///               foreach (var Product in Result)
        ///                   Console.WriteLine(Product);
        /// 


        #endregion

        #region 3. Create one sequence that contains the common first letter from both product and customer names.

        ///  var Result = ProductList.Select(P => P.ProductName.First())
        ///                        .Intersect(CustomerList.Select(C => C.CustomerName.First()));
        ///                        
        ///  
        ///                foreach (var Product in Result)
        ///                    Console.WriteLine(Product);

        #endregion

        #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
        ///  var Result = ProductList.Select(P => P.ProductName.First())
        ///                        .Except(CustomerList.Select(C => C.CustomerName.First()));
        ///                        
        ///                 foreach (var Product in Result)
        ///                     Console.WriteLine(Product);





        #endregion

        #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
        ///  var Result = ProductList.Select (P => P.ProductName.Length >=3 ) 
        ///                        .Concat(CustomerList.Select(C => C.CustomerName.Length >=3));
        ///                                                                  
        ///                                                             Error Solution 
        ///                 foreach (var Product in Result)
        ///                     Console.WriteLine(Product);
        ///   
        #endregion

        #endregion

        #region LINQ - Partitioning Operators
        #region 1. Get the first 3 orders from customers in Washington
        ///  var Result = CustomerList.Where(C => C.City == "Washington").SelectMany(C => C.Orders)
        ///                                                   .OrderBy(C => C.OrderDate)
        ///                                                   .Take(3);
        ///  foreach (var Customer in Result)
        ///  {
        ///      Console.WriteLine(Customer);
        ///  }
        /// 






        #endregion

        #region 2. Get all but the first 2 orders from customers in Washington.

        ///   var Result = CustomerList.Where(C => C.City == "Washington").SelectMany(C => C.Orders)
        ///                                                    .OrderBy(C => C.OrderDate)
        ///                                                    .Skip(2);
        ///   foreach (var Customer in Result)
        ///   {
        ///       Console.WriteLine(Customer);
        ///   }


        #endregion

        #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

        ///   int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        /// 
        ///   var Result = Numbers.TakeWhile((N, I) => N > I);
        ///   foreach (var number in Result)
        ///       Console.WriteLine(number);


        #endregion

        #region 4.Get the elements of the array starting from the first element divisible by 3.

        //   int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // 
        //   var Result = Numbers.SkipWhile(num => num % 3 != 0);
        //   foreach (var Number in Result)
        //       Console.WriteLine(Number);

        #endregion

        #region 5. Get the elements of the array starting from the first element less than its position.
        /// int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        /// 
        /// var Result = Numbers.SkipWhile((num, index) => num >= index);
        ///            foreach (var Number  in Result)
        ///     Console.WriteLine(Number);

        #endregion




        #endregion


        #region LINQ – Grouping Operators
        #region   1.Use group by to partition a list of numbers by their remainder when divided by 5

      ///  List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
      ///  var Result = numbers.GroupBy(num => num % 5)
      ///      .OrderBy(group => group.Key);
      /// 
      ///  foreach (var group in Result)
      ///  {
      ///      Console.WriteLine( $" Numbers with remainder {group.Key} when divided by 5: ");
      ///      foreach (var num in group)
      ///      {
      ///          Console.WriteLine(num  );
      ///      }
      ///      
      ///  }
        #endregion



        #endregion
    }

}
   



       
   




            
       


        
    

