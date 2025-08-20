/*
Construa uma lista de X nomes aleatórios
A saída deve ser mostrada em uma ou
mais linhas. Cada linha tem uma lista de
nomes ordenados por tamanho,
começando com o menor. Em cada linha,
só pode ser mostrado um nome de
determinado tamanho, e os demais
nomes com o mesmo tamanho devem ser
apresentados nas linhas seguintes. Você
deve seguir a ordem de digitação.
*/
using System;
using System.Collections.Generic;
using System.Xml.XPath;

class N1_lista
{
    /*   public struct Listas() {

           List<string> x = new List<string> ();  


       };
       */
    static void Main()
    {
        List<string> x = new List<string> { "Diogo Mafra", "Juliana Aparecida", "Matheus Prado", "Eduardo Vasconcelos", "Thaiza Valentim", "Felipe Barroso", "Vinicius Amaral", "Pedro das Alamedas" };
        List<string> l1 = new List<string> { };
        for (int i = 0; i < x.Count; i++){
        
            string menornome = x[0];
            if (i < x.Count - 1 && x[i].Length < menornome.Length) {

                menornome = x[i];
                Console.Write(menornome);
                
            }
             



        }  
        /*

            Faço um for que vai adicionar a uma outra lista de acordo com a quantidade de caracter 



        */


    }
}

