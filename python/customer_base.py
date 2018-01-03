class CustomerBase:

    def __init__(self):
        self.customers = []

    def add(self, customer):
        self.customers.append(customer)

    def findByLastName(self, lastName):
        result = []
        for customer in self.customers:
            if customer.lastName == lastName:
                result.append(customer)
        return result

    def findByFirstAndLastName(self, firstName, lastName):
        result = []
        for customer in self.customers:
            if customer.firstName == firstName and customer.lastName == lastName:
                result.append(customer)
        return result

    def findByCreditGreaterThan(self, credit):
        result = []
        for customer in self.customers:
            if customer.credit > credit:
                result.append(customer)
        return result

