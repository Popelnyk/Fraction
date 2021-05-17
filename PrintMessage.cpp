#include "PrintMessage.h"
#include <iostream>
#include <thread>
#include <chrono>
PrintMessage::PrintMessage(const std::string &message, int number, int pause)
{
    message_ = message;
    number_ = number;
    pause_ = pause;
}

void PrintMessage::print()
{
    std::mutex m;
    for(int i = 0; i < number_; i++)
    {
        if(numberPrinted == 0)
            break;
        m.lock();
        numberPrinted--;
        m.unlock();
        std::cout << message_ << '\n';
        std::this_thread::sleep_for(std::chrono::milliseconds(pause_));
    }
}

