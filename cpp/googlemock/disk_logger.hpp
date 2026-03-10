#ifndef DISK_LOGGER_INCLUDED
#define DISK_LOGGER_INCLUDED

#include "logger.hpp"

class DiskLogger : public Logger
{
public:
    static DiskLogger & getInstance();
    virtual void log(const std::string &);
private:
    DiskLogger();
};

#endif