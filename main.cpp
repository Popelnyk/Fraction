#include <iostream>
#include "PrintMessage.h"
#include <string>
#include <thread>
int PrintMessage::numberPrinted;
void check_for_positive(int& a)
{
    while(true)
    {
        std::cin >> a;
        if(a >= 0)
            break;
        std::cout << "You have entered negative number. Try again";
    }
}
void enter(std::string& s, int& n, int& p)
{
    std::cin.ignore();
    std::cout << "Enter the message\n";
    getline(std::cin, s);
    std::cout << "Enter the number of repeats\n";
    check_for_positive(n);
    std::cout << "Enter the duration of pause\n";
    check_for_positive(p);
}
int main()
{
    std::cout << "Enter the number of repeats for all threads\n";
    std::cin >> PrintMessage::numberPrinted;
    std::string s;
    int n = 0;
    int p = 0;
    std::cout << "Enter the information for first thread\n";
    enter(s, n, p);
    PrintMessage* a = new PrintMessage(s, n, p);
    std::cout << "Enter the information for second thread\n";
    enter(s, n, p);
    PrintMessage* b = new PrintMessage(s, n, p);
    std::cout << "Enter the information for third thread\n";
    enter(s, n, p);
    PrintMessage* c = new PrintMessage(s, n, p);
    std::thread t1(&PrintMessage::print, *a);
    std::thread t2(&PrintMessage::print, *b);
    std::thread t3(&PrintMessage::print, *c);
    t1.join();
    t2.join();
    t3.join();
    return 0;
}
