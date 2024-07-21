# Sistema Aprovação Digital

Bem-vindo ao Sistema de Aprovação Digital, desenvolvido em C# 8.0 utilizando a Clean Architecture. Este sistema foi projetado para gerenciar aprovações digitais de forma eficiente e segura. 

## Tecnologias Utilizadas

- Linguagem: C# 8.0
- Padrão de Arquitetura: Clean Architecture
- Frameworks: 
  - Entity Framework
  - AutoMapper
  - FluentValidation
  - Mediatr
- Banco de Dados: Postgres

## Configuração do Ambiente de Desenvolvimento

### Pré-requisitos

Certifique-se de ter as seguintes ferramentas instaladas em sua máquina:

- .NET Core SDK
- PostgreSQL
- Visual Studio ou Visual Studio Code

### Passos para Criação de um Novo CRUD

#### 1. Camada de Domain
- Crie/alterar a classe de domínio no diretório `entities`.

#### 2. Camada de Infrastructure

- **Persistence Configuration**
  - Crie uma classe de configuração informando as propriedades do banco de dados referente à classe de domínio já criada.
  - Crie a referência da classe de domínio dentro do arquivo `Persistence/Context/DbprojsemurContext.cs`.
    ```csharp
    public virtual DbSet<ClasseDominio> ClasseDominio { get; set; }
    ```
  - No console, entre na raiz do projeto de Infrastructure e execute os comandos:
    ```bash
    dotnet ef migrations add AddNomeTable
    dotnet ef database update
    ```
  - Crie o repositório:
    - Dentro da pasta `Persistence/Repositories`, crie a classe `ClasseDominioRepository.cs`.
    - Adicione a injeção dentro de `ServiceExtensions.cs`:
      ```csharp
      services.AddScoped<IClasseDominioRepository, ClasseDominioRepository>();
      ```

#### 3. Camada de Application

- Crie a interface de `ClasseDominioRepository.cs` dentro do diretório `Repositories`.
- Crie as regras de negócio dentro da pasta `Features`.
- Dentro da pasta `Features`, crie um diretório com o nome do domínio e um diretório para cada tipo de operação: `get`, `getall`, `create`, `update` e `delete`.
  - Nos diretórios de operação, crie os arquivos:
    - `CreateHandler.cs` -> Responsável por criar e aplicar as regras do domínio.
    - `CreateMapper.cs` -> Responsável por converter DTOs em classes de banco.
    - `CreateValidators.cs` -> Responsável por criar as regras de validação utilizadas no envio do JSON.

#### 4. Camada de Apresentation

- Responsável por receber via RESTFUL os dados das telas.
- Crie uma classe dentro do diretório `controllers/NomeDominioController.cs`.

### Testando a Aplicação

Agora, execute e teste a aplicação usando o Swagger ou Postman.

## Observações

- As classes de configuração e os DbSet do banco legado já foram todos criados, então, para criar um novo serviço, pode-se começar criando o repositório e continuar a partir da camada de aplicação.
- Na migração, alguns nomes vieram estranhos, então pode ser interessante já ir corrigindo na classe de domínio para não confundir.
- Sempre que adicionar ou remover algum campo do domínio, é necessário alterar também na configuração e gerar a migração (por enquanto, vamos evitar isso).

## Acesso ao Sistema

Você pode acessar o sistema de aprovação digital através do link abaixo:

[Link do Aprovação Digital](https://apl01-h.pmcg.ms.gov.br/projsemur/modulos/login/login.jsp)

### Credenciais de Acesso

| Usuário       | Perfil        | Login       | Senha    |
| ------------- | ------------- | ----------- | -------- |
| Supervisor    | Analista      | jaugusto    | 2391     |
| Clara Kohl    | Administrador | kohl        | 1310     |
| Debora Vilela | Analista      | 385489      | 123456   |
| Celso Fontes  | Profissional  | 50043897720 | 123456   |


