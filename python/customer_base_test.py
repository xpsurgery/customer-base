import unittest
from customer_base import CustomerBase
from customer import Customer

class CustomerBaseTest(unittest.TestCase):

    def setUp(self):
        self.alice = Customer("Alice", "Rossi", 10000)
        self.bob = Customer("Bob", "Rossi", 20000)
        self.charlie = Customer("Charlie", "Bianchi", 30000)
        self.subject = CustomerBase()
        self.subject.add(self.alice)
        self.subject.add(self.bob)
        self.subject.add(self.charlie)

    def testFindByLastName(self):
        found = self.subject.findByLastName("Rossi")
        self.assertEqual([self.alice, self.bob], found)

    def testFindByFirstAndLastName(self):
        found = self.subject.findByFirstAndLastName("Alice", "Rossi")
        self.assertEqual([self.alice], found)

    def testFindWithCreditGreaterThan(self):
        found = self.subject.findByCreditGreaterThan(20000)
        self.assertEqual([self.charlie], found)

    def testFindWithCreditLessThan(self):
        self.fail("open-closed violation")
        #
        # We're sick and tired of adding new methods to CustomerBase.
        # CHALLENGE: can you refactor CustomerBase and its tests
        # so that new kinds of queries can be implemented WITHOUT CHANGING CUSTOMERBASE ???
        #

