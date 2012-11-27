describe("Fizz Buzz - les Specs", function() {

  it("pour 1 dire 1", function() {
    var result = DireNombre(1);
    expect(result).toEqual("1");
  });
  
  it("pour 2 dire 2", function() {
    var result = DireNombre(2);
    expect(result).toEqual("2");
  });
  
  it("pour 3 dire Buzz", function() {
    var result = DireNombre(3);
    expect(result).toEqual("Buzz");
  });
  
});