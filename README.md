⛽ App de Cálculo de Combustível

Este projeto é um aplicativo simples desenvolvido em .NET MAUI com C#, que ajuda o usuário a decidir se é mais vantajoso abastecer com Etanol ou Gasolina, com base no preço informado de cada combustível.

📱 Funcionalidades

✔️ Entrada do preço do Etanol
✔️ Entrada do preço da Gasolina
✔️ Cálculo baseado na fórmula:
    Se (etanol ≤ 70% do valor da gasolina) → Etanol compensa
    Senão → Gasolina compensa
✔️ Exibição de mensagem informando o combustível mais vantajoso
✔️ Tratamento de erros para entradas inválidas


🧠 Lógica do Cálculo

A recomendação de combustível segue a famosa regra:

Se (Preço do Etanol ÷ Preço da Gasolina) ≤ 0.7 
    → Abasteça com Etanol
Senão 
    → Abasteça com Gasolina


Isso ocorre porque o etanol rende cerca de 70% da gasolina. Logo, só vale a pena usá-lo se custar até 70% do valor da gasolina.

✅ Requisitos

.NET 6 ou superior

.NET MAUI instalado

Visual Studio 2022 (ou superior) com workload de Desenvolvimento .NET para dispositivos móveis (MAUI)

▶️ Como Executar

Clone o repositório:

git clone https://github.com/seu-repositorio/combustivel-app.git


Abra o projeto no Visual Studio 2022.

Selecione o dispositivo de execução:

Emulador Android

Dispositivo físico conectado

Windows/Mac (dependendo da plataforma)

Clique em "Executar" (botão Play).

📌 Melhorias Futuras (Sugestões)

✅ Design mais moderno com MAUI Controls

✅ Exibir imagens para Etanol e Gasolina

✅ Histórico de cálculos

✅ Suporte a múltiplas moedas (R$, USD, etc.)

✅ Validação mais avançada de campos

📄 Licença

Este projeto é de uso livre para fins de estudo. Fique à vontade para modificar, melhorar e compartilhar!
