# WebApi Mercado Eletronico - Desafio


Api-Restfull

Fluxo de Pedidos e Mudanças de Status



Desenvolvida com C# .Net 5.0



# Módulos:

  ME.Pedidos.MediadorEventos - Responsável pelo handler de eventos relacionados ao fluxo de negocio, utilizado package de referência MediatR-9.0 

  ME.Pedidos.Infra - Responsável pela persitência, utlizando como base Entityframework.Core-5.0

  ME.Pedidos.Domain - Responsável pela lógica das regras negócio. 
                      Nesta camada foi utilizado o Padrão Chain of Responsibility, para implementacao das regras de mudanca de status do pedido

  ME.WebApi - Responsável pela exposição dos endpoints.

  ME.WebApi.Tests - Responsável pelos testes unitários.




