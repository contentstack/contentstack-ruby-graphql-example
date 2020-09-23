[![Contentstack](https://www.contentstack.com/docs/static/images/contentstack.png)](https://www.contentstack.com/)

## Create a product catalog using Ruby on Rails (or simply Rails), GraphQL Client, and Contentstack's GraphQL APIs.

**About Contentstack**: Contentstack is a headless CMS with an API-first approach that puts content at the centre. It is designed to simplify the process of publication by separating code from content.

**About this project**: This sample app is a professional website built using Rails and Contentstack.
![Homepage Screenshot](./app/assets/images/product_list.png?raw=true "Homepage screenshot")

## Prerequisites

-   [Ruby](https://www.ruby-lang.org/en/documentation/installation/)
-   [Rails Framework](https://rubyonrails.org/)
-   [GraphQL Client](https://rubygems.org/gems/graphql-client)
-   [Contentstack account](https://www.app.contentstack.com/)
-   [Basic knowledge of Contentstack](https://www.contentstack.com/docs/)


## Perform the steps given below to get started.

 - To get your app up and running quickly, you need to download it and change the configuration. Download the app using the command given below:
```
$ git clone https://github.com/contentstack/contentstack-ruby-graphql-example.git 
```
  
 - Once you have downloaded the project, add your Contentstack API Key, Delivery Token, and Environment name to the project. (Learn how to find your Stack's [API Key](https://www.contentstack.com/docs/guide/stack#edit-a-stack) and [Delivery Token](https://www.contentstack.com/docs/guide/tokens#create-a-delivery-token). Read more about [Environments](https://www.contentstack.com/docs/guide/environments)).

 - Now create a ```secrets.yml``` file inside the ```config``` folder and enter your credentials as shown below:

```yml
 development:
    host: <HOST_NAME>
    api_key: <API_KEY>
    delivery_token: <DELIVERY_TOKEN>
    environment: <ENVIRONMENT_NAME> 
```
> Note: You should set Host name to [GraphQL URLs](https://www.contentstack.com/docs/developers/apis/graphql-content-delivery-api/#base-url) for Contentstack. For example 'graphql.contentstack.com'.
 - Run the app by using the following command:
```
$ rails server
```

This command will start the app. Open the browser and go to http://localhost:3000 where you will find the Rails welcome page.


### Tutorial
We have created an in-depth tutorial on how you can create a product catalog app using Rails, GraphQL Client, and Contentstack's GraphQL APIs.

By following the steps given in the step-by-step tutorial, you can create a fully functional product catalog app.

[Create a product catalog using Rails, GraphQL Client, and Contentstack's GraphQL API](https://www.contentstack.com/docs/developers/sample-apps/build-a-product-catalog-app-using-ruby-on-rails-graphql-client-and-contentstack-graphql-apis/)

### Documentation
* Read Contentstack [docs](https://www.contentstack.com/docs/)
* Read Ruby SDK [docs](https://github.com/contentstack/contentstack-ruby)
