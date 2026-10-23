package main

import (
	. "github.com/onsi/ginkgo/v2"
	. "github.com/onsi/gomega"
)

var _ = Describe("Something", func() {
	It("does something", func() {
		Expect(SayHello()).To(Equal("Hello"))
	})

	It("passing", func() {
		Expect(42).To(Equal(42))
	})
})
