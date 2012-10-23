require "test/unit"
require "roman_number.rb"

class Tester < Test::Unit::TestCase
	
	def test_Ireturn1
		rn = Roman_number.new()
		result = rn.parse('I')
		assert_equal(1, result)
	end

	def test_IIreturn2
		rn = Roman_number.new()
		result = rn.parse('II')
		assert_equal(2, result)
	end


end
