using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.ProductOwners.Any())
            {
                var ProductOwners = new List<ProductOwner>()
                {
                    new ProductOwner()
                    {
                        Product = new Product()
                        {
                            Name = "Pikachu",
                            ProductCategories = new List<ProductCategory>()
                            {
                                new ProductCategory { Category = new Category() { Name = "Electric"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Product",Text = "electric", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Smith" } },
                                new Review { Title="Product", Text = "rocks", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Jones" } },
                                new Review { Title="Product",Text = "random", Rating = 1,
                                Reviewer = new Reviewer(){ Name = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "London",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new ProductOwner()
                    {
                        Product = new Product()
                        {
                            Name = "Squirtle",
                            ProductCategories = new List<ProductCategory>()
                            {
                                new ProductCategory { Category = new Category() { Name = "Water"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Product2", Text = "electric", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Smith" } },
                                new Review { Title= "Product2",Text = "rocks", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Jones" } },
                                new Review { Title= "Product2", Text = "squirtle", Rating = 1,
                                Reviewer = new Reviewer(){ Name = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Potter",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    },
                                    new ProductOwner()
                    {
                        Product = new Product()
                        {
                            Name = "Venasuar",
                            ProductCategories = new List<ProductCategory>()
                            {
                                new ProductCategory { Category = new Category() { Name = "Leaf"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Product3",Text = "electric", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Smith" } },
                                new Review { Title="Product3",Text = "rocks", Rating = 5,
                                Reviewer = new Reviewer(){ Name = "Jones" } },
                                new Review { Title="Product3",Text = "Venasuar", Rating = 1,
                                Reviewer = new Reviewer(){ Name = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            Name = "Ketchum",
                            Country = new Country()
                            {
                                Name = "Millet Town"
                            }
                        }
                    }
                };
                dataContext.ProductOwners.AddRange(ProductOwners);
                dataContext.SaveChanges();
            }
        }
    }
}