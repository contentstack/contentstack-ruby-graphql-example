class ApplicationController < ActionController::Base

    private
    def query(definition, variables = {})
        response = ContentstackRubyGraphqlExample::Client.query(definition, variables: variables)
  
        if response.errors.any?
          raise QueryError.new(response.errors[:data].join(", "))
        else
          response.data
        end
    end

end
