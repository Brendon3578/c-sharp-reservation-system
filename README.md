# Reservation System

Esta aplicação desenvolvidda em C# .NET foi feita para estudar o tratamento de exceções em um sistema de reservas.

## Descrição

O sistema permite criar uma reserva, especificando um número de quarto, data de check-in e de check-out. Também é possível atualizar as datas da reserva depois. O código trata com diferentes tipos de exceções para garantir que as operações sejam realizadas corretamente:

- **DomainException**: Lançada quando as regras de negócio não são atendidas, como uma data de check-out anterior à data de check-in.
- **FormatException**: Captura erros de formatação, como uma data inserida em um formato incorreto.
- **Exception**: Captura erros inesperados.

## Funcionalidades

- Criação de reservas com validação de datas.
- Atualização de datas de reservas com validações de negócio.
- Tratamento de exceções para garantir a integridade do sistema.

## Exemplo de Uso

Ao rodar a aplicação, o usuário deve inserir o número do quarto, as datas de check-in e check-out, e, em seguida, pode atualizar essas datas, observando as regras definidas.

## Exceções Tratadas

- `DomainException`: Verifica se a data de check-out é posterior à data de check-in e se as datas para atualização são futuras.
- `FormatException`: Garante que as datas sejam inseridas no formato correto.
- `Exception`: Captura quaisquer outros erros inesperados.

## Tecnologias

- **C#**
- **.NET 8.0**

---

<h3 align="center">
    Feito com ☕ por <a href="https://github.com/Brendon3578"> Brendon Gomes</a>
</h3>
