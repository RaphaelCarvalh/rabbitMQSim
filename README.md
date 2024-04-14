# RabbitMQ

Este repositório contém exemplos e recursos relacionados ao RabbitMQ, um poderoso message broker amplamente utilizado para construir sistemas distribuídos e implementar padrões de mensagens.

## O que é o RabbitMQ?

O RabbitMQ é um software de message broker de código aberto que implementa o Protocolo Avançado de Filas de Mensagens (AMQP). Ele oferece um sistema robusto de mensagens onde as aplicações podem trocar mensagens entre si. O RabbitMQ suporta vários protocolos de mensagens, incluindo AMQP, MQTT e STOMP, tornando-o versátil para diferentes casos de uso.

##Onde:

Mensagem: É um objeto com o propósito de chegar a uma ou mais filas. Uma mensagem pode conter dados em diferentes formatos, como JSON, texto ou XML.

Fila: É o local onde as mensagens enviadas ficam armazenadas, aguardando para serem consumidas por outras aplicações. As filas seguem o padrão conhecido como FIFO (first-in, first-out), o que significa que o primeiro a entrar é o primeiro a sair.

Produtor (Producer): É responsável por criar e enviar uma nova mensagem para o exchange.

Consumidor (Consumer): É o agente responsável por consumir ou retirar uma informação (mensagem) da fila.

## Uso...
<div align="center">
  <h4>Mensagens enviadas e sendo acumuladas em fila de espera pois o Consumidor  estava offline,</h4>
  <img src="https://cdn.discordapp.com/attachments/1177172733554065428/1229181253597659238/image.png?ex=662ebf3f&is=661c4a3f&hm=574711ab9270d19b1aed31e06dc3495fea48f7d1ea0ac0963012c935141350a6&" width="620">
</div>
<div align="center">
  <h4>Mensagens sendo entregues começam a esvaziar a fila,</h4>
  <img src="https://cdn.discordapp.com/attachments/1177172733554065428/1229181497148313641/image.png?ex=662ebf7a&is=661c4a7a&hm=bb08898c074ab08bfaf7866f7a1cec6f58e972ebd0d4c3f762136ab4ec8c535f&" width="620">
</div>
<div align="center">
  <h4>fila zerada apresentando um sincronismo entre Consumidor e Produtor !</h4>
  <img src="https://cdn.discordapp.com/attachments/1177172733554065428/1229181554455220224/image.png?ex=662ebf87&is=661c4a87&hm=6affda2a1901dba2c05668c070119c1bcb1ff0f8d130aeb9cb6952c0b6f4ae6b&" width="620">
</div>

