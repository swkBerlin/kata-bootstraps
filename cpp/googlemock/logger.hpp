#ifndef LOGGER_INCLUDED
#define LOGGER_INCLUDED

#include <string>

class Logger // interface
{
public:
    virtual void log(const std::string &) = 0;
};

#endif