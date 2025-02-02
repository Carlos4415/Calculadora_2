// Este programa implementa uma calculadora que realiza operações matemáticas básicas e avançadas.  
// Funcionalidades disponíveis:
// - Operações básicas: soma (+), subtração (-), multiplicação (*) e divisão (/);
// - Operações avançadas: cálculo de potência (^) e raiz quadrada (r).  
// Funcionamento:
// - O usuário deve fornecer dois números e um símbolo que represente a operação desejada.
//   Exemplo: 5, 3, '+' para somar 5 e 3.  
// - Para operações que utilizam apenas um número (como raiz quadrada), o programa considera apenas o primeiro número fornecido.
// O programa verifica entradas inválidas e exibe mensagens de erro para evitar cálculos incorretos.
Console.WriteLine($"Somar: {Calculadora.Calcular(10, 5, '+')}");
Console.WriteLine($"\nSubtrair: {Calculadora.Calcular(10, 5, '-')}");
Console.WriteLine($"\nMultiplicar: {Calculadora.Calcular(10, 5, '*')}");
Console.WriteLine($"\nDividir: {Calculadora.Calcular(10, 5, '/')}");
Console.WriteLine(Calculadora.Calcular(10, 0, '/'));
Console.WriteLine($"\nPotência: {Calculadora.Calcular(2, 3, '^')}");
Console.WriteLine($"\nRaiz quadrada: {Calculadora.Calcular(16, 0, 'r')}");
Console.WriteLine($"\nDefault: {Calculadora.Calcular(0, 0, 'x')}");