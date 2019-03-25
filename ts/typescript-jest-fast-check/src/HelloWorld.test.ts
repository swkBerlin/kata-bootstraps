import { HelloWorld } from './HelloWorld'
import { RemoteLogger } from './RemoteLogger'
import { assert, property, string } from 'fast-check'

// 👇 Test example using a mock/spy without async/await
describe('Saying Hello World', () => {
  it('should log everything using the remote logger', () => {
    assert(property(string(), (message) => {
      // Arrange
      const stubLogger: RemoteLogger = {
        Log: jest.fn()
      }
      const sut = new HelloWorld(stubLogger)

      // Act
      sut.Say(message)

      // Assert
      expect(stubLogger.Log).toHaveBeenCalledWith(message)
    }))
  })

  it('should log something using the remote logger', () => {
    // Arrange
    const message: string = 'Hello World!'
    const stubLogger: RemoteLogger = {
      Log: jest.fn()
    }
    const sut = new HelloWorld(stubLogger)

    // Act
    sut.Say(message)

    // Assert
    expect(stubLogger.Log).toHaveBeenCalledWith(message)
  })
})

// 👇 Test example using a mock/spy with async/await
describe('Saying Hello World asynchronously', () => {
  it('should log something using the remote logger', async () => {
    // Arrange
    const message: string = 'Hello World!'
    const stubLogger: RemoteLogger = {
      Log: jest.fn()
    }
    const sut = new HelloWorld(stubLogger)

    // Act
    await sut.SayAsync(message)

    // Assert
    expect(stubLogger.Log).toHaveBeenCalledWith(message)
  })
})
