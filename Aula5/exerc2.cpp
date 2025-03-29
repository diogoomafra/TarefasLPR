#include <iostream>
#include <random>

using namespace std;

int main(){

    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1,100);

    int valorInteiro = distribuicao(numAleatorio);
    
    int num, tentativas; 

    do{

        cout <<"Tente adivinhar o valor sorteado: ";
        cin >> num;
        tentativas++;
        if (num>valorInteiro){
            
            cout<< "Chute mais baixo"<< endl;
        
        } else if(num<valorInteiro){
            
            cout<<"Chute mais alto"<< endl;

        }

    }
    while(num != valorInteiro);

    

    if (num == valorInteiro) {

        cout << "Acertou em "<< tentativas << " tentativas!" << endl;
        
    }
}