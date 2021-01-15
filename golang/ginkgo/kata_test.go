package main

import (
	. "github.com/onsi/ginkgo"
	. "github.com/onsi/gomega"
)

var _ = Describe("Something", func() {
	It("does something", func() {
		Expect(SayHello()).To(Equal("Hello"))
	})
})
