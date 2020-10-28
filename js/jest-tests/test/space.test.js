const invade = require("../src/space");
const { planetSizer } = require("../src/services");

jest.mock("../src/services", () => ({
  planetSizer: jest.fn().mockReturnValue(5000),
}));

describe("Invade!!!", () => {
  beforeEach(() => {
    jest.clearAllMocks();
  });

  it("should call planetSizer with the orignal param", () => {
    invade("Earth");
    expect(planetSizer).toHaveBeenCalled();
    expect(planetSizer).toHaveBeenCalledWith("Earth");
  });

  it("should call planetSizer with an unknown planet", () => {
    planetSizer.mockImplementation().mockReturnValue("oops!");
    invade("Unknown");
    expect(planetSizer).toHaveBeenCalled();
    expect(planetSizer).toHaveBeenCalledWith("Unknown");
    console.log(planetSizer.mock.results);
    expect(planetSizer.mock.results[0].value).toBe("oops!");
  });
});
