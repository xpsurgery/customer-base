class Customer

  attr_reader :first_name, :last_name, :credit

	def initialize(first_name, last_name, credit)
		@first_name = first_name
		@last_name = last_name
		@credit = credit
  end

end

