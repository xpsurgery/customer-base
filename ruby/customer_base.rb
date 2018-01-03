class CustomerBase

	def initialize
    @customers = []
  end

	def add(customer)
		@customers << customer
  end

	def findByLastName(lastName)
		result = []
		@customers.each do |customer|
			if customer.lastName == lastName
				result << customer
      end
    end
		result
  end

	def findByFirstAndLastName(firstName, lastName)
		result = []
		@customers.each do |customer|
			if customer.firstName == firstName && customer.lastName == lastName
				result << customer
      end
    end
		result
  end

	def findByCreditGreaterThan(credit)
		result = []
		@customers.each do |customer|
			if customer.credit > credit
				result << customer
      end
    end
		result
  end

end

