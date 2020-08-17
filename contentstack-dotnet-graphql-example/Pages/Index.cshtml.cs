using System;
using System.Threading.Tasks;
using contentstack_dotnet_graphql_example.Models;
using GraphQL;
using GraphQL.Client.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace contentstack_dotnet_graphql_example.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly GraphQLHttpClient _client;

        [BindProperty]
        public ProductResponse Products { get; set; }

        public int CurrentPage = 1;
        public IndexModel(ILogger<IndexModel> logger, GraphQLHttpClient client)
        {
            _logger = logger;
            _client = client;
        }

        public bool ShowPrevious => CurrentPage > 1;

        public async Task OnGetAsync(int currentpage = 1)
        {
            CurrentPage = currentpage;
            var query = new GraphQLRequest
            {
                Query = @"query Products($skip: Int ,$limit: Int){
                  all_product(locale:""en-us"", skip:$skip, limit:$limit) {
                    total
                    items{
                      title
                      description
                      price
                      featured_imageConnection (limit: 10){
                         edges{
                            node {
                                url
                                filename
                            }
                        }
                      }  
                    }
                  }
                }",
                OperationName = "Products",
                Variables = new {
                    skip = (CurrentPage - 1) * 6,
                    limit = 6
                }
            };
            try
            {
                var response = await _client.SendQueryAsync<ProductResponse>(query);
                Products = response.Data;
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
