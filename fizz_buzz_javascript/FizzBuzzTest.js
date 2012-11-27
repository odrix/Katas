describe("Fizz Buzz - les Specs", function() {

  it("pour 1 dire 1", function() {
    expect(DireNombre(1)).toEqual("1");
  });
  
  it("pour 2 dire 2", function() {
    expect(DireNombre(2)).toEqual("2");
  });
  
  it("pour 3 dire Fizz", function() {
    expect(DireNombre(3)).toEqual("Fizz");
  });
  
  it("pour 4 dire 4", function() {
    expect(DireNombre(4)).toEqual("4");
  });
  
  it("pour 5 dire Buzz", function() {
    expect(DireNombre(4)).toEqual("Buzz");
  });
  
});