abstract class RemoteLogger {
  public abstract Log(message: string): Promise<void>
}

export {
  RemoteLogger
}
