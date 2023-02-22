using EFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    internal class Program
    {
        public static void InsertProduct()
        {
            using(var dbcon=new ProdContext()) 
            {
                Product product = new Product(); //first it was mysore sandal and santoor
                product.Name="Liril";
                dbcon.Add(product);
                product=new Product();
                product.Name = "Medimix";
                dbcon.Add(product);
                dbcon.SaveChanges();
                    

            }
            return;
        }
        public static void ReadProduct()
        {
            using(var dbcon=new ProdContext())
            {
                List<Product>prds=dbcon.Products.ToList(); //can get the values w/o using List line and in foreach can use dbcon.products to get the o/p
                foreach(var pr in prds)
                {
                    Console.WriteLine(pr.Name + " " + pr.Id);
                }
            }
        }
        public static void UpdateProduct()

        {
            using(var dbcon=new ProdContext())
            {
                Product ? prd = dbcon.Products.Find(3);
                prd.Name = "Dove";
                dbcon.SaveChanges();
            }
        }
        public static void DeleteProduct()
        {
            using(var dbcon=new ProdContext())
            {
                Product ? prod=dbcon.Products.Find(2);
                dbcon.Products.Remove(prod);
                dbcon.SaveChanges();

            }
        }
        public static void InsertBatch()
        {
            using (var db = new ProdContext())
            {
                ProductBatch pb= new ProductBatch();
                pb.BatchId = 1;
                pb.Description = "Only soap with 100% pure sandalwood oil";
                pb.Quantity = 30;
                pb.Price= 20;
                //pb.Product.Id =1;
                //db.Add(pb);
                db.SaveChanges();
                

            }
            

        }
        public static void InsertStandard()
        {
            using(var dbs=new ProdContext())
            {
                Standard std= new Standard();
                std.StandardName = "First Year";
                dbs.Add(std);
                dbs.SaveChanges();
                std = new Standard();
                std.StandardName = "Second Year";
                dbs.Add(std);
                dbs.SaveChanges();
                std = new Standard();
                std.StandardName = "Third Year";
                dbs.Add(std);
                dbs.SaveChanges() ;
                std = new Standard();
                std.StandardName = "Final Year";
                dbs.Add(std);
                dbs.SaveChanges();
            }
        }
        public static void InsertStudent()
        {
            using (var dbs = new ProdContext())
            {
                Student stu = new Student();
                stu.Name = "Ram";
                stu.StandardRefId = 1;
                dbs.Add(stu);
                dbs.SaveChanges();
                stu = new Student();
                stu.Name = "Sai";
                stu.StandardRefId = 2;
                dbs.Add(stu);
                dbs.SaveChanges();
                stu = new Student();
                stu.Name = "Sita";
                stu.StandardRefId = 3;
                dbs.Add(stu);
                dbs.SaveChanges();
                stu = new Student();
                stu.Name = "Lakhan";
                stu.StandardRefId = 4;
                dbs.Add(stu);
                dbs.SaveChanges();
            }
        }

                

           public static void Main(string[] args) 
        {
            //InsertProduct();
            // ReadProduct();
            //UpdateProduct(); //commented for doing productbatch
            //DeleteProduct();
            // InsertBatch();
            //InsertStandard();
            InsertStudent();
            Console.WriteLine("Success");
        }
    }
}
