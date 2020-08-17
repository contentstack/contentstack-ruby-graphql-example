using System;
using System.Collections.Generic;

namespace contentstack_dotnet_graphql_example.Models
{
    public class ProductCollection
    {
        public int total { get; set; }
        public List<Product> items { get; set; }
    }
}
