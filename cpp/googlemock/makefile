CXX = clang++

CXXFLAGS += -I.
CXXFLAGS += -std=c++17
CXXFLAGS += -Wall
CXXFLAGS += -Wextra
CXXFLAGS += -Wshadow
CXXFLAGS += -Wfloat-equal
CXXFLAGS += -O0
CXXFLAGS += -pthread

GTEST_LIBS = -lgtest -lgmock -lgmock_main

HPP_FILES = $(wildcard *.hpp)
CPP_FILES = $(wildcard *.cpp)
OBJ_FILES = $(CPP_FILES:.cpp=.o)

.PHONY: test
test: kata_tests
	./kata_tests

kata_tests: $(OBJ_FILES)
	$(CXX) $(CXXFLAGS) $^ $(GTEST_LIBS) -o $@

%.o: %.cpp $(HPP_FILES) makefile
	$(CXX) $(CXXFLAGS) -c $< -o $@
