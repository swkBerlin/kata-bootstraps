import 'package:dart_test/kata.dart';
import 'package:test/test.dart';

void main() {
  test('Kata', () {
    // Arrange
    const kata = Kata();

    // Act
    final answer = kata.getAnswer();

    // Assert
    expect(answer, 54);
  });
}
