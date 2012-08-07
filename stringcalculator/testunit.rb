require "test/unit"
require "stringcalculator.rb"

class Tester < Test::Unit::TestCase

	def test_EmptyReturnZero
		calc = Calculator.new
		result = calc.add('')
		assert_equal(0, result)
	end

	def test_CharOneReturnOne
		calc = Calculator.new
		result = calc.add('1')
		assert_equal(1, result)
	end

	def test_CharThreeReturnThre
		calc = Calculator.new
		result = calc.add('3')
		assert_equal(3, result)
	end
end
