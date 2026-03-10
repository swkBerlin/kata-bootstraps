#ifndef KATA_INCLUDED
#define KATA_INCLUDED

class Logger;

class Kata
{
public:
    Kata();
    explicit Kata(Logger &);
    int answer();
private:
    Logger & logger;
};

#endif