#include "kata.hpp"
#include "disk_logger.hpp"

Kata::Kata()
    : logger(DiskLogger::getInstance())
{
}


Kata::Kata(Logger & logger_)
    : logger(logger_)
{
}

int Kata::answer()
{
    logger.log("Kata::answer()");
    return 6 * 9;
}