using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace contentstack_dotnet_graphql_example
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string Host = Configuration.GetValue<string>("ContentstackOptions:Host");
            string ApiKey = Configuration.GetValue<string>("ContentstackOptions:ApiKey");
            string DeliveryToken = Configuration.GetValue<string>("ContentstackOptions:DeliveryToken");
            string Environment = Configuration.GetValue<string>("ContentstackOptions:Environment");

            string endPoint = $"https://{Host}/stacks/{ApiKey}?environment={Environment}";
            GraphQLHttpClient httpClient = new GraphQLHttpClient(endPoint, new NewtonsoftJsonSerializer());
            httpClient.HttpClient.DefaultRequestHeaders.Add("access_token", DeliveryToken);
            services.AddSingleton(s => httpClient);

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
