require "test/unit"
require "roman_number.rb"

class Tester < Test::Unit::TestCase
	
	def test_Ireturn1
		rn = Roman_number.new()
		result = rn.parse('I')
		assert_equal(1, result)
	end


end
