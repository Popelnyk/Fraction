#ifndef MOTHER_FATHER_PRINTMESSAGE_H
#define MOTHER_FATHER_PRINTMESSAGE_H
#include <string>
class PrintMessage
{
private:
    std::string message_;
    int number_;
    int pause_;
public:
    static int numberPrinted;
    PrintMessage(const std::string& message, int number, int pause);
    void print();
};
#endif
