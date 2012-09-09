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

	def test_CharThreeReturnThree
		calc = Calculator.new
		result = calc.add('3')
		assert_equal(3, result)
	end

	def test_TwoCharReturnFive
		calc = Calculator.new
		result = calc.add('3,2')
		assert_equal(5, result)
	end

	def test_ThreeCharReturnSix
		calc = Calculator.new
		result = calc.add('1,3,2')
		assert_equal(6, result)
	end
	
	def test_ThreeCharWithDifferentDelimiterReturnSix
		calc = Calculator.new
		result = calc.add('1\n3,2')
		assert_equal(6, result)
	end

	def test_NewDemiliter
		calc = Calculator.new
		result = calc.add('\\\\;\n1;2')
		assert_equal(3, result)
	end

	def test_NewDemiliterMoreThanOneChar
		calc = Calculator.new
		result = calc.add('\\\\;#*\n1;#*2;#*3')
		assert_equal(6, result)
	end

	def test_WithTwoNegative
		exception = assert_raise(RuntimeError) {
			calc = Calculator.new
			result = calc.add('\\\\;\n1;-2\n3;-4')
		}
		assert_equal('Negatives not allowed: -2;-4', exception.message)
	end

	def test_NumberMoreThan1000Ignored
		calc = Calculator.new
		result = calc.add('1001,2')
		assert_equal(2, result)
	end
end
