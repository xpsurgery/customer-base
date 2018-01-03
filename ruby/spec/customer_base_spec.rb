require_relative '../customer'
require_relative '../customer_base'

describe CustomerBase do

	subject { CustomerBase.new }

	let(:alice) { Customer.new("Alice", "Rossi", 10000) }
	let(:bob) { Customer.new("Bob", "Rossi", 20000) }
	let(:charlie) { Customer.new("Charlie", "Bianchi", 30000) }

	before do
		subject.add(alice)
		subject.add(bob)
		subject.add(charlie)
  end

	it 'can find by last name' do
		found = subject.findByLastName("Rossi")
		expect(found).to eq([alice, bob])
  end

	it 'can find by first and last name' do
		found = subject.findByFirstAndLastName("Alice", "Rossi")
		expect(found).to eq([alice])
  end

	it 'can find with credit greater than' do
		found = subject.findByCreditGreaterThan(20000)
		expect(found).to eq([charlie])
  end

	it 'can find with credit less than' do
		fail("open-closed violation")
		#
		# We're sick and tired of adding new methods to CustomerBase.
		# CHALLENGE: can you refactor CustomerBase and its tests
		# so that new kinds of queries can be implemented WITHOUT CHANGING CUSTOMERBASE ???
    #
  end
end

