# Application controller file
class ApplicationController < ActionController::Base
  private

  def query(definition, variables = {})
    response = ContentstackRubyGraphqlExample::Client.query(definition, variables: variables)
    raise Other::NotFoundError, QueryError.new(response.errors[:data].join(', ')) if response.errors.any?

    response.data
  end
end
