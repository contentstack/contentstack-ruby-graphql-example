require_relative 'boot'

require 'rails/all'
require 'graphql/client'
require 'graphql/client/http'

# Require the gems listed in Gemfile, including any gems
# you've limited to :test, :development, or :production.
Bundler.require(*Rails.groups)
# Module Initialized ContentstackRubyGraphqlExample
module ContentstackRubyGraphqlExample
  # Application Class
  class Application < Rails::Application
    # Initialize configuration defaults for originally generated Rails version.
    config.load_defaults 6.0

    # Settings in config/environments/* take precedence over those specified here.
    # Application configuration can go into files in config/initializers
    # -- all .rb files in that directory are automatically loaded after loading
    # the framework and any gems in your application.
  end

  unless (host = Application.secrets.host)
    raise 'Host name missing'

  end

  unless (api_key = Application.secrets.api_key)
    raise 'API Key name missing'

  end

  unless (environment = Application.secrets.environment)
    raise 'Environment missing'

  end

  HTTPAdapter = GraphQL::Client::HTTP.new("https://#{host}/stacks/#{api_key}?environment=#{environment}") do
    def headers(context)
      unless (delivery_token = context[:access_token] || Application.secrets.delivery_token)
        raise 'Delivery token missing'
      end

      {
        'access_token': delivery_token
      }
    end
  end

  Client = GraphQL::Client.new(
    schema: Application.root.join('db/schema.json').to_s,
    execute: HTTPAdapter
  )
end
