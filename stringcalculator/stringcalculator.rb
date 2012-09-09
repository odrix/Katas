
class Calculator
	
	def add(s)
		sumTotal = 0
		unless s.index(',').nil? && s.index('\n').nil?
			s.split(/[,|\\n]/).each do |num|
				sumTotal+=parseInt(num)
			end
		else
			sumTotal = parseInt(s)
		end
		return sumTotal 
	end	       

	def parseInt(num)
		if num.length == 0
			return 0
		end
		return num.to_i
	end
end
