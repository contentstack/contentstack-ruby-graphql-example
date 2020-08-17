using System;
using System.Collections.Generic;

namespace contentstack_dotnet_graphql_example.Models
{
    public class Product
    {
        public string title { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public AssetConnection featured_imageConnection { get; set; }
    }
}
