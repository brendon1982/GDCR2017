describe("examples", () => {
    describe("asserts", () => {
        it("fail", () => {
            // Arrange
            // Act
            // Assert
            expect(1).toEqual(2);
        });

        it("pass", () => {
            // Arrange
            // Act
            // Assert
            expect(1).toEqual(1);
        });
    });

    describe("production-example", () => {
        describe("giveMeSomething", () => {
            it("should return something", () => {
                // Arrange
                var sut = require("../src/production-example")
                // Act
                var result = sut.giveMeSomething();
                // Assert
                expect(result).toEqual("something");
            });
        });
    });
});