#include <iostream>
#include <iomanip>
#include <vector>

using namespace std;

int main(){

    vector<int> lista(10);
    int num = 0;
    
    for (int i = 0; i < lista.size(); i++){

        cout << "Entre com o número " << i + 1 << "° na lista: ";
        cin >> lista[i];

    }
    

    for (int i = 0; i < lista.size(); i++){
    
        cout << lista[i] << ", ";
    
    }

    cout << "\nDigite um número: ";
    
    cin >> num;
    int contador = 0;
    int ocorrencias = 0;
    for (int i = 0; i < lista.size(); i++){

        if (lista[i] == num && contador <= 9){ //ok
        
            contador++;
            ocorrencias++;
            cout <<"O número se encontra na posição: " << i+1 << " da lista" << endl;
        
            if (contador > 9){
            
                cout << "O número de ocorrências: " << ocorrencias << endl;

            }
            
        
        }else if (lista[i]!= num){
        
            contador++;

            if (contador > 9){
            
                cout << "O número de ocorrências: " << ocorrencias << endl;

            }
        }
        

    }

}