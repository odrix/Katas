

function DireNombre (_nombre) {
	if(_nombre % 3 == 0)
		return "Fizz";
		
	if(_nombre % 5 == 0)
		return "Buzz";

	return _nombre.toString();
}