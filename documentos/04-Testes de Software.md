# Planos de Testes de Software

Apresentação dos cenários de testes utilizados na realização dos testes da aplicação, demonstrando os requisitos sendo satisfeitos.

**Ferramenta utilizada no teste**: Microsoft Clipchamp para gravação da tela de teste.

| **Caso de Teste** 	| **CT-01 - Cadastro de usuários** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Clicar em “Cadastro” no menu <br> - Preencher os campos obrigatórios <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
| **Caso de Teste** 	| **CT-02 - Efetuar login** 	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir ao usuário cadastrado efetuar login em sua conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar o login. |
| Passos 	| - Acessar a aplicação web <br> - Clicar em “Login” no menu <br> - Preencher os campos obrigatórios <br> - Clicar em "Entrar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 - Efetuar logout** 	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir ao usuário cadastrado fazer logout de sua conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar o logout. |
| Passos 	| - Acessar a aplicação web <br> - Clicar em “Login” no menu <br> - Realizar o login <br> - Clicar em "Sair" |
|Critério de Êxito | - O logout foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 - Gerenciamento de conta** 	|
|	Requisito Associado 	| RF-004 - A aplicação deve permitir ao usuário gerenciar a sua conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue gerenciar seus dados. |
| Passos 	| - Acessar a aplicação web <br> - Clicar em “Login” no menu <br> - Realizar o login <br> - Acessar o "Perfil" no menu <br> - Clicar em "Editar" <br> - Editar os campos desejados <br> - Clicar em Salvar. |
|Critério de Êxito | - O usuário conseguiu alterar seus dados com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 -  Redefinir senha** 	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao usuário cadastrado redefinir sua senha. |
| Objetivo do Teste 	| Verificar se o usuário consegue redefinir sua senha. |
| Passos 	| - Acessar a aplicação web <br> - Clicar em “Login” no menu <br> - Realizar o login <br> - Acessar o "Perfil" no menu <br> - Clicar em "Editar" <br> - Redefinir sua senha <br> - Clicar em Salvar. |
|Critério de Êxito | - O usuário conseguiu alterar sua senha. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 - Gerenciamento de projetos - Cadastrar e visualizar**	|
|	Requisito Associado 	| RF-006 - A aplicação deve permitir ao usuário gerenciar seus projetos. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar e visualizar projetos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Projetos” no menu superior <br> - Clicar no botão “Adicionar” <br> - Preencher os campos obrigatórios <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o novo registro. |
|  	|  	|
| **Caso de Teste** 	| **CT-06.1 - Gerenciamento de projetos - Editar**	|
|	Requisito Associado 	| RF-006 - A aplicação deve permitir ao usuário gerenciar seus projetos. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar projetos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Projetos” no menu superior <br> - Clicar no botão “Editar” <br> - Editar os campos desejados <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o registro editado. |
|  	|  	|
| **Caso de Teste** 	| **CT-06.2 - Gerenciamento de projetos - Excluir**	|
|	Requisito Associado 	| RF-006 - A aplicação deve permitir ao usuário gerenciar seus projetos. |
| Objetivo do Teste 	| Verificar se o usuário consegue excluir projetos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Projetos” no menu superior <br> - Clicar no botão “Excluir” <br> - Confirmar a exclusão do registro do projeto, clicando no botão "Sim" <br> |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados não exibindo o registro excluído. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 - Administrar clientes - Cadastrar e visualizar**	|
|	Requisito Associado 	| RF-007 - A aplicação deve permitir ao usuário administrar seus clientes. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar e visualizar clientes registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Clientes” no menu superior <br> - Clicar no botão “Adicionar” <br> - Preencher os campos obrigatórios <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o novo registro. |
|  	|  	|
| **Caso de Teste** 	| **CT-07.1 - Administrar clientes - Editar**	|
|	Requisito Associado 	| RF-006 - A aplicação deve permitir ao usuário administrar seus clientes. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar seus clientes registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Clientes” no menu superior <br> - Clicar no botão “Editar” <br> - Editar os campos desejados <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o registro editado. |
|  	|  	|
| **Caso de Teste** 	| **CT-07.2 - Administrar clientes - Excluir**	|
|	Requisito Associado 	| RF-006 - A aplicação deve permitir ao usuário administrar seus clientes. |
| Objetivo do Teste 	| Verificar se o usuário consegue excluir seus clientes registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Clientes” no menu superior <br> - Clicar no botão “Excluir” <br> - Confirmar a exclusão do registro dos dados do cliente, clicando no botão "Sim" <br> |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados não exibindo o registro excluído. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 - Gerenciamento de custos - Cadastrar e visualizar**	|
|	Requisito Associado 	| RF-008 - A aplicação deve permitir ao usuário gerenciar seus custos. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar e visualizar os custos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Custos” no menu superior <br> - Clicar no botão “Adicionar” <br> - Preencher os campos obrigatórios <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o novo registro. |
|  	|  	|
| **Caso de Teste** 	| **CT-08.1 - Gerenciamento de Custos - Editar**	|
|	Requisito Associado 	| RF-008 - A aplicação deve permitir ao usuário gerenciar seus custos. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar seus custos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Custos” no menu superior <br> - Clicar no botão “Editar” <br> - Editar os campos desejados <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o registro editado. |
|  	|  	|
| **Caso de Teste** 	| **CT-08.2 - Gerenciamento de Custos - Excluir**	|
|	Requisito Associado 	| RF-008 - A aplicação deve permitir ao usuário gerenciar seus custos. |
| Objetivo do Teste 	| Verificar se o usuário consegue excluir os custos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Custos” no menu superior <br> - Clicar no botão “Excluir” <br> - Confirmar a exclusão do registro do custo, clicando no botão "Sim" <br> |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados não exibindo o registro excluído. |
|  	|  	|
| **Caso de Teste** 	| **CT-09 - Gerenciamento de Eventos - Cadastrar e visualizar**	|
|	Requisito Associado 	| RF-009 - A aplicação deve permitir ao usuário gerenciar seus eventos. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar e visualizar os eventos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Eventos” no menu superior <br> - Clicar no botão “Adicionar” <br> - Preencher os campos obrigatórios <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o novo registro. |
|  	|  	|
| **Caso de Teste** 	| **CT-09.1 - Gerenciamento de Eventos - Editar**	|
|	Requisito Associado 	| RF-009 - A aplicação deve permitir ao usuário gerenciar seus eventos. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar seus eventos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Eventos” no menu superior <br> - Clicar no botão “Editar” <br> - Editar os campos desejados <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o registro editado. |
|  	|  	|
| **Caso de Teste** 	| **CT-09.2 - Gerenciamento de Eventos - Excluir**	|
|	Requisito Associado 	| RF-009 - A aplicação deve permitir ao usuário gerenciar seus eventos. |
| Objetivo do Teste 	| Verificar se o usuário consegue excluir os eventos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Eventos” no menu superior <br> - Clicar no botão “Excluir” <br> - Confirmar a exclusão do registro do evento, clicando no botão "Sim" <br> |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados não exibindo o registro excluído. |
|  	|  	|
| **Caso de Teste** 	| **CT-12 - Gerenciamento de Faturamento - Cadastrar e visualizar**	|
|	Requisito Associado 	| RF-012 - A aplicação deve permitir ao usuário gerenciar seu faturamento. |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar e visualizar os faturamentos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Faturamentos” no menu superior <br> - Clicar no botão “Adicionar” <br> - Preencher os campos obrigatórios <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o novo registro. |
|  	|  	|
| **Caso de Teste** 	| **CT-12.1 - Gerenciamento de Faturamento - Editar**	|
|	Requisito Associado 	| RF-012 - A aplicação deve permitir ao usuário gerenciar seu faturamento. |
| Objetivo do Teste 	| Verificar se o usuário consegue editar seus faturamentos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Faturamentos” no menu superior <br> - Clicar no botão “Editar” <br> - Editar os campos desejados <br> - Clicar em "Salvar" |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados contendo o registro editado. |
|  	|  	|
| **Caso de Teste** 	| **CT-12.2 - Gerenciamento de Faturamento - Excluir**	|
|	Requisito Associado 	| RF-012 - A aplicação deve permitir ao usuário gerenciar seu faturamento. |
| Objetivo do Teste 	| Verificar se o usuário consegue excluir os faturamentos registrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Faturamentos” no menu superior <br> - Clicar no botão “Excluir” <br> - Confirmar a exclusão do registro do faturamento, clicando no botão "Sim" <br> |
|Critério de Êxito | - A tela foi redirecionada para a exibição de registros cadastrados não exibindo o registro excluído. |
|  	|  	|



# Evidências de Testes de Software

**Caso de Teste 01**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/40fcac41-5e3c-4c8a-9445-894b36366c07

**Caso de Teste 02**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/f2ccba66-2012-4c16-8d2d-5507443fcee2

**Caso de Teste 03**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/2bcbedc8-acc5-4340-9201-aa1be8a4257e

**Caso de Teste 04**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/69c22664-d424-4f85-b551-1a0784272c5e

**Caso de Teste 05**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/9fa5da79-3e25-455b-ab9a-4703bca07710

**Caso de Teste 06**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/1c87ab94-c944-4089-8435-0642cd10ce3e


**Caso de Teste 06.1**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/6b8ef67b-d68f-43b9-a4ba-ff791ee1e098

**Caso de Teste 06.2**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/2235c490-3560-4d48-96b9-8b5089a2a9c1

**Caso de Teste 07**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/507aa3b0-3342-4d78-884a-0d163261d430

**Caso de Teste 07.1**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/0f687741-0a2d-4f7b-8f2b-0e6f351f48a6

**Caso de Teste 07.2**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/bc4efde6-f5ee-49d3-8392-ef59ed1ed391

**Caso de Teste 08**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/541c802a-d498-4532-b21c-9d4abfc44543


**Caso de Teste 08.1**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/58f1007a-444a-45f3-b9a7-298db7179e21


**Caso de Teste 08.2**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/7658c913-884b-4e0f-bd13-ff45fce70e96

**Caso de Teste 09**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/e9f704ac-332c-44a6-ac4b-94e958bc003b

**Caso de Teste 09.1**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/e2f4a9b0-0fe2-46f2-8f67-67a42552601d

**Caso de Teste 09.2**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/8db65b36-62e9-4cf1-a22d-a2466f6e57de

**Caso de Teste 12**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/cf0b641d-e1bd-4b23-9f5e-3f8b7d007ac4

**Caso de Teste 12.1**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/9298beae-04af-4f06-bb0e-f466f73f0ba1

**Caso de Teste 12.2**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/97e1b307-ef33-43b5-8076-a14b65b5e084








