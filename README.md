# AutoRepairShop

![Licence](https://img.shields.io/github/license/Ileriayo/markdown-badges?style=for-the-badge)
![Postgres](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Blazor](https://img.shields.io/badge/blazor-%235C2D91.svg?style=for-the-badge&logo=blazor&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)


Sistema de gerenciamento de oficinas para pequenas e médias oficinas. Capaz de facilitar desde as ordem de serviços até o gerenciamento de estoque.

Projeto feito para fins de estudo de algumas tecnologias utilizadas no mercado.

Foi feito utilizando Dotnet 8, com o Entity Framework e utilizando o framework Blazor para criação das interfaces 
do usuário e pela sua facilidade em juntar o HTML com o C# e com todas as operações de backend e registro de dados 
feito em arquivos de serviço, deixando assim o frontend somente com responsabilidade de exibir e validações básicas.
Foi utilizado também o PostgreSql para banco de dados e utilizando o Identity para controle de usuários e autorização.

## Pré-requisitos

  - Ter o .Net 8 instalado na máquina
  - Ter o PostgreSql na versão 12 ou maior instalado

## Instalação e execução

  - Clonar o repositório para sua máquina
  - Abrir um console ou terminal na pasta em que o arquivo .csproj está salvo
  - Caso não tenha instalar o Entity Framework
  - Executar o comando para rodar as migrations do PostgreSql e criar o banco
  - Executar o comando de build e de run para inicializar a aplicação

## Tecnologias utilizadas

  - .Net 8
  - Blazor
  - AspnetCore Identity
  - PostgreSql
  - Html, css e Bootstrap 5

## Funcionalidades

  - Clientes: cadastro de clientes, listagem, edição e exclusão de clientes

  - Veículos: cadastro de veículos, listagem, edição e exclusão de veículos

  - Produtos: Cadastro, edição, exclusão e listagem de Produtos.

  - Ordem de serviço: Cadastro, edição, exclusão e listagem de ordem de serviço.

  - Usuários: Cadastro, edição, exclusão e listagem de usuários.

  - Papel: Cadastro, edição, exclusão e listagem de papel.

  - Cada usuário tem telas próprias para o papel que ele tem.

# Licença

  MIT
