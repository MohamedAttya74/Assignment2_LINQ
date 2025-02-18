namespace Assignment2_LINQ;
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









    }

}

            
       


        
    

