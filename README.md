# ​​ Tarefas LPR — Linguagem de Programação

Repositório com as tarefas da disciplina de **Linguagem de Programação**, ministrada pelo professor José Andery. 
Aqui detalhamos exercícios feitos em C# e C++, por **Diogo Mafra**.

---

##  Sumário

- [Sobre](#-sobre)  
- [Tarefas por Aula](#-tarefas-por-aula)  
- [Linguagens Utilizadas](#-linguagens-utilizadas)  
- [Como Compilar e Executar](#-como-compilar-e-executar)  
- [GIFs Demonstrativos](#-gifs-demonstrativos)  
- [Licença](#-licença)  

---

##  Sobre

Este repositório organiza, por aula, exercícios de lógica e programação em **C#** e **C++**, cobrindo tópicos como:
- Estruturas de repetição, condicionais e funções  
- Listas, vetores, dicionários (`map`, `list`, `Dictionary`)  
- Sort, manipulação de arquivos (quando aplicável)  

---

##  Tarefas por Aula

| Aula | Conteúdo | Arquivos Principais |
|------|----------|---------------------|
| Aula 04 | Condicionais | `A04_condicionais/` |
| Aula 05 | Laços de Repetição | `A05_repeticao/` |
| Aula 06 | Funções | `A06_funcoes/` |
| Aula 07 | Variáveis Compostas | `A07_variaveiscompostas/` |
| Aula 08 | Structs | `A08_structs/` |
| Aula 09 | Listas (C#, C++) | `A09_lista/` |
| Aula 10 | Dicionários & Maps | `A10_dicionario/` |

---

##  Linguagens Utilizadas

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)  
![C++](https://img.shields.io/badge/C++-00599C?style=for-the-badge&logo=cplusplus&logoColor=white)  
- **C#** — ~75% dos exercícios, focando em `List<T>`, `Dictionary`, manipulação de dados e LINQ (quando usado).  
- **C++** — ~25% dos exercícios, trabalhando com `vector`, `list`, `map`, `sort`, e outras estruturas STL.

---

##  Como Compilar e Executar

### C# (.NET CLI)

```bash
cd A09_lista
dotnet new console -n Aula09
mv *.cs Aula09/Program.cs
cd Aula09
dotnet run
