# Implantação do Software

Apresentação do planejamento da implantação: descrição de tecnologias e processo de implantação.

<br>
<br>
<br>

# Metodologia

## Relação de Ambientes de Trabalho

Os artefatos do projeto serão desenvolvidos a partir das plataformas listadas abaixo, apresentadas com o seu propósito.

| AMBIENTE | PLATAFORMA |LINK DE ACESSO                 |
|--------------------|--------------------------------------------------------------------------------|----------------------------------------|
|Repositório de código fonte | GitHub | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/tree/main/codigo-fonte |
|Documentos do projeto  | GitHub | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei |
|Projeto de interface e wireframes | Marvel | https://marvelapp.com/prototype/10908134/screen/94023521  |
|Gerenciamento do projeto  | GitHub | https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/803 |

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o [Git](https://git-scm.com/), sendo que o [Github](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e4-proj-dad-t3-maisbeleza/tree/main/docs) foi utilizado para hospedagem do repositório.

Para a gestão do código fonte será utilizado um processo baseado no Gitflow, mostrado na figura abaixo, que permite que a equipe trabalhe com correções de problemas ou atualizações sem a interrupção do trabalho em andamento (Atlassian, [<i>s. d.</i>]).

![Gitflow](https://user-images.githubusercontent.com/100447878/224438616-057b263d-cb67-4f75-bacd-339024012816.png)

Fonte: Atlassian, [<i>s. d.</i>]

O projeto utilizará os seguintes nomes de branches:

- Main: versão estável já testada do software
- Hotfix: ramificação para manutenção e correções
- Develop: ramificação de integração para recursos
- Feature: novo recurso do software

## Etiquetas

As tarefas (issues) são, ainda, etiquetadas em função da natureza da atividade e seguem o seguinte esquema de cores/categorias:

- Bug: Ocorrência e identificação de erros
- Documentation: Atualização da Documentação
- Enhancement: Novo recurso adicionado
- Help wanted: Solicitação de ajuda
- Test: Testes

![Labels](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e4-proj-dad-t3-maisbeleza/assets/100447878/bac37d2d-b7de-4f04-bdd9-8708b4a04e2f)

## Gerenciamento de Projeto

A metodologia ágil escolhida para o desenvolvimento deste projeto foi o SCRUM, pois como citam Amaral, Fleury e Isoni (2019, p. 68), seus benefícios são a

“visão clara dos resultados a entregar; ritmo e disciplina necessários à execução; definição de papéis e responsabilidades dos integrantes do projeto (Scrum Owner, Scrum Master e Team); empoderamento dos membros da equipe de projetos para atingir o desafio; conhecimento distribuído e compartilhado de forma colaborativa; ambiência favorável para crítica às ideias e não às pessoas.”

### Divisão de Papéis

A equipe está organizada da seguinte maneira:
- Scrum Master: Daiane Campos Procópio;
- Product Owner: Luiz Fernando Toussaint Caetano;
- Equipe de Desenvolvimento: Daiane Campos Procópio, Fernanda Augusta de Barcelos Coura, Guilherme Faustini de Azevedo, Juliana Calazans Rodrigues de Magalhães e Rúbia Karina Prado Costa.

### Processo

Para organização e distribuição das tarefas do projeto, a equipe está utilizando o GitHub, estruturado com as seguintes listas: 

<ul>
  <li>To Do: esta lista representa o Sprint Backlog que está sendo trabalhado.</li>
  <li>In progress: lista das tarefas iniciadas.</li>
  <li>Done: nesta lista são colocadas as tarefas finalizadas e as que passaram pelos testes e controle de qualidade, prontas para serem entregues ao cliente.</li>
 </ul>

O quadro kanban do grupo no GitHub está disponível no link https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/803/views/1 e é apresentado, no estado atual, na figura abaixo:

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-empext-t2-smartmei/assets/100447878/688fa4fa-edb5-4994-89db-7db41cc73734)

### Ferramentas

As ferramentas empregadas no projeto são:

- IDE (Ambiente de Desenvolvimento Integrado): Microsfot Visual Studio
- Ferramenta de gerenciamento: Github
- Ferramenta de comunicação: Google Meet
- Ferramenta de desenho de tela (_wireframing_): Marvel

O IDE, Microsfot Visual Studio, foi escolhido porque ele possui uma integração com o sistema de versão. A ferramenta de gerenciamento do Github foi selecionada pela flexibilidade para criar fluxos de trabalho personalizados que atendam às necessidades da equipe. A ferramenta de comunicação, Google Meet, foi selecionada para as reuniões com o product owner do projeto. Por fim, para criar os desenhos de tela, utilizamos a ferramenta Marvel por melhor captar as necessidades da nossa solução.

### Referências

AMARAL, Vanessa de Araújo; OLIVEIRA, Angela Maria Fleury de; ISONI, Taciana Maria. Inovação social e metodologias ágeis: uma história de sucesso. <b>DOM</b>: a revista da Fundação Dom Cabral, Nova Lima, v. 12, n. 38, p. 66-71, maio/ago. 2019.

ATLASSIAN. <b>Fluxo de trabalho de Gitflow</b>. [s. d.]. Disponível em: https://www.atlassian.com/br/git/tutorials/comparing-workflows/gitflow-workflow. Acesso em: 26 fev. 2024.
