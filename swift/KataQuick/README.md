# Swift with XCTest

## Installation

[Quick](http://quick.github.io/Quick/) is a BDD testing library that is most popular alternative testing soulution for standard XCTest framework.
It is by default paired with matching framework [Nimble](https://github.com/Quick/Nimble), so they are usually refered as one thing.

Quick can be installed with CocoaPods or with SwiftPM.

## Build and run

Official doc on how to use SwiftPM: [SPM Usage](https://github.com/apple/swift-package-manager/blob/main/Documentation/Usage.md)

To build your package:
```bash
$ swift build
```

(And most importantly) to [run tests](https://github.com/apple/swift-package-manager/blob/main/Documentation/Usage.md#testing):
```bash
$ swift test
```

## How to open this project
The best way to write Swift code is by using [Xcode](https://developer.apple.com/xcode/), but you can also [VSCode](https://code.visualstudio.com) or any other text editor.
In Xcode just select File -> Open and click on folder that contains this file.

To use Swith with other text editors check out [SourceKit LSP from Apple](https://github.com/apple/sourcekit-lsp)
Also for VSCode users, there is official Swift support: [Swift for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=sswg.swift-lang)