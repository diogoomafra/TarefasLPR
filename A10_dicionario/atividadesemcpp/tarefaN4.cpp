#include <iostream>
#include <map>
using namespace std;

int main() {
    map<string, int> cidades = {
        {"São Paulo", 12000000},
        {"Rio de Janeiro", 6700000},
        {"Belo Horizonte", 2500000},
        {"Curitiba", 1900000},
        {"Florianópolis", 500000}
    };

    // Média da população
    double media = 0;
    for (auto &c : cidades) media += c.second;
    media /= cidades.size();
    cout << "População média: " << media << endl;

    // Cidades acima da média
    cout << "Cidades acima da média:" << endl;
    for (auto &c : cidades) {
        if (c.second > media)
            cout << c.first << " (" << c.second << ")" << endl;
    }

    // Inicializa mais/menos populosa com o primeiro elemento
    string maisPopCidade = cidades.begin()->first;
    int maisPopValor = cidades.begin()->second;
    string menosPopCidade = cidades.begin()->first;
    int menosPopValor = cidades.begin()->second;

    for (auto &c : cidades) {
        if (c.second > maisPopValor) {
            maisPopCidade = c.first;
            maisPopValor = c.second;
        }
        if (c.second < menosPopValor) {
            menosPopCidade = c.first;
            menosPopValor = c.second;
        }
    }

    cout << "Cidade mais populosa: " << maisPopCidade << " (" << maisPopValor << ")" << endl;
    cout << "Cidade menos populosa: " << menosPopCidade << " (" << menosPopValor << ")" << endl;

    // Remover cidades com população igual a Y
    int y;
    cout << "Digite um valor Y para remover: ";
    cin >> y;

    for (auto it = cidades.begin(); it != cidades.end(); ) {
        if (it->second == y)
            it = cidades.erase(it);
        else
            ++it;
    }

    // Dicionário atualizado
    cout << "Dicionário atualizado:" << endl;
    for (auto &c : cidades) {
        cout << c.first << " - " << c.second << endl;
    }

    return 0;
}
