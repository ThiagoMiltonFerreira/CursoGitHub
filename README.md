# CursoGitHub
.1- Criar SSH 
 
 Tendo cadastrado e logado em sua conta, agora você precisa de uma chave SSH para poder começar a comitar. No Git Bash digite:

ssh-keygen -t rsa -C "seu_email@email.com"
Informe no comando seu e-mail cadastrado no GitHub. Dê Enter na próxima pergunta (sobre o arquivo a ser criado?—?vamos deixar o padrão).

A próxima pergunta vai te pedir uma senha (passphrase). Invente uma senha e a informe. Ele vai pedir uma confirmação. Digite a senha novamente e Enter. Digite agora:

notepad ~/.ssh/id_rsa.pub
para abrir no Bloco de Notas o arquivo que foi criado.

Agora no GitHub, vá em “Settings” e depois “SSH and GPG Keys”. Clique “New SSH key”. Informe um título para identificar o computador onde a a chave foi gerada e no campo “Key” cole todo o conteúdo do arquivo id_rsa.pub (que você abriu no Bloco de Notas)


Tome cuidado de copiar e colar todo o conteúdo do arquivo, começando por “ssh-rsa …” até o seu e-mail (incluindo ele, como na imagem). Clique em “Add Key”.

Vamos testar pra ver se essa bagaça deu certo. No Git Bash digite:

ssh -T git@github.com
Ele vai perguntar se você tem certeza que quer conectar bla bla bla (yes/no). Digite yes e Enter. Na próxima pergunta (Enter passphrase…) informe sua senha (a que você escolheu ao criar a chave SSH).

Se você receber uma mensagem do tipo:

Hi doug2k1! You've successfully authenticated, but GitHub does not provide shell access.
Então tudo deu certo!


2 -  Configurar GIT
 $ git config --global user.name "usuario do git"
 $ git config --global user.email "thiagomilton.f@gmail.com"


3 - Conectar com repositorio Remoto

 $ git remote add origin ENDEREÇO SHH
  obs: "Origin e o nome dado ao remote" 

4 - Clonar repositorio web para o local
 
 $ git clone ENDEREÇO SSH DO PROJETO

 --> Quando nao for meu repositorio tem que fazer o FORK, clicar em fork dentro do git rub  para entrar na colaboraçao. E o projeto vai estar na sua lista de repositorios.

5 - Baixar repositorio especifico
 $ git push origin master
 
 *Clonar o branch especifico INFOXNUVEM
 $ git clone -b infoxnuvem git@github.com:ThiagoMiltonFerreira/Infox.git

 Obs: "origin" nome do push tem nao pode se repetir DA ERRO

6 - Atualizar local com o web. SMP ATUALIZAR AO ABRIR O GIT POIS OUTRO DESENVOLVEDOR PODE TER ALTERADO
 $ git pull





COPIA O BRANCH QUE FOI CRIADO NO GIT(TESTE) PARA O REPOSITORIO LOCAL NA MAQUINA

$ git checkout -t origin/teste
...................................................................................
JA DENTRO DO BRANCH TESTE JA PODE ADD E COMMITAR QUE JA IRA PARA O 
BRAÇO DE TESTE


Erro ao dar enviar push

Enter passphrase for key '/c/Users/Adm/.ssh/id_rsa':
To github.com:ThiagoMiltonFerreira/JavaWeb.git
 ! [rejected]        master -> master (non-fast-forward)
error: failed to push some refs to 'git@github.com:ThiagoMiltonFerreira/JavaWeb.git'
hint: Updates were rejected because the tip of your current branch is behind
hint: its remote counterpart. Integrate the remote changes (e.g.
hint: 'git pull ...') before pushing again.
hint: See the 'Note about fast-forwards' in 'git push --help' for details.

Corrigir este erro
git push -f origin master

colocar meu comit na ponta da ramificaçao
git rebase origin/master

.....................................................................................
Mostrar log de comits 
git log
......................................................................................
Alterar nome da branch
git branch nomeDaBranch

