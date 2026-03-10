#include "disk_logger.hpp"
#include <fstream>

DiskLogger & DiskLogger::getInstance()
{
    static DiskLogger instance;
    return instance;
}

void DiskLogger::log(const std::string & info)
{
    std::ofstream ofs("singleton-logger.txt", std::ios_base::app);
    ofs << info << std::endl;
}

DiskLogger::DiskLogger()
{
}