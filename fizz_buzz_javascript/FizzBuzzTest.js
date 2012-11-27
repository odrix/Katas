describe("Fizz Buzz - Fizz pour les multiples de 3 et Buzz pour les multiple de 5", function() {

  it("pour 1 dire  1", function() {
    expect(DireNombre(1)).toEqual("1");
  });
  
  it("pour 2 dire  2", function() {
    expect(DireNombre(2)).toEqual("2");
  });
  
  it("pour 3 dire  Fizz", function() {
    expect(DireNombre(3)).toEqual("Fizz");
  });
  
  it("pour 4 dire  4", function() {
    expect(DireNombre(4)).toEqual("4");
  });
  
  it("pour 5 dire  Buzz", function() {
    expect(DireNombre(5)).toEqual("Buzz");
  });
  
  it("pour 6 dire  Fizz", function() {
    expect(DireNombre(6)).toEqual("Fizz");
  });
  
  it("pour 7 dire  7", function() {
    expect(DireNombre(7)).toEqual("7");
  });
  
  it("pour 8 dire  8", function() {
    expect(DireNombre(7)).toEqual("7");
  });
  
  it("pour 9 dire  Fizz", function() {
    expect(DireNombre(9)).toEqual("Fizz");
  });
  
  it("pour 10 dire Buzz", function() {
    expect(DireNombre(10)).toEqual("Buzz");
  });
  
  it("pour 15 dire FizzBuzz", function() {
    expect(DireNombre(15)).toEqual("FizzBuzz");
  });
  
  it("pour 30 dire FizzBuzz", function() {
    expect(DireNombre(30)).toEqual("FizzBuzz");
  });
  
});

describe("Fizz Buzz Extension - Fizz pour ceux contenant 3 et Buzz pour ceux contenant 5", function() {

  it("pour 13 dire Fizz", function() {
    expect(DireNombre(13)).toEqual("Fizz");
  });
  
  it("pour 52 dire Buzz", function() {
    expect(DireNombre(52)).toEqual("Buzz");
  });
  
  it("pour 51 dire Buzz", function() {
    expect(DireNombre(51)).toEqual("FizzBuzz");
  });
  
  it("pour 53 dire Buzz", function() {
    expect(DireNombre(53)).toEqual("FizzBuzz");
  });
   
});
