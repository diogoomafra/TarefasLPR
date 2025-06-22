#include <iostream>
using namespace std;

int main() {
    int A[3][3];
    int B[3][3];
    int C[3][3] = {0}; // Matriz resultante

    cout << "Insira os números da Matriz A 3x3: " << endl;
    for (int i = 0; i < 3; i++){
        for (int j = 0; j < 3; j++){
            cin >> A[i][j];
        }
    }

    cout << "Insira os números da Matriz B 3x3: " << endl;
    for (int i = 0; i < 3; i++){
        for (int j = 0; j < 3; j++){
            cin >> B[i][j];
        }
    }

    cout << "Calculando a multiplicação e criando uma nova matriz:" << endl;

    for (int i = 0; i < 3; i++){
        for (int j = 0; j < 3; j++){
            for (int k = 0; k < 3; k++){
                C[i][j] += A[i][k] * B[k][j];
            }
        }
    }

    cout << "Matriz resultante C:" << endl;
    for (int i = 0; i < 3; i++){
        for (int j = 0; j < 3; j++){
            cout << C[i][j] << endl;
        }

    }

    return 0;
}
