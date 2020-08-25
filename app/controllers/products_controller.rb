# Product controller file
class ProductsController < ApplicationController
  def index
    data = query Query

    render 'products/index', locals: {
      all_product: data.all_product
    }
  end
end
