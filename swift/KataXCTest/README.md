# Swift with XCTest

## Installation

XCTest is a standard testing framework from Apple.
It comes bundled up with Xcode and bundled up with SwiftPM for other platforms.
Open-source version could be found [here](https://github.com/apple/swift-corelibs-xctest)

## Using Swift SPM

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