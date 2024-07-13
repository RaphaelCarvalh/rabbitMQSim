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
  <img src="https://lh3.googleusercontent.com/d/1Dg21DzdarZq2TZ0t89KXxbKexAUJHuLN" width="621">
</div>
<div align="center">
  <h4>Mensagens sendo entregues começam a esvaziar a fila,</h4>
  <img src="https://lh3.googleusercontent.com/d/1G2lQqWrebY9CTDlMCPIv1GkqO7crmxxQ" width="621"">
</div>
<div align="center">
  <h4>fila zerada apresentando um sincronismo entre Consumidor e Produtor !</h4>
  <img src="https://lh3.googleusercontent.com/d/1VzR9befytcy3T6o8Vz3TZnSEpsMaSH6p" width="621"">
</div>

