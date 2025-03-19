# 📋 Sistema de Cadastro Simples e Completo

## 📌 Sobre o Projeto
Este é um sistema desenvolvido em **C# com Windows Forms** no **Visual Studio 2022**, que permite o cadastro de usuários de duas formas:

1️⃣ **Cadastro Simples:** Apenas com Nome e E-mail.
2️⃣ **Cadastro Completo:** Inclui Nome, E-mail, CPF, RG e CEP.

Os dados cadastrados são exibidos em um **DataGridView**, permitindo visualizar os cadastros realizados.

---

## ⚙️ Funcionalidades
✅ Cadastro Simples com Nome e E-mail.  
✅ Cadastro Completo com Nome, E-mail, CPF, RG e CEP.  
✅ Validação de campos obrigatórios (não permite campos vazios).  
✅ Máscaras para CPF, RG e CEP via `MaskedTextBox`.  
✅ Exibição dos cadastros em um **DataGridView**.  
✅ Mensagens de erro e confirmação personalizadas.  
✅ Botão para encerrar o sistema.  

---

## 🛠 Tecnologias Utilizadas
- **C#** (Windows Forms - WinForms)
- **Visual Studio 2022**
- **.NET Framework**
- **Git/GitHub** (para versionamento do código)

---

## 🚀 Como Executar o Projeto

### 🖥️ Pré-requisitos:
- **Visual Studio 2022** (ou versão compatível) instalado.
- .NET Framework instalado.

### 📥 Clonando o Repositório
```sh
# Clone o repositório
$ git clone https://github.com/giaanlucs/Cadastro.git

# Acesse a pasta do projeto
$ cd Cadastro
```

### 🏃‍♂️ Executando o Projeto
1. **Abra o Visual Studio 2022.**
2. **Clique em "Abrir um projeto/solução"** e selecione o arquivo `.sln` do projeto.
3. **Pressione `F5`** ou clique em "Iniciar" para rodar a aplicação.

---

## 📝 Estrutura do Projeto
```
📂 Cadastro
 ┣ 📂 bin/                 # Arquivos compilados
 ┣ 📂 obj/                 # Arquivos temporários
 ┣ 📂 Properties/          # Configurações do projeto
 ┣ 📂 Forms/               # Telas do sistema (Windows Forms)
 ┃ ┣ 📄 FormPrincipal.cs   # Tela principal com o grid de cadastros
 ┃ ┣ 📄 FormCadastro.cs    # Tela do cadastro simples
 ┃ ┣ 📄 FormCadastroCompleto.cs # Tela do cadastro completo
 ┣ 📄 Program.cs           # Ponto de entrada da aplicação
 ┣ 📄 README.md            # Documentação do projeto
 ┗ 📄 Cadastro.sln         # Arquivo de solução do Visual Studio
```

---

## 🛠 Melhorias Futuras
🔹 Implementação de um banco de dados para armazenar os cadastros.  
🔹 Melhorar a interface gráfica com estilos personalizados.  
🔹 Criar um arquivo de log para registrar erros do sistema.  
🔹 Melhorar a validação do CPF para verificar se ele realmente existe (matematicamente).

---

## 🧑‍💻 Autor
👤 **Gianluca Correa**  
📧 Contato: [gianlucs12@outlook.com](mailto:gianlucs12@outlook.com)  
🔗 GitHub: [github.com/giaanlucs](https://github.com/giaanlucs)

---

## 🏆 Licença
Este projeto está sob a licença **MIT**. Sinta-se à vontade para usá-lo e modificá-lo conforme necessário.

---

### ⭐ Se gostou do projeto, deixe uma ⭐ no GitHub!

