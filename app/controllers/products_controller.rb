# Product controller file
class ProductsController < ApplicationController
  def index
    
    response = Product::fetchProduct
    data = response.data.all_product

    render 'products/index', locals: {
      all_product: data
    }
  end
end
