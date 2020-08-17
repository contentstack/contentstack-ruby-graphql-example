using System;
using System.Collections.Generic;

namespace contentstack_dotnet_graphql_example.Models
{
    public class AssetConnection
    {
        public int totalCount { get; set; }

        public List<AssetEdge> edges { get; set; }
    }
}
