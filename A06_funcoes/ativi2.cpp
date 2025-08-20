#include <iostream>
#include <thread>   
#include <chrono>   

using namespace std;

void delay(int ms) {
    this_thread::sleep_for(chrono::milliseconds(ms));
}





void media(int quant){

    int cont = 0, num, soma = 0, i = 0;
    double media;
    
    while (cont < quant){

        cout << "Informe o número: " ;
        cin >> num;
        if ( num % 2 == 0){

            soma += num;
            i ++;
        
        } 

        cont++;

    }

        
   
        media = (double)soma / i;
        cout << "\033[1;32mA média destes valores é: " << media << "\033[0m" << endl;
    

}














int somador (){

    int soma, i, limite;
    
        cout << "\033[1;34mDigite um número que deseja saber a soma dos números ímpares, a partir deste, que são múltiplos de três: \033[0m";
        cin >> i;
    
        cout << "\033[1;34mAgora digite um limite, por exemplo de 50 (valor que inseriu) até 500 (valor que insirá de limite):\033[0m ";
        cin >> limite;

            for (; i <= limite; i++){

                if (i%3 == 0 && i%2 != 0){
        
                soma += i;
               

            }
        }
        return soma;
}










int quadrado(int& valor){

    int quadrado = valor * valor;
    int somaDigitos = 0;

    // Usando um loop while para iterar sobre os dígitos do quadrado do número
    while (quadrado > 0) {
        somaDigitos += quadrado % 10; // Adicionando o último dígito à soma
        quadrado /= 10; // Removendo o último dígito
    }
    return somaDigitos;
    


}









int main(){
    int escolha = 0, qtd = 0, somatorio = 0, numero = 0, somadig = 0;
    string vermelho = "\033[1;31m";
    string reset = "\033[0m";
    string coracao[] = {
        "   ***     ***   ",
        " ******* ******* ",
        " ***************",
        "  ************* ",
        "   ***********  ",
        "    *********   ",
        "     *******    ",
        "      *****     ",
        "       ***      ",
        "        *       "
    };
    do {
        cout << "\033[1;31m=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+";
       
        cout << "\nEscolha, digitando o valor da opção, um calculo que deseja realizar:\n1 - Média\n2 - Soma\n3 - Quadrado\n4 - Sair "<< endl;
        
        cout << "=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+\nEscolha:\033[0m ";

        cin >> escolha;
        cout << endl;

        switch (escolha){
        
            case 1: 
                
                cout << "\033[1;34mSerá possível fazer a média aritimética dos valores que inserir a partir da quantidade de valores.\033[0m\n";
                cout << "Informe a quantidade de números: ";
                cin >> qtd;
                
                media(qtd);
                break;

            case 2: 
                
                somatorio = somador();
                cout << "\033[1;32mA soma é: " << somatorio  << "\033[0m" << endl;
                break;
 
            case 3: 
                
            cout << "\033[1;34mDigite um número que desja saber a soma dos digitos do quadrado deste: \033[0m";
            cin >> numero;

            somadig = quadrado(numero);
            cout << "\033[1;32mA soma dos dígitos do quadrado de " << numero << " é: " << somadig << "\033[0m" << endl;

            break;

                case 4:

                cout << "\033[1;31m Tchao, Andery  (: \033[0m" << endl;
                for (int i = 0; i < 10; i++) {
                    cout << vermelho << coracao[i] << reset << endl; 
                    delay(200); //achei legal que é uma função que cria
                }

                
                break;


                default:

                cout << "\033[1;31mOpção inválida, tente de novo."<< endl;
}

    }while (escolha != 4);
return 0;
}