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
  <img src="https://media.discordapp.net/attachments/1177172733554065428/1229181253597659238/image.png?ex=6671fbbf&is=6670aa3f&hm=c9e4e03c15acd98dfcbdb419f008cc860887411306afdb66b58941ef0b315893&=&format=webp&quality=lossless&width=1097&height=671">
</div>
<div align="center">
  <h4>Mensagens sendo entregues começam a esvaziar a fila,</h4>
  <img src="https://media.discordapp.net/attachments/1177172733554065428/1229181497148313641/image.png?ex=6671fbfa&is=6670aa7a&hm=18bb4971dbac12e9ed7ef4641b7bd8e9eb40c75d2c78b5144885bc10bb9b72ef&=&format=webp&quality=lossless&width=1440&height=584">
</div>
<div align="center">
  <h4>fila zerada apresentando um sincronismo entre Consumidor e Produtor !</h4>
  <img src="https://media.discordapp.net/attachments/1177172733554065428/1229181554455220224/image.png?ex=6671fc07&is=6670aa87&hm=dbe6f3b635e62ba1cba32c6ea8286aed4cdce4039348e439fae35089b43f90ab&=&format=webp&quality=lossless&width=1440&height=621">
</div>

