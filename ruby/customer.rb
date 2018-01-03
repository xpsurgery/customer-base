class Customer

  attr_reader :firstName, :lastName, :credit

	def initialize(firstName, lastName, credit)
		@firstName = firstName
		@lastName = lastName
		@credit = credit
  end

end

