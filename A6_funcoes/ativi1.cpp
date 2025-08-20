#include <iostream>
#include <string>

using namespace std; 

int reverso(int x){
    
 /*
 

 */
    int valoreverso = 0;

    while (x > 0){

        int digito = x %10;
        cout << "\nvalor do digito aqui: "<< digito;
        valoreverso = valoreverso * 10 + digito;
        cout << "\nValor do reverso aqui:" << valoreverso;
        x /= 10;
        cout << "\nvalor de x aqui: " << x;

    }       

    return valoreverso;
}

int main (){

    int valor;

    cout << "Entre com o valor de x: ";
    cin >> (valor);

    valor = reverso(valor);

    cout << valor ;

}