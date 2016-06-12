project(kata)

cmake_minimum_required(VERSION 2.8)

enable_testing()

####################################################
# Set the C++ Standard to be used (Default to C++11)
####################################################
set(CXX_STANDARD 11)
set(CXX_STANDARD_REQUIRED OFF)

####################################################
# Set Compiler flags
####################################################
IF (CMAKE_CXX_COMPILER_ID MATCHES "GNU" OR CMAKE_CXX_COMPILER_ID MATCHES "Clang")
  SET(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -Wall")
ELSEIF (MSVC)
  SET(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /W4")
ENDIF()

include_directories("${CMAKE_SOURCE_DIR}/include")

####################################################
# Add Unit Tests file names (without .cpp extension)
####################################################
list(APPEND UNIT_TESTS
    hello_world
    game_of_life
)

####################################################
# Create executable for each test
####################################################
foreach(TEST ${UNIT_TESTS})
    add_executable(${TEST} "${CMAKE_SOURCE_DIR}/src/${TEST}.cpp")
    add_test(${TEST} ${TEST})
endforeach()
