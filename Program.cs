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






    }

}

            
       


        
    

