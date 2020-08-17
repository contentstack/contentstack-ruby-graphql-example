Rails.application.routes.draw do
  resources :products do
  end
  get "/", to: redirect("/products")
end
