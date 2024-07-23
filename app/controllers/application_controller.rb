# Application controller file
class ApplicationController < ActionController::Base
   # Enable CSRF protection
   protect_from_forgery with: :exception
end
