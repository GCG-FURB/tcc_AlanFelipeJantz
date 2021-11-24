# Anotações da reuniões

## 2021-03-08

### Conversamos sobre a ideia do que fazer no TCC

título: Utilizar técnicas de Realidade Virtual para auxiliar Pacientes em Tratamento de
Fóbia  

  -> assunto: química / biológia / educação  

Altura / Público / animais / ...  

Especialista:  

- psicologo  
- da área assunto  

Plataforma:  

- desktop  
- móvel  
  - Realidade Aumentada  
Jogo Sério -> simulador -> usuário (paciente)  
Coletar dados -> tarefa  

-> facilitar está parte  
 -> Unity + C#  

----

## 2021-05-04

### Defesa Pré-projeto  

[Anotações de defesa do Pré-projeto](./tcc_AlanFelipeJantz_2021-05-04_PreProjeto_Defesa.md)

## 2021-08-10  

- sobre disciplina de TCC2  

### Parte teórica x prática

#### Parte teórica

- máximo 4 semanas só parte prática  
- pegar com TCC2 os ajustes da banca no projeto  
- ATENÇÃO: as correções são para o artigo (não no projeto)  
- Ver revisão da banca do projeto: <https://github.com/dalton-reis/tcc_AlanFelipeJantz/blob/main/_dalton/tcc_AlanFelipeJantz_2021-07-05_Projeto_Banca_revisao.pdf>  
- Ver revisão do prof. de TCC2  
- Pensar em algumas imagens suas:  
  - especificação  
  - mostre o seu cenário  

#### Parte prática  

  Hardware: Dalton pegar HMD novo no LIFE e deixar no LCI.  

  Versão Unity: não mudar até o final  
  Nào usar versão beta  
  GitHub: ter um gitIgnore  
     Assets  
     Packages  
     ProjectSettings  

Asset HunterPro (limpa projeto)  

Lista itens e clássica: ordem importância e grupos  

##### RVi (CardBoard) Google  

[CardBoard](CardBoard "CardBoard")  

- Ter visão estereoscópica  
- botões "volta" e "CFG"  
  - selecionar usando curso de ponteiro  
  - GamePad  

## 2021-08-17  

Pegou o cardboard.  
Fez um projeto em Unity usando a biblioteca do CardBoard da Google.  
Testou a aplicação de teste usando Android e o CardBoard e funcionou.  

Pedi para testar o audio.  
Pedi para achar um modelo de elevador panorâmico mais realístico na Asset Store da Unity.  

Acho um exmeplo de código que usa o cursor vitual (selecionar uns cubos).  
USaro curso virtual para interagir.  
GamePad: se for preciso usar depois.  

Gamificação: se divitir e não sofrer tanto.  
A maioria dos exemplos de sistemas gamificados é muito comum identificar a utilização de uma tríplice de componentes de games, os PBL’s (acrônimo de Points, Badges e Leaderboards), pois estes elementos conseguem servir várias funções (PBL TRIAD, 2014).  
Tentar pensar como usar estes componentes no cenário do elevador.  

Não é um jogo, sim VRET -> limitar o cenário.  

@dalton-reis: buscar um pscicologo na FURB.  
  Enviei chat Teams para o prof. "Carlos Roberto de Oliveira Nunes".  
  [2021-08-23_Prof_CarlosNunes.png](2021-08-23_Prof_CarlosNunes.png "2021-08-23_Prof_CarlosNunes.png").  

## 2021-08-24

- buscou por modelos de elevadores e só encontrou não panorâmico, e são pagos.  
- como PC não tem Bluetootch, configurou um Jostick dele para usar.  

- O prof. CarlosNunes participou da reunião.  
Explicamos o cenário.  
Optou mais para coletar dados em tempo real.  
Comentou sobre Neuro FeedBack e Bio FeedBack.  

Penso que podemos voltar a ideia inicial discuitda na defesa do projeto:  

- criar só um aplicativo com menu para ser usado pelo paciente e pscicologo.  
- a opção do paciente usar o GamePad e ser em CardBoard. E o paciente poder controlar algumas coisas, como a altura dele.  
- a versão do pscicologo poder ser exbida em tela cheia mostrando dados do monitoramento, como:
  - cena atual vista pelo paciente;  
  - mapa em 2D, como marca de odne ele já foi;  
  - filmagem dos olhos dele;  
  - dados de monitoramento: cardiago e de respiração;  
  - poderia extender e usar o MindEye (tcc antigo).  

[x] @dalton-reis, passar o código do Waltrick para usar a biblioteca multiplayer Mirror.

## 2021-09-14

- semanas anteriores foi feriado.  
- modelou o cenário (uma cidade).  
- Elaborou um Gamificação "visualização" de bolas, que vai subindo os andares e aumentando o nivel.  
- gravou vídeo de [2021-09-14_Testes](2021-09-14_Testes.mp4 "2021-09-14_Testes.mp4")  

Vai fazer:

- desenvolver parte do audio: barulho do elevador, barulho do vento, e chachalhar a pessoa.  
- retorno que selecionou a bola.  

Me passou o link do vídeo que gravou e do GitHub (o GitHub tem projeto no Kanban).  

