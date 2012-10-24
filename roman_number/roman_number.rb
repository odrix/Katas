class Roman_number
	
	def parse(letters)
		result = 0
		letters.split(//).each_with_index do |num_char, index|
			if(letters.length > index+1 && (letters[index+1,1] == "V" || letters[index+1,1] == "X"))
				result -= parseOneLetter(num_char)
			else
				result += parseOneLetter(num_char)
			end
		end
		return result
	end

	def parseOneLetter(letter)
		if(letter == 'I')
			return 1
		end
		if(letter == 'V')
			return 5
		end
		if(letter == 'X')
			return 10
		end
		if(letter == 'L')
			return 50
		end
		return 0
	end
end

