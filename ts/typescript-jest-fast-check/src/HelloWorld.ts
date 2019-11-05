import { RemoteLogger } from './RemoteLogger'

class HelloWorld {
  public dependency: RemoteLogger

  constructor(dependency: RemoteLogger) {
    this.dependency = dependency
  }

  public Say(message: string): void {
    this.dependency.Log(message)
  }

  public async SayAsync(message: string): Promise<void> {
    return this.dependency.Log(message)
  }
}

export {
  HelloWorld
}
