# API - TODOS
[![status](https://img.shields.io/badge/status-completo-green)](https://github.com/LuanGrod/)
[![licence](https://img.shields.io/badge/licença-MIT-red)](https://github.com/LuanGrod/api-todos/blob/main/LICENSE)

# Sobre o projeto
Uma simples API para colocar em prática os conhecimentos de ASP.NET Core Web API

# Ferramentas e Tecnologias
- C#
- ASP.NET
- Entity Framework
- SqlServer

# Swagger
![image](https://github.com/LuanGrod/api-todos/assets/84152986/92894692-6958-48b3-9894-79904a720085)

# EndPoints
|  **HTTPS CODE**   |      **ENDPOINT**      |                                             **DESCRIÇÃO**                                            |
|:-----------------:|:----------------------:|:----------------------------------------------------------------------------------------------------:|
|        GET        | /Todo                  | Retorna todos os TODOS                                                                               |
|        GET        | /Todo/{id}             | Retorna o TODO com o id passado                                                                      |
|        GET        | /Todo/ObterPorConteudo | Retorna todos os TODOS que tenham esse texto no meio do conteúdo                                     |
|        GET        | /Todo/ObterPorStatus   | Retorna todos os TODOS que tenham esse status                                                        |
|        POST       | /Todo                  | Cria um TODO, passando pelo body o TODO                           |
|        PUT        | /Todo/{id}             | Atualiza o TODO com o id passado, passando pelo body o TODO |
|        GET        | /Todo/{id}             | Apaga o TODO com base no id passado                                                                  |

# Autores

Luan Guilherme Rodrigues - https://www.linkedin.com/in/luan-grod/



  
