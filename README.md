# Gerenciamento de Livros

Este projeto é uma aplicação de gerenciamento de livros com backend em .NET Core e frontend em Angular. Abaixo estão as instruções para executar o projeto, bem como uma visão geral das tecnologias utilizadas.

## Tecnologias

### Backend
- **Tecnologia:** .NET Core
- **Framework:** ASP.NET Core Web API
- **Banco de Dados:** InMemory Database (para fins de desenvolvimento)
- **Bibliotecas:** AutoMapper

### Frontend
- **Tecnologia:** Angular
- **Framework:** Angular Material
- **Bibliotecas:** RxJS

## Executando o Projeto

### Backend

1. **Pré-requisitos**
   - .NET SDK 6.0 ou superior instalado.

2. **Passos para executar o backend**
   1. Navegue até a pasta do projeto backend:
      ```bash
      cd path/to/backend
      ```
   2. Restaure as dependências do projeto:
      ```bash
      dotnet restore
      ```
   3. Compile e execute o projeto:
      ```bash
      dotnet run
      ```
   4. O backend estará disponível em `http://localhost:5297`. Certifique-se de que esta URL está configurada no serviço Angular.

### Frontend

1. **Pré-requisitos**
   - Node.js e npm (ou yarn) instalados.
   - Angular CLI instalado.

2. **Passos para executar o frontend**
   1. Navegue até a pasta do projeto frontend:
      ```bash
      cd path/to/frontend
      ```
   2. Instale as dependências do projeto:
      ```bash
      npm install
      ```
   3. Inicie o servidor de desenvolvimento Angular:
      ```bash
      ng serve
      ```
   4. O frontend estará disponível em `http://localhost:4200`. Certifique-se de que esta URL está configurada para consumir o backend.

## Estrutura do Projeto

### Backend

- **Controllers:** Definem os endpoints da API.
- **Models:** Representam as entidades de dados.
- **DTOs:** Data Transfer Objects utilizados para comunicação entre frontend e backend.
- **Repositories:** Encapsulam a lógica de acesso ao banco de dados.
- **Mapping:** Configura o mapeamento entre DTOs e entidades.

### Frontend

- **Components:** Contêm a lógica e o template para a interface do usuário.
- **Services:** Fornecem métodos para interagir com a API backend.
- **Models:** Definem a estrutura dos dados utilizados na aplicação.
- **Routing:** Configura as rotas da aplicação Angular.

## Contribuindo

Sinta-se à vontade para contribuir para o projeto. Para isso, siga as práticas padrão de pull request e code review.

## Licença

Este projeto está licenciado sob a MIT License. Consulte o arquivo [LICENSE](LICENSE) para obter mais informações.

