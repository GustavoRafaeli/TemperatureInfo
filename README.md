# TemperatureInfo

Este projeto é um exemplo de aplicativo de console em C# que utiliza a biblioteca LibreHardwareMonitor para monitorar os componentes de hardware de um computador e exibir informações sobre suas temperaturas.

## Requisitos

- Visual Studio (ou outro ambiente de desenvolvimento C#)
- Biblioteca LibreHardwareMonitor (incluída no projeto)

## Como usar

1. **Baixar ou Clonar o Projeto**:
   - Clone ou faça o download do repositório para o seu computador.
2. **Compilação do Projeto**:
   - Abra o terminal ou prompt de comando.
   - Navegue até a pasta do projeto.
   - Execute o comando `dotnet build` para compilar o projeto.
3. **Execução**:
   - Após a compilação, navegue até a pasta `bin/Debug/netX.Y` (onde `X.Y` é a versão do .NET utilizada).
   - Execute como ADMINISTRADOR o arquivo `TemperatureInfo.ConsoleApp.exe` para iniciar a aplicação.
4. **Resultado**:
   - O aplicativo irá ler e exibir informações sobre as temperaturas dos componentes de hardware do seu computador, incluindo CPU, GPU, memória, placa-mãe, controladores e armazenamento.

## Arquivos do projeto

- **Leitura.cs**: Contém a classe `Leitura`, que implementa a funcionalidade de monitoramento de hardware.
- **LibreHardwareMonitor**: Pasta que contém a biblioteca `LibreHardwareMonitor`, responsável por acessar as informações de hardware do sistema.
- **TemperatureInfo.csproj**: Arquivo do projeto C#.
