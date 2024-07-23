Rails.application.routes.draw do
  resources :products do
  end
  get '/', to: redirect('/products')
  # Custom error routes
  match '/404', to: 'errors#not_found', via: :all
  match '/500', to: 'errors#internal_server_error', via: :all
end
