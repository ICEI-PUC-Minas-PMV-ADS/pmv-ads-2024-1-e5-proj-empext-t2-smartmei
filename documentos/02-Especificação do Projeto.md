# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/blob/main/documentos/01-Documenta%C3%A7%C3%A3o%20de%20Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Arquitetura e Tecnologias

o	Descreva brevemente a arquitetura definida para o projeto e as tecnologias a serem utilizadas. Sugere-se a criação de um diagrama de componentes da solução.

## Project Model Canvas

![PMC](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/a6b46bd5-ab58-451e-8642-5fdfb998a4b6)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

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

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-003| A aplicação deve ter bom nível de contraste entre os elementos da tela em conformidade. |  BAIXA | 
|RNF-004| A aplicação deve ser compatível com os navegadores mais utilizados do mercado. |  MÉDIA |
|RNF-005| A aplicação deve ser intuitiva para que o usuário consiga encontrar as informações que deseja facilmente.  |  ALTA |
|RNF-006| A aplicação deve utilizar senhas criptografadas.  |  ALTA |



Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

## Modelo ER (Projeto Conceitual)

![Modelo relacional](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/abe53567-9cb7-439d-8d13-5dfb2f922243)

## Projeto da Base de Dados

![Projeto de BD](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/db1fdf9b-147e-45a1-8b8c-35380ea04aab)
