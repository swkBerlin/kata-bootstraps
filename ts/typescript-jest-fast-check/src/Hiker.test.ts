import { assert, property, string } from 'fast-check'
import { Hiker } from './Hiker'

describe('Hiker', () => {
  it('answers 42 for any question', () => {
    assert(property(string(), (question) => {
      // Arrange
      const hiker = new Hiker()

      // Act
      const answer = hiker.askQuestion(question)

      // Assert
      expect(answer).toBe(42)
    }))
  })
})
