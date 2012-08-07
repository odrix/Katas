require "test/unit"
require "stringcalculator.rb"

class Tester < Test::Unit::TestCase

	def test_CharOneReturnOne
		calc = Calculator.new
		result = calc.calculate()
		assert_equal(1, result)
	end
end
