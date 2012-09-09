
class Calculator
	
	def add(s)
		if s.length == 0
			return 0
		end
		sumTotal = 0
		unless s.index(',').nil?
			s.split(',').each do |num|
				sumTotal+=Integer(num)
			end
		else
			sumTotal = Integer(s)
		end
		return sumTotal #Integer(s)
	end	       
end
