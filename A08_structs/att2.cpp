#include <iostream>
#include <vector>
#include <iomanip>
#include<string>
using namespace std;

struct livro{

    string Titulo;
    string Autor;
    int AnoPublicado;
    int NumeroPaginas;
    double Preco;


};
vector<livro> livros(3);

void cadastrolivros(){

    for (int i = 0; i < 3; i++){
        if(i > 0){
            cin.ignore();
        }
        

        cout << "Insira o titulo do " << i+1 <<  "° livro: ";
        getline(cin, livros[i].Titulo); 
        
        /* (GETLINE): cin está mandado como argumento indicando que usara o tipo de dado de entrada padrão que estamos acostumados, 
        mas poderia ser de um arquivo por exemplo, e o segundo argumento é o texto a ser indicado. Esta função getline é usada para enviar uma frase inteira ao invés de apenas
        a parte da string até o primeiro espaço */

        cout << "Insira o autor do livro " << livros[i].Titulo << ": ";
        getline(cin, livros[i].Autor);
        
        cout << "Insira o ano publicado do livro " << livros[i].Titulo << ": ";
        cin >> livros[i].AnoPublicado;

        cout << "Insira o numero de paginas do livro " << livros[i].Titulo << ": ";
        cin >> livros[i].NumeroPaginas;

        cout << "E por ultimo o preço do livro " << livros[i].Titulo << ": ";
        cin >> livros[i].Preco; 
        cout << "\n===========================================================" << endl;
    }

}

double precototal(){

    double valor = 0;
    
    for(int i = 0; i < 3; i++){

        valor += livros[i].Preco;
        
    }
    
    return valor;

}
int mediapaginas(){
    int soma;
    for (int i = 0; i < 3; i++){

        soma += livros[i].NumeroPaginas;

    }
    
    return soma / 3;

}



int main(){

    //cadastre os livros
    cadastrolivros();

    //mostrar total
    double total = precototal();
    cout << "O preço total dos livros é de: " << fixed << setprecision(2) << total << "R$." << endl;

    //mostrar media de paginas cadastradas 
    int media = mediapaginas();
    cout << "A média de páginas dos livros é: " << media <<" páginas." << endl;


}