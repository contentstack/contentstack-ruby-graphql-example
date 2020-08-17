
class ProductsController < ApplicationController
    # define query for Peoducts list

    def index
        data = query Query

        render "products/index", locals: {
            all_product: data.all_product
        }
    end    
end
