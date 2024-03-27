# Monitoramento de Temperatura

O Monitoramento de Temperatura é uma aplicação de console em C# que utiliza a biblioteca LibreHardwareMonitor para obter e listar informações sobre a temperatura de componentes críticos do computador, como CPU, GPU, discos rígidos e placa-mãe. Este projeto visa fornecer uma visão clara e atualizada das condições térmicas dos componentes, permitindo aos usuários identificar potenciais problemas de superaquecimento ou verificar a eficácia do sistema de refrigeração.

## Funcionalidades

- Obtenção de leituras de temperatura de vários componentes do hardware, incluindo CPU, GPU, e discos rígidos.
- Exibição de informações detalhadas sobre a temperatura atual de cada componente monitorado.
- Formatação clara e legível das informações de temperatura para facilitar a análise e o monitoramento.

## Tecnologias Utilizadas

- **Linguagem de Programação**: C#
- **Plataforma**: .NET Core
- **Bibliotecas Externas**:
  - [LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor), uma biblioteca aberta para acessar informações detalhadas de hardware, incluindo sensores de temperatura.

## Como Usar

Para utilizar o Monitoramento de Temperatura, siga os passos abaixo:

1. **Pré-requisitos**: Garanta que você tenha o .NET SDK instalado no seu sistema. Esta aplicação requer acesso às informações de hardware, portanto, atualmente, é compatível apenas com sistemas operacionais Windows.

2. **Configuração do Projeto**:
   - Clone ou baixe o código-fonte do projeto para seu ambiente local.

3. **Compilação e Execução**:
   - Abra um terminal ou prompt de comando.
   - Navegue até o diretório do projeto.
   - Execute `dotnet build` para compilar o projeto.
   - Navegue até a pasta de saída da compilação, geralmente `bin/Debug/netX.Y`, onde `X.Y` é a versão do .NET utilizada.
   - Execute o arquivo `TemperatureInfo.exe`.

## Exemplo de Saída

```
Cpu: Intel Core i5-1035G1
        CPU Core #1: 52 °C
        CPU Core #2: 51 °C
        CPU Core #3: 49 °C
        CPU Core #4: 52 °C
        CPU Package: 52 °C
        CPU Core #1 Distance to TjMax: 48 °C
        CPU Core #2 Distance to TjMax: 49 °C
        CPU Core #3 Distance to TjMax: 51 °C
        CPU Core #4 Distance to TjMax: 48 °C
        Core Max: 52 °C
        Core Average: 51 °C

Gpu: NVIDIA GeForce GTX 4060 Ti
    GPU Core: 65°C

Storage: Samsung SSD 970 EVO 1TB
    Temperature: 40°C
```

**Nota**: As temperaturas exibidas e os componentes monitorados podem variar dependendo do hardware do sistema e da disponibilidade dos sensores.
