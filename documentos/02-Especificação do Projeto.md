# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/blob/main/documentos/01-Documenta%C3%A7%C3%A3o%20de%20Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário.

## Arquitetura e Tecnologias

|Nome                | Função                             |
|--------------------|------------------------------------|
|Whatsapp, Google Meet | Comunicação entre a equipe; comunicação entre a equipe e o Product Owner do projeto.  |
|Github | Repositório da documentação e código fonte do projeto; gerenciamento de funções e tarefas.  |
|Git | Gestão do código fonte (versionamento).  |
|Microsoft Visual Studio | Criação do código fonte. |
|Microsoft SQL Server | Criação e administração do banco de dados.  |
|Lucidchart  | Criação dos diagramas e modelos. |
|Marvel App  | Projeto de interface e wireframes. |
|Bootstrap, ASP.NET Core MVC | Bibliotecas e framework utilizados.  |
|HTML, C#, CSS, JavaScript | Linguagens de programação utilizadas na criação do código fonte da aplicação. |

A ilustração de como as tecnologias estão relacionadas e como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário, pode ser visualizada na figura abaixo:

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100742971/884b30e9-7d3a-49f9-8ab7-77fa6334a80d)

## Project Model Canvas

![PMC](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/a6b46bd5-ab58-451e-8642-5fdfb998a4b6)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir ao usuário cadastrar uma conta | ALTA | 
|RF-002| A aplicação deve permitir ao usuário cadastrado fazer o login em sua conta   | ALTA |
|RF-003| A aplicação deve permitir ao usuário cadastrado sair da sua conta   | MÉDIA |
|RF-004| A aplicação deve permitir ao usuário gerenciar a sua conta   | MÉDIA |
|RF-005| A aplicação deve permitir ao usuário redefinir sua senha   | MÉDIA |
|RF-006| A aplicação deve permitir ao usuário gerenciar seus projetos   | ALTA |
|RF-007| A aplicação deve permitir ao usuário administrar seus clientes   | ALTA |
|RF-008| A aplicação deve permitir ao usuário gerenciar seus custos   | ALTA |
|RF-009| A aplicação deve permitir ao usuário gerenciar seus eventos  | ALTA |
|RF-010| A aplicação deve permitir ao usuário filtrar os registros específicos de clientes, eventos, projetos, custos e faturamento   | MÉDIA |
|RF-011| A aplicação deve notificar o usuário quando o faturamento ultrapassar o limite e teto MEI   | ALTA |
|RF-012| A aplicação deve permitir ao usuário gerenciar seu faturamento   | ALTA |
|RF-013| A aplicação deve permitir ao usuário gerar um relatório dos registros cadastrados| MÉDIA|

**Técnica de priorização de requisitos**

A técnica de priorização de requisitos utilizada foi a Escala de Três Níveis, com os valores "Alta", "Média" e "Baixa", associada ao quadrante de priorização, que estabeleu a importância e urgência dos requisitos.

![Cópia de Quadrante_4](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/98122346/83ac703d-1fc1-4a77-a2c3-bf4133bece86)

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----| 
|RNF-001| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-002| A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade |  BAIXA | 
|RNF-003| A aplicação deve ser compatível com os navegadores mais utilizados do mercado |  MÉDIA |
|RNF-004| A aplicação deve ser intuitiva para que o usuário consiga encontrar as informações que deseja facilmente  |  ALTA |
|RNF-005| A aplicação deve utilizar senhas criptografadas  |  ALTA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 09/06/2024. |
|02| A plataforma deve se restringir às tecnologias básicas utilizando ferramentas de desenvolvimento pré-estabelecidas. |
|03| A plataforma se compromete em não compartilhar históricos de pesquisa e dados sensíveis dos usuários. |
|04| A equipe não pode subcontratar o desenvolvimento do trabalho. |


## Diagrama de Casos de Uso

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100734910/47e704c9-d71d-4ff0-9ba4-7ef49658c54c)

## Modelo ER (Projeto Conceitual)

![Modelo relacional](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/abe53567-9cb7-439d-8d13-5dfb2f922243)

## Projeto da Base de Dados

![Projeto de BD](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/db1fdf9b-147e-45a1-8b8c-35380ea04aab)
