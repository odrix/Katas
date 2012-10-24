class Roman_number

	@letters_values =  {}

	def initialize()
		@letters_values =  { 'I' => 1, 'V' => 5, 'X' => 10, 'L' => 50, 'C' => 100 }
		@letters_values.default = 0
	end

	def parse(letters)
		result = 0
		letters.split(//).each_with_index do |num_char, index|
			if(letters.length > index+1 && letters[index+1,1] != "I") 
				result -= parseOneLetter(num_char)
			else
				result += parseOneLetter(num_char)
			end
		end
		return result
	end

	private

	def parseOneLetter(letter)
		return @letters_values[letter]
	end
end

