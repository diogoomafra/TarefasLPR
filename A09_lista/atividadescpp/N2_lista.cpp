#include <iostream>
#include <vector>
#include <algorithm>
#include <ctime>
#include <cstdlib>
#include <unordered_map>
using namespace std;

int main() {
    srand(time(0)); // inicializa gerador de aleatórios

    vector<int> numeros;

    // 1) Gerar 100 números aleatórios entre 0 e 99
    for (int i = 0; i < 100; i++) {
        numeros.push_back(rand() % 100);
    }

    // 2) Ordenar em ordem crescente
    sort(numeros.begin(), numeros.end());

    cout << "Lista ordenada:" << endl;
    for (int n : numeros) {
        cout << n << " ";
    }
    cout << endl << endl;

    // 3) Remover números pares
    numeros.erase(remove_if(numeros.begin(), numeros.end(),
                            [](int x) { return x % 2 == 0; }),
                  numeros.end());

    cout << "Lista sem pares:" << endl;
    for (int n : numeros) {
        cout << n << " ";
    }
    cout << endl << endl;

    // 4) Verificar números repetidos
    unordered_map<int, int> contagem;
    for (int n : numeros) {
        contagem[n]++;
    }

    cout << "Numeros repetidos:" << endl;
    bool temRepetidos = false;
    for (auto &p : contagem) {
        if (p.second > 1) {
            cout << p.first << " aparece " << p.second << " vezes" << endl;
            temRepetidos = true;
        }
    }
    if (!temRepetidos) {
        cout << "Nao ha numeros repetidos." << endl;
    }

    return 0;
}
