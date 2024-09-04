package kata

import (
	"github.com/stretchr/testify/assert"
	"testing"
)

func TestFailing(t *testing.T) {
	assert.Equal(t, 42, doSomething("a"), "I'm failing you can start with me...")
}

func TestSomething(t *testing.T) {
	assert.Equal(t, 42, doSomething("b"), "Answer to the Ultimate Question of Life, the Universe, and Everything")
}

func TestGen(t *testing.T) {
	tests := []struct {
		name     string
		input    string
		expected int
	}{
		{
			name:     "with a expected 0",
			input:    "a",
			expected: 0,
		},
		{
			name:     "with b expected 42",
			input:    "b",
			expected: 42,
		},
	}
	for _, tt := range tests {
		t.Run(tt.name, func(t *testing.T) {
			if got := doSomething(tt.input); got != tt.expected {
				t.Errorf("doSomething() = %v, but expected %v", got, tt.expected)
			}
		})
	}
}

func doSomething(input string) interface{} {
	if input == "b" {
		return 42
	}
	return 0
}
