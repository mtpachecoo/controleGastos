# ControleGastos

## Descrição do problema real que resolve
O projeto resolve o problema de controle de gastos pessoais, permitindo que usuários registrem e acompanhem suas despesas diárias de forma simples e organizada.

## Proposta da solução
Uma aplicação de console em C# que gerencia uma lista de gastos, permitindo adicionar despesas, visualizar a lista e calcular o total gasto.

## Público-alvo
Indivíduos que desejam controlar seus gastos pessoais de maneira básica e eficiente.

## Funcionalidades principais
- Adicionar gastos com descrição e valor
- Listar todos os gastos registrados
- Calcular o total dos gastos
- Validação de valores (não permite valores negativos ou zero)

## Tecnologias utilizadas
- .NET 10
- C#
- xUnit para testes

## Instruções de instalação
1. Clone o repositório: `git clone https://github.com/mtpachecoo/controleGastos.git`
2. Navegue para a pasta do projeto: `cd controleGastos`
3. Restaure as dependências: `dotnet restore`

## Instruções de execução
Execute o projeto principal: `dotnet run --project ControleGastos/ControleGastos/ControleGastos.csproj`

## Como rodar os testes
Execute os testes: `dotnet test ControleGastos/ControleGastos.Tests/ControleGastos.Tests.csproj`

## Como rodar o lint
Para formatação de código: `dotnet format ControleGastos/ControleGastos/ControleGastos.csproj`

## Versão atual
1.0.0

## Nome do autor
mtpachecoo

## Link do repositório público
https://github.com/mtpachecoo/controleGastos