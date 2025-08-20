#include <iostream>

using namespace std;
int main(){
    
    int valor1, valor2;

    cout << "Entre com o primeiro número e o segunro respectivamente: ";
    cin >> valor1 >> valor2;

    if (    valor1%valor2==0 || valor2%valor1==0    ){
        
        cout <<"São multiplos";

    } else{

        cout <<"Não são multiplos";
        
    }

}