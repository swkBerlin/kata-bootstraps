 import Quick
 import Nimble

@testable import Kata

 final class SpeakerSpec: QuickSpec {

     override func spec() {
         var speaker: Speaker!

         beforeEach {
             speaker = Speaker()
         }

         describe("Initialization") {
             it("should have valid default value for text") {
                 expect(speaker.text).to(equal("Default text"))
             }
         }

         describe("Saying Something") {
             it("has to be able to say something") {
                 expect(speaker.saySomething()).notTo(beEmpty())
             }

             it("should say provided text") {
                 speaker = Speaker(text: "Sample text")
                 expect(speaker.saySomething()).to(equal("Sample text"))
             }

             it("should say default text") {
                 expect(speaker.saySomething()).to(equal("Some default text"))
             }
         }
     }
 }
