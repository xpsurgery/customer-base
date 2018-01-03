class CustomerBase

	def initialize
    @customers = []
  end

	def add(customer)
		@customers << customer
  end

	def find_by_last_name(last_name)
		result = []
		@customers.each do |customer|
			if customer.last_name == last_name
				result << customer
      end
    end
		result
  end

	def find_by_first_and_last_name(first_name, last_name)
		result = []
		@customers.each do |customer|
			if customer.first_name == first_name && customer.last_name == last_name
				result << customer
      end
    end
		result
  end

	def find_by_credit_greater_than(credit)
		result = []
		@customers.each do |customer|
			if customer.credit > credit
				result << customer
      end
    end
		result
  end

end