Alguns testes: [2021-09-14_Testes.mp4](2021-09-14_Testes.mp4)  

## 2021-09-21

[x] fez rotina do audio, tem o barulho do vento.  
[ ] achar um som de barulho de elevador.  
[x] controle dos níveis feitos.  

[ ] vai explorar coletar dados do seu Watch: Galaxy Watch Active  
   sugeri procurar alguma coisa para Flutter e Unity.  
  Preocupação se for fazer uma aplicação separada para depois "juntar" os dados do mundo virtual e do dados fisiologicos.  

## 2021-09-28

[@alanjantz]  
Estava sem Internet ... não fizemos a reunião mas enviou o relatório do que fez:  
Então, até agora consegui fazer o seguinte:  

1) Relatório de altura do usuário durante o uso do aplicativo, bem simples mesmo, no estilo "hora - altura" (formato txt)  
2) Relatório dos níveis do jogo e quantidade de pontos, mostra (formato json, as infos ficam num objeto): quando o usuário começou a jogar, o total de níveis esperados, o tempo que começou e terminou cada nível, os pontos coletados naquele nível. Mostra a altura do ponto e a altura que o usuário estava (ai permite analisar se ele olhou pra baixar ou pra cima pra pontuar, ou se tava muito distante, etc)* aqui falta apenas fazer um ajuste para caso o usuário desista no meio do jogo, pra salvar tudo que ele conseguiu fazer até onde ele foi.  
3) Adicionei um "ponteiro" para onde o usuário está olhando, que era uma das melhorias que a gente comentou.  

Sobre a parte de coleta de dados fisiológicos, eu andei pesquisando:  

1) O Unity tem acesso a leitura de alguns sensores por padrão (através do InputSystem), mas nenhum envolvendo coletas de dados fisiológicos, como batimento ou respiração.  
2) Até 2017, o unity dava suporte pro Tizen, que era utilizado para criação de apps voltados a smart watch e tal, mas eles não dão mais suporte... Com isso, meio que desisti de tentar coletar os dados através do Unity mesmo e estou pensando em fazer um outro aplicativo (muito mais simples) que apenas lê esses sensores e salva em um arquivo txt da mesma forma que o primeiro relatório, estilo data - valor. Para isso, tenho algumas opções.  
3) Criar um App nativo usando Android, que possui classes que leem e conseguem coletar os valores destes sensores (mas acredito que seja mais demorado para mim, já que nao tenhon experiencia com android nativo).  
4) A samsung tem uma API para o Galaxy Watch, permitindo criar aplicações utilizando C# (msm linguagem do Unity) e com aplicações web (<https://developer.samsung.com/galaxy-watch-tizen>) Acho que vou tomar esta quarta opção pra coleta dos dados dos sensores. Essa semana ainda pretendo fazer algum tutorial coletando estes dados e se tudo der certo, semana que vem já consigo mostrar coletando os dados e criando o relatório.  

Finalizando esse item acima, a ideia seria também criar uma outra aplicação que seria utilizada apenas pelo médico psicólogo para ter acesso a tudo isso que foi coletado.  
Teria a leitura desses arquivos e a ideia seria poder mostrar isso em algum tipo de dashboard (pra não ficar apenas uma leitura de tabela com coluna e valor) pra ajudar a entender melhor o comportamento.  
Aproveitaria para tentar fazer nessa aplicação também o esquema do Mirror, para mostrar a tela do usuário enquanto ele utiliza o aplicativo.  
Mas isso seria mais pra frente (daqui umas 2/3 semanas mesmo).  

[@dalton-reis]  
Ok, poderias tentar deixar junto no mesmo projeto a cena para o CardBoard e a cena para o Médico usar. ... assim teria um menu para decidir qual cena usar.  

Alguns testes: [2021-09-14_Testes.mp4](2021-09-22_Testes.mp4)  

## 2021-10-19

Avançou no desenvolvimento.  
Ainda não iniciou a escrita. Vai iniciar na próxima semana. Disse que era para deixar o 3a trabalho correlato novo sugerido pela banca para depois de escrever a capítulo 3.  

1 semana para registro do relógio para o smartwatch .. e melhorar o registro de atividades.  

## 2021-10-26

- vai tentar usar o próprio Android Studio.  
- vai mexer o texto.  

## Algumas reuniões sem anotações

## 2021-11-16

Escreveu boa parte do artigo. Está trabalhando na seção da Implementação.  
Criei um novo questionário, mas disse esperarmos a resposta do prof. Carlos para ver se usaríamos.  
[x] @alanjantz: vai gerar um vídeo da aplicação, e enviar para o Dalton.  
[x] @dalton-reis: escrever mensagem no grupo do prof. Carlos/Alan para tentar agendar os testes passando o vídeo gravado.  
[ ] @dalton-reis: duplicar no meu equipamento o aplicativo. Usar o controle do Gabriel.  

## 2021-11-23

Enviei msg. com vídeo para marcamos avaliação.  
[2021-11-26_Testes_Acroboard.mp4](2021-11-26_Testes.mp4)  

Professor Carlos resondeu que pode participar dos testes.  
