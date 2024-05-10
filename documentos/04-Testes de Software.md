# Planos de Testes de Software

Apresentação dos cenários de testes utilizados na realização dos testes da aplicação, demonstrando os requisitos sendo satisfeitos.

**Ferramenta utilizada no teste**: Microsoft Clipchamp para gravação da tela de teste.

| **Caso de Teste** 	| **CT-01 - Cadastro de usuários** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir ao usuário cadastrar uma conta. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Clicar em “Cadastro” no menu <br> - Preencher os campos obrigatórios <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
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
|Critério de Êxito | - Os dados inseridos no filtro de pesquisa devem mostrar os produtos e receitas onde há o dado informado. |
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
| **Caso de Teste** 	| **CT-10 - Filtros**	|
|	Requisito Associado 	| RF-010 - A aplicação deve permitir ao usuário filtrar os registros específicos de clientes, eventos, projetos, custos e faturamento. |
| Objetivo do Teste 	| Verificar se o usuário consegue filtrar registros na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar na página correspondente no menu superior <br> - Inserir no filtro os dados do registro que deseja recuperar <br> - Clicar no botão "Filtrar" <br> |
|Critério de Êxito | - Foi exibido o registro com o dado pesquisado. |
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
| **Caso de Teste** 	| **CT-13 - Relatórios de registros** |
|	Requisito Associado 	| RF-013 - A aplicação deve permitir ao usuário gerar um relatório dos registros cadastrados. |
| Objetivo do Teste 	| Verificar se o usuário consegue gerar os relatórios dos registros cadastrados na aplicação. |
| Passos 	| - Acessar a aplicação web <br> - Fazer o login na aplicação web <br>  - Clicar em “Relatórios” no menu superior <br> - Clicar no relatório desejado |
|Critério de Êxito | - Download do arquivo do relatório na extensão PDF. |
|  	|  	|




# Evidências de Testes de Software

**Caso de Teste 01**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/b9f7033d-ad5b-483a-a97d-2dda6597bb5a

**Caso de Teste 02**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/f2ccba66-2012-4c16-8d2d-5507443fcee2

**Caso de Teste 03**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/2bcbedc8-acc5-4340-9201-aa1be8a4257e

**Caso de Teste 04**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/90547433-eeed-4fd3-9e6d-436d2c2e29eb

**Caso de Teste 05**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/55ecbebf-cb82-447a-8870-121c357d2476

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

**Caso de Teste 10**
<br>

- Projetos

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/9a395cdf-09df-4b25-914b-cdf88f4095ee

- Clientes
  
https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/15952470-fb44-475e-bafe-e043aa7c5d7b

- Custos

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/a59afbf5-8185-463a-be39-c39ae6b39f1f

- Eventos

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/0ab338d1-947e-4975-ae76-5822cb92c8a6

- Faturamentos

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/0ba01d32-879f-45d3-84dd-e586a9e65b42

**Caso de Teste 12**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/cf0b641d-e1bd-4b23-9f5e-3f8b7d007ac4

**Caso de Teste 12.1**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/9298beae-04af-4f06-bb0e-f466f73f0ba1

**Caso de Teste 12.2**
<br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/97e1b307-ef33-43b5-8076-a14b65b5e084

<hr>

# Avaliação por pares

| **Caso de Teste** 	| **CT-01 - Cadastro de usuários, CT-02 - Efetuar login e CT-03 - Efetuar logout**	|
|:---:	|:---:	|
|	Desenvolvido por 	| Rúbia e Guilherme |
| Testado por 	| Daiane |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/4caf71ef-d63e-4605-87a6-bd97135abec6

| **Caso de Teste** 	| **CT-04 - Gerenciamento de conta**	|
|:---:	|:---:	|
|	Desenvolvido por 	| Rúbia e Guilherme |
| Testado por 	| Juliana |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/b8b890ee-627d-4ca0-a443-b9b5f8c71df7

| **Caso de Teste** 	| **CT-05- Redefinir Senha**	|
|:---:	|:---:	|
|	Desenvolvido por 	| Rúbia e Guilherme |
| Testado por 	| Juliana |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/fae1e606-5681-4d20-b598-69b86d872cae

| **Caso de Teste** 	| **CT-06 - Administrar projetos - Cadastrar e visualizar**	|
|:---:	|:---:	|
|	Desenvolvido por 	| Daiane |
| Testado por 	| Juliana |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/121550ad-51a4-4377-9210-60852766db6b

| **Caso de Teste** 	| **CT-06.01 - Administrar projetos -  Editar**	|
|:---:	|:---:	|
|	Desenvolvido por 	| Daiane |
| Testado por 	| Juliana |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/81257366-df50-4845-8fcd-3aaffb42f412

| **Caso de Teste** 	| **CT-06.2 - Administrar projetos - Excluir**		|
|:---:	|:---:	|
|	Desenvolvido por 	| Daiane |
| Testado por 	| Juliana |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/ed47fa6b-1c01-4636-b4d0-92d5830a9c1b

| **Caso de Teste** 	| **CT-07 - Administrar clientes - Cadastrar e visualizar**	|
|:---:	|:---:	|
|	Desenvolvido por 	| Juliana |
| Testado por 	| Fernanda |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/e298605e-3c25-42a9-9400-67888fa4da1f


| **Caso de Teste** 	| **CT-07.1 - Administrar clientes - Editar**		|
|:---:	|:---:	|
|	Desenvolvido por 	| Juliana |
| Testado por 	| Fernanda |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/bf532124-6e8d-41c3-842f-cbe75a06b67c


| **Caso de Teste** 	| **CT-07.2 - Administrar clientes - Excluir**		|
|:---:	|:---:	|
|	Desenvolvido por 	| Juliana |
| Testado por 	| Fernanda |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/a01e6f65-0f69-4e45-86f6-9978559f7456


| **Caso de Teste** 	| **CT-08 - Gerenciamento de custos - Cadastrar e visualizar, CT-08.1 - Gerenciamento de Custos - Editar, CT-08.2 - Gerenciamento de Custos - Excluir**	|
|:---:	|:---:	|
|	Desenvolvido por 	| Fernanda |
| Testado por 	| Daiane |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/bc5b0aa4-57dc-4b26-81a2-93846f3d242b

| **Caso de Teste** 	| **CT-10 - Filtros**		|
|:---:	|:---:	|
|	Desenvolvido por 	| Daiane |
| Testado por 	| Fernanda |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/b0098ae6-af06-43b7-87d7-98831cfe8c37

| **Caso de Teste** 	| **CT-10 - Filtros**		|
|:---:	|:---:	|
|	Desenvolvido por 	| Juliana |
| Testado por 	| Fernanda |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/c7e76747-3c45-438f-9c0d-d328d0e87958

| **Caso de Teste** 	| **CT-10 - Filtros**		|
|:---:	|:---:	|
|	Desenvolvido por 	| Juliana |
| Testado por 	| Fernanda |

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/81182674/4c69d476-e9fa-4806-bfb9-76345cfa0500


| **Caso de Teste** 	| **CT-12 - Gerenciamento de Faturamento - Cadastrar e visualizar, CT-12.1 - Gerenciamento de Faturamento - Editar, CT-12.2 - Gerenciamento de Faturamento - Excluir**	|
|:---:	|:---:	|
|	Desenvolvido por 	| Fernanda |
| Testado por 	| Rubia |


[teste-faturamento.webm](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/98122346/5eec2cda-20b7-4fea-a1a9-cc97419d3ec3)
