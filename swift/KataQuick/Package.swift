// swift-tools-version: 5.5
// The swift-tools-version declares the minimum version of Swift required to build this package.

import PackageDescription

let package = Package(
    name: "KataQuick",
    products: [
        // Products define the executables and libraries a package produces, and make them visible to other packages.
        .library(
            name: "Kata",
            targets: ["Kata"]),
    ],
    dependencies: [
         .package(url: "https://github.com/Quick/Quick.git", from: "5.0.1"),
         .package(url: "https://github.com/Quick/Nimble.git", from: "9.1.0"),
    ],
    targets: [
        // Targets are the basic building blocks of a package. A target can define a module or a test suite.
        // Targets can depend on other targets in this package, and on products in packages this package depends on.
        .target(
            name: "Kata",
            dependencies: []),
        .testTarget(
            name: "KataTests",
             dependencies: ["Kata", "Quick", "Nimble"]),
    ]
)
