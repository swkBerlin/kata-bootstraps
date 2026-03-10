#ifndef MOCK_LOGGER_INCLUDED
#define MOCK_LOGGER_INCLUDED

#include "logger.hpp"
#include <gmock/gmock.h>

class MockLogger : public Logger
{
public:
    MOCK_METHOD1(log, void(const std::string&));
};

#endif
