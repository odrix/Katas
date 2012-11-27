
class Calculator
	@is_error_on_negative = false
	@negative_list_found = []
	
	def add(s)
		@is_error_on_negative = false
		@negative_list_found = []
		delimiter = ','
		if s.start_with?('\\\\')
			delimiter = s[2..s.index('\n')-1]
			s = s[s.index('\n')+2..-1]
		end
		sum_total = 0
		unless s.index(delimiter).nil? && s.index('\n').nil?
			s.split(/[#{delimiter}|\\n]/).each do |num|
				sum_total += parse_int(num)
			end
		else
			sum_total = parse_int(s)
		end
		if @is_error_on_negative
			raise 'Negatives not allowed: ' + @negative_list_found.join(delimiter)
		end
		return sum_total 
	end	       

	def parse_int(num)
		if num.length == 0 || (num.length == 4 && num != "1000")
			return 0
		end
		if num.start_with?('-')
			@is_error_on_negative = true
			@negative_list_found.push(num)
		end
		return num.to_i
	end
end
