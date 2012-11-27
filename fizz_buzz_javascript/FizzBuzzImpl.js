

function DireNombre (_nombre) {
	var result = ""; 
	if(_nombre % 3 == 0 || _nombre.toString().indexOf("3") >=0 )
		result += "Fizz";
		
	if(_nombre % 5 == 0 || _nombre.toString().indexOf("5") >=0)
		result += "Buzz";
		
	if(result == "")
		result = _nombre.toString()

	return result;
}