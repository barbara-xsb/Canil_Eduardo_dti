# Canil_Eduardo_dti

# Premissas 

As premissas consideradas para o funcionamento do sistema foram os nomes dos Pets Shops, as distâncias de cada um até o canil, a tabela de valores dos banhos de cachorros grandes e pequenos e a diferença dos preços nos finais de semana. 

 
# Descrição do projeto 

O código inicia com uma classe ‘PetShop’ que recebe as propriedades dos Pets shops: Nome, distância, valor do banho de cachorro pequeno, valor do banho de cachorro grande, valor do banho de cachorro pequeno nos finais de semana e o valor do banho de cachorros grandes no final de semana. 

A classe ‘Valores’ recebe as propriedades ‘ListaValor’ para armazenar os dados individuais de cada Pet Shop, e uma string ‘PetShopEscolhido’ que será usado para receber o nome do Pet Shop que for escolhido com o menor valor ou menor distância.  

Esses valores citados são os cálculos dos valores de cada Pet Shop, sendo eles ‘valor1’ para Meu Canino Feliz, ‘valor2’ para Vai Rex e ‘valor3’ para ChowChawgas. 

Dentro da classe ‘Valores’ existe diversas funções. A função ‘ValidarValoresIguais’ irá comparar se existem dois ou três valores com resultados iguais. A função ‘BuscarMenor’ é responsável por primeiramente conferir se os valores são iguais ou não, caso sejam, irá fazer a comparação de quilometragem. No fim, retorna o menor valor. A função ‘CalcularValor’ é responsável por conferir se a data indicada é ou não final de semana, para fazer o cálculo dos valores indicados, retornando o menor entre eles chamando a função ‘BuscarMenor’. 

A função ‘ImputDados’ recebe os valores de entrada do usuário, e usa o método Split para reconhecer a separação de caracteres. 

Por fim, o Main utiliza de uma lista ‘resultados’ para armazenamento das saídas e uma lista ‘dados’ para as entradas. O while irá servir como loop para que o usuário possa inserir dados quantas vezes quiser, até digitar 0. O for exibe as saídas finais do programa. 
