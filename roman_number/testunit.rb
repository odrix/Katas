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

	def test_Vreturn5
		rn = Roman_number.new()
		result = rn.parse('V')
		assert_equal(5, result)
	end

	def test_VIreturn6
		rn = Roman_number.new()
		result = rn.parse("VI")
		assert_equal(6, result)
	end

	def test_IVreturn4
		rn = Roman_number.new()
		result = rn.parse("IV")
		assert_equal(4, result)
	end

	def test_Xreturn10
		rn = Roman_number.new()
		result = rn.parse('X')
		assert_equal(10, result)
	end

	def test_IXXreturn19
		rn = Roman_number.new()
		result = rn.parse('XIX')
		assert_equal(19, result)
	end

	def test_Lreturn50
		rn = Roman_number.new()
		result = rn.parse('L')
		assert_equal(50, result)
	end

	def test_XLIXreturn49
		rn = Roman_number.new()
		result = rn.parse('XLIX')
		assert_equal(49, result)
	end

	def test_Creturn100
		rn = Roman_number.new()
		result = rn.parse('C')
		assert_equal(100, result)
	end

	def test_XCIXreturn99
		rn = Roman_number.new()
		result = rn.parse('XCIX')
		assert_equal(99, result)
	end

end
