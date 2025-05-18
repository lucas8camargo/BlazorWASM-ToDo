# Blazor WebAssembly no GitHub Pages
Este é um projeto de demonstração de uma aplicação Blazor WebAssembly hospedada no GitHub Pages.

## Sobre
Este projeto demonstra como uma aplicação .NET (8.0) pode ser executada diretamente no navegador usando WebAssembly (WASM) e hospedada gratuitamente no GitHub Pages. A aplicação é compilada para WebAssembly, permitindo que código C# seja executado no navegador sem necessidade de um servidor back-end.

## Demonstração Online
https://lucas8camargo.github.io/BlazorToDoWASM/

Esse é o código-fonte do projeto sem as modificações necessárias para utilizar o GitHub Pages. Para o código modificado que está online acesse o link abaixo:
https://github.com/lucas8camargo/BlazorToDoWASM

## Como utilizar o GitHub Pages em um projeto Blazor WASM

Primeiro, você precisa configurar seu projeto para usar uma URL base que corresponda ao seu repositório GitHub:

Abra seu arquivo wwwroot/index.html e adicione a tag base correta:
```html
<base href="/nome-do-repositorio/" />
```
No arquivo de projeto .csproj, adicione a configuração de URL base:
```xml
<PropertyGroup>
  <BaseHref>/nome-do-repositorio/</BaseHref>
</PropertyGroup>
```
2. Publicar o Projeto
Execute o comando de publicação para gerar os arquivos de distribuição:
```bash
dotnet publish -c Release -o publish
```
3. Configuração do GitHub
Crie um novo repositório no GitHub (ou use um existente)
Clone o repositório localmente
Copie os arquivos da pasta publish/wwwroot para a raiz do repositório

5. Adicionar Arquivos Especiais
Crie um arquivo .nojekyll vazio na raiz do repositório para evitar problemas com o Jekyll do GitHub:

6. Configurar o Roteamento
Crie/copie o arquivo 404.html para a raiz com o mesmo conteúdo do seu index.html para permitir a navegação com rotas:

7. Configurar GitHub Pages
No repositório GitHub, vá para "Settings" > "Pages"
Em "Source", selecione a branch principal (main ou master)
Clique em "Save" e aguarde alguns minutos para que o site seja publicado



