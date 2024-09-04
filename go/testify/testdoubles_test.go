package kata

import (
	"errors"
	"github.com/stretchr/testify/assert"
	"github.com/stretchr/testify/mock"
	"testing"
)

// This is an example how to use testdoubles (eg. Stubs, Mocks) in golang
//https://github.com/stretchr/testify#mock-package
//https://martinfowler.com/bliki/TestDouble.html

type Service interface {
	DoSomething(number int) (bool, error)
}

type RealService struct {
}

func (m *RealService) DoSomething(number int) (bool, error) {
	return false, errors.New("really expensive 3rd party call")
}

func UnderTest(service Service, number int) (bool, error) {
	return service.DoSomething(number)
}

type MyTestDoubleObject struct {
	mock.Mock
}

func (m *MyTestDoubleObject) DoSomething(number int) (bool, error) {
	args := m.Called(number)
	return args.Bool(0), args.Error(1)
}

func TestRealServiceIsFailing(t *testing.T) {
	_, err := UnderTest(new(RealService), 42)
	assert.Equal(t, "really expensive 3rd party call", err.Error())
}

type MyStub struct {
}

func (m *MyStub) DoSomething(number int) (bool, error) {
	return true, nil
}
func TestMyStubIsReturningTrue(t *testing.T) {
	result, err := UnderTest(new(MyStub), 42)
	assert.True(t, result)
	assert.Nil(t, err)
}

func TestStubIsReturningTrue(t *testing.T) {
	stub := new(MyTestDoubleObject)

	stub.On("DoSomething", mock.Anything).Return(true, nil)

	result, err := UnderTest(stub, 42)
	assert.True(t, result)
	assert.Nil(t, err)
}

func TestMockIsCalledWith42(t *testing.T) {
	stub := new(MyTestDoubleObject)
	stub.On("DoSomething", 42).Return(false, nil)

	UnderTest(stub, 42)

	stub.AssertExpectations(t)
}

func TestMockIsFailingWhenNotCalledWith42(t *testing.T) {
	stub := new(MyTestDoubleObject)
	stub.On("DoSomething", 42).Return(false, nil)

	UnderTest(stub, 13)

	stub.AssertExpectations(t)
}
