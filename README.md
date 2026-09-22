# ToDo List

## Objetivo

O objetivo deste projeto é desenvolver uma aplicação de lista de tarefas utilizando C# e .NET.

O sistema permitirá que o usuário crie, visualize, edite, conclua, reabra e exclua tarefas.

O projeto também tem como objetivo praticar conceitos de programação, como:

* Programação Orientada a Objetos (POO)
* Classes e objetos
* Listas e coleções
* Métodos
* Condicionais
* Estruturas de repetição
* Manipulação de dados
* CRUD (Create, Read, Update, Delete)

---

## Funcionalidades

O sistema terá inicialmente as seguintes funcionalidades:

* [ ] Criar tarefa
* [ ] Listar tarefas
* [ ] Editar tarefa
* [ ] Concluir tarefa
* [ ] Reabrir tarefa
* [ ] Excluir tarefa

---

## Estrutura da Tarefa

Cada tarefa deverá possuir os seguintes campos:

| Campo           | Tipo       | Descrição                                 |
| --------------- | ---------- | ----------------------------------------- |
| Id              | `int`      | Identificador único da tarefa             |
| Título          | `string`   | Nome da tarefa                            |
| Descrição       | `string`   | Detalhes sobre a tarefa                   |
| Status          | `bool`     | Indica se a tarefa está concluída         |
| Data de criação | `DateTime` | Data e horário em que a tarefa foi criada |
| Data limite     | `DateTime` | Data limite para concluir a tarefa        |

---

## Regras do Sistema

### Título

* O título é obrigatório.
* O título deve possuir no mínimo 3 caracteres.
* O título deve possuir no máximo 100 caracteres.

### Descrição

* A descrição é opcional.
* A descrição deve possuir no máximo 500 caracteres.

### Status

* Uma nova tarefa deve ser criada como **pendente**.
* O usuário poderá marcar uma tarefa como **concluída**.
* Uma tarefa concluída poderá ser **reaberta**.

### Datas

* A data de criação será definida automaticamente pelo sistema.
* A data limite não poderá ser anterior à data de criação.

### Id

* Cada tarefa deverá possuir um Id único.
* O Id será definido automaticamente pelo sistema.

---

## Operações

O sistema deverá permitir:

### Criar

O usuário informa os dados da tarefa e o sistema cria uma nova tarefa.

### Listar

O sistema exibe todas as tarefas cadastradas.

### Editar

O usuário poderá alterar os dados de uma tarefa existente.

### Concluir/Reabrir

O usuário poderá alterar o status da tarefa entre:

* Pendente
* Concluída

### Excluir

O usuário poderá excluir uma tarefa existente pelo seu Id.

---

## Tecnologias

* C#
* .NET
* Git
* GitHub

---

## Status do Projeto

🚧 Em desenvolvimento.

As funcionalidades serão implementadas gradualmente conforme o desenvolvimento do projeto.
