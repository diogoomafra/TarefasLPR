#include <iostream>

using namespace std;
int main(){

    int qtd, cont = 0, num, soma = 0, i = 0;
    double media;

    cout << "Informe a quantidade de números: ";
    cin >> qtd;

    while (cont < qtd){

        cout << "informe o número: " ;
        cin >> num;

        if ( num % 2 == 0){

            soma += num;
            i ++;
        
        } 

        cont++;

    }

        
        media = (double)soma / i;
        cout << media << endl;

}

