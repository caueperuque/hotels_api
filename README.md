# HotelsAPI - Sistema de Reservas de Hotéis 🏨

## Seja bem-vindo(a) ao HotelsAPI!

Este é um sistema incrível para gerenciar reservas de hotéis de várias redes! Com a HotelsAPI, você pode controlar cidades, hotéis e quartos disponíveis para reservas. 🌟

## Tecnologias utilizadas 💻

- **Azure SQL Edge**;
- **C#**;
- **ASP.NET Core**;
- **Entity Framework Core**;
- **Docker**;
- **Swagger/OpenAPI**;


## Instalação e Configuração

### Vamos Começar! 🚀

Para utilizar esta aplicação, siga estes passos:

1. **Clone o repositório HotelsAPI**.
2. **Inicie o serviço do banco de dados** utilizando o Docker Compose:
    ```
    docker-compose up -d --build
    ```
3. **Conecte-se ao banco de dados** com as seguintes credenciais:
    - Server: localhost
    - User: sa
    - Password: SenhaSuperSecreta12!
    - Database: HotelsDB
    - Trust server certificate: true

4. **Verifique a connectionString** e ajuste se necessário:
    ```
    var connectionString = "Server=localhost;Database=HotelsDBl;User=SA;Password=SenhaSuperSecreta12!;TrustServerCertificate=True";
    ```

5. **Atualize o banco de dados** com o comando:
    ```
    dotnet ef database update
    ```

6. **Execute o projeto localmente e divirta-se explorando as funcionalidades!** 🎉


## Funcionalidades

### Explore os Endpoints 🛠️

#### GET /city
- Listar todas as cidades disponíveis.

#### POST /city
- Adicionar uma nova cidade.

#### GET /hotel
- Listar todos os hotéis.

#### POST /hotel
- Adicionar um novo hotel.

#### GET /room/:hotelId
- Listar todos os quartos de um determinado hotel.

#### POST /room
- Adicionar um novo quarto a um hotel.

#### DELETE /room/:roomId
- Deletar um quarto específico.

## Arquitetura e Implementação Técnica 🏗️

### Como foi Construído?

- **Estrutura do Projeto:** As models, controllers e repositórios estão organizados dentro dos diretórios específicos, utilizando Repository Pattern para separação de responsabilidades e abstração do acesso aos dados.
- **Banco de Dados:** Utiliza uma arquitetura semelhante ao SQL Server, disponibilizado pelo Docker Compose.


## Autor
Este projeto foi construído com muito 💙, por mim.
