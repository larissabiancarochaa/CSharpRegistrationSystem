# CSharpRegistrationSystem

**CSharpRegistrationSystem** é um aplicativo C# para registro de usuários com operações CRUD. Utiliza SQLite para armazenamento de dados e autenticação com hash de senhas. Ideal para aprendizado e implementação de gerenciamento de usuários e operações de banco de dados.

## Funcionalidades

- Registro de novos usuários com nome de usuário e senha
- Armazenamento seguro de senhas usando hash SHA-256
- Validação de entrada para campos obrigatórios e correspondência de senhas
- Mensagens de erro e sucesso para feedback do usuário

## Requisitos

- .NET Framework 4.5 ou superior
- SQLite
- Visual Studio ou outra IDE C# compatível

## Instalação

1. **Clone o repositório:**

    ```bash
    git clone https://github.com/larissabiancarochaa/CSharpRegistrationSystem.git
    ```

2. **Abra o projeto no Visual Studio.**

3. **Restaure os pacotes NuGet necessários.**

4. **Configure o caminho do banco de dados no arquivo `DatabaseHelper.cs`:**

    ```csharp
    connectionString = "Data Source=C:\\Databases\\CrudCSharp.db;Version=3;";
    ```

5. **Compile e execute o projeto.**

## Uso

1. **Execute o aplicativo e abra a janela de registro.**

2. **Preencha os campos de nome de usuário e senha.**

3. **Clique em "Register" para adicionar um novo usuário ao banco de dados.**

4. **Se ocorrer algum erro, uma mensagem será exibida. Caso contrário, o usuário será registrado com sucesso.**

## Contribuições

Contribuições são bem-vindas! Para contribuir:

1. **Faça um fork deste repositório.**
2. **Crie uma branch para sua modificação:**

    ```bash
    git checkout -b minha-modificacao
    ```

3. **Faça suas alterações e commite-as:**

    ```bash
    git commit -am 'Adiciona nova funcionalidade'
    ```

4. **Push para a branch:**

    ```bash
    git push origin minha-modificacao
    ```

5. **Abra um Pull Request.**

## Licença

Este projeto é licenciado sob a [Licença MIT](LICENSE).

## Contato

Para mais informações, entre em contato com [Larissa Bianca Rocha](mailto:b35.larissa@gmail.com).