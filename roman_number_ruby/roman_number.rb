class Roman_number

	@letters_values =  {}

	def initialize()
		@letters_values =  { 'I' => 1, 'V' => 5, 'X' => 10, 'L' => 50, 'C' => 100, 'D' => 500, 'M' => 1000 }
		@letters_values.default = 0
	end

	def parse(letters)
		result = 0
		letters.split(//).each_with_index do |num_char, index|
			if(letters.length > index+1 && is_for_substract(num_char, letters[index+1,1])) 
				result -= parse_letter(num_char)
			else
				result += parse_letter(num_char)
			end
		end
		return result
	end

	private

	def is_for_substract(letter, next_letter)
		return parse_letter(letter) < parse_letter(next_letter)
	end

	def parse_letter(letter)
		return @letters_values[letter]
	end
end

