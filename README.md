---

# TemperatureInfo

Este projeto é um exemplo de aplicativo de console em C# que utiliza a biblioteca LibreHardwareMonitor para monitorar os componentes de hardware de um computador e exibir informações sobre suas temperaturas.

## Requisitos

- Visual Studio (ou outro ambiente de desenvolvimento C#)
- Biblioteca LibreHardwareMonitor (incluída no projeto)

## Como usar

1. Clone ou faça o download do repositório para o seu computador.
2. Abra o projeto no Visual Studio (ou outro ambiente de desenvolvimento C#) e compile-o.
3. **Importante**: Execute o aplicativo gerado como administrador. Para fazer isso, clique com o botão direito no arquivo executável (`.exe`) e selecione "Executar como administrador" no menu de contexto.
4. O aplicativo irá ler e exibir informações sobre as temperaturas dos componentes de hardware do seu computador, incluindo CPU, GPU, memória, placa-mãe, controladores e armazenamento.

## Arquivos do projeto

- **Leitura.cs**: Contém a classe `Leitura`, que implementa a funcionalidade de monitoramento de hardware.
- **LibreHardwareMonitor**: Pasta que contém a biblioteca `LibreHardwareMonitor`, responsável por acessar as informações de hardware do sistema.
- **TemperatureInfo.csproj**: Arquivo do projeto C#.
---

