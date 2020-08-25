Query = ContentstackRubyGraphqlExample::Client.parse <<-'GRAPHQL'
    query {
        all_product(locale:"en-us",limit:10) {
            total
            items {
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
    }
GRAPHQL
