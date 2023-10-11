# SistemaDeVendas.WEB
Executavél do sistema

# SistemaDeVendas.Entity
Contém todas as entidades do sistema

# SistemaDeVendas.IOC



# SistemaDeVendas.BLL
Contém todos dados de negócios
The business-logic layer is a crucial component of a software application that handles the processing of data and implementation of business rules. It sits between the UI and data access layers and helps to improve the modularity, security, and performance of the application.




# SistemaDeVendas.DAL
Contém todos acessos aos dados


# SistemaDeVendas.IOC 
Contém aos dados da Inversão de controle e as dependencias do projeto

Inversão de controle ou Inversão de controlo é um princípio de design de programas de computadores onde a sequência de chamadas dos métodos é invertida em relação à programação tradicional, ou seja, ela não é determinada diretamente pelo programador

O que é a Inversão de Controle (IoC)?
Basicamente, a Inversão de Controle é uma forma diferente que temos para manipular o controle sobre um objeto. É um padrão. Gosto de pensar na Inversão de Controle como sendo a mudança de conhecimento que uma classe tem em relação à outra.

Gosto de ver um trecho teórico com um trecho de código, então vamos ver desta forma!

Vamos imaginar uma classe bem simples, onde precisamos gravar um Log em um arquivo após Vender um Produto. Então podemos ter a seguinte classe bem simples:


Inversão de Controle ou Inversion of Control - conhecido pela Sigla IoC é um Pattern que prega para usarmos o controle das instancias de uma determinada classe ser tratada externamente e não dentro da classe em questão, ou seja, Inverter o controle de uma classe delegando para uma outra classe, interface, componente, serviço, etc.

Read more: http://www.linhadecodigo.com.br/artigo/3418/inversao-de-controle-ioc-e-injecao-de-dependencia-di-diferencas.aspx#ixzz8Dsq99Opm









# Correçãõ de Errrooo!!!
InvalidOperationException: The view 'Index' was not found. The following locations were searched: /Views/Dashboard/Index.cshtml /Views/Shared/Index.cshtml
Encontrei o mesmo problema quando migrei um aplicativo MVC do .NET 5 para o 7. Embora funcionasse perfeitamente na versão 5, as versões 6 e 7 apresentaram um problema na forma de um , afirmando especificamente InvalidOperationException:The view 'Index' could not be located. The following locations were searched.

Esse problema surge de um problema conhecido relacionado às visualizações do ASP.NET Core 6 e 7 Razor, decorrente de alterações na forma como as visualizações do Razor são compiladas.

Para resolver esse problema, tive que incorporar o Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilationpacote ao meu projeto.
Além disso, precisei modificar minha configuração MVC de:

services.AddControllersWithViews();
para:

services.AddControllersWithViews().AddRazorRuntimeCompilation();
Feitos esses ajustes, tudo começou a funcionar corretamente.







Comando Entity Framework para instalar o complementos do entity

Scaffold-DbContext "Server=DESKTOP-RL96SQL;DataBase=VENDASNETCORE;Integrated Security=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer


Corrigir erro: TrustServerCertificate=True"
A connection was successfully established with the server, but then an error occurred during the login process. (provider: SSL Provider, error: 0 - A cadeia de certificação foi emitida por uma autoridade que não é de confiança.)



PM> Scaffold-DbContext "Server=DESKTOP-RL96SQL;DataBase=VENDASNETCORE;Integrated Security=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer

Build started...
Build succeeded.
To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.


Obs: Para o comando do Scaffold-DbContext funcionar o projeto em questão precisa esta setado como inicial



# Passo 01 - Copiando os modelos de CSS e HTML para a pasta wwwroot do executavél web.

Entra na pasata (C:\Workspace\SistemaDeVendasNetCoreSqlServer\Suporte\Modelos Bootstrap\Modelos Bootstrap_001) e copiar as pastas css, img, js, scss e vendor


# Passo 02 - Copiando os dados do arquivo HTML "vazio.html", e substitue os dados do _layout.cshtml
Entra na pasata (C:\Workspace\SistemaDeVendasNetCoreSqlServer\Suporte\Modelos Bootstrap\Modelos Bootstrap_001)



# Passo 03 - Copiando os dados do arquivo HTML "index.html" apenas a div class="container-fluid, incluei no dashborad index
Entra na pasata (C:\Workspace\SistemaDeVendasNetCoreSqlServer\Suporte\Modelos Bootstrap\Modelos Bootstrap_001)




# Passo 04 - Copiando os dados do arquivo HTML "usuarios.html" apenas a div class="container-fluid, incluei no dashborad index
Entra na pasata (C:\Workspace\SistemaDeVendasNetCoreSqlServer\Suporte\Modelos Bootstrap\Modelos Bootstrap_001)


Fazer o mesmo procedimento acima para categoria, negocio e produto!!!!


Obs: A pagina de perfil criar no Controlador"Home")">












https://www.youtube.com/watch?v=E1lpR8IqaEQ&list=PLx2nia7-PgoDbCAY2nGXAcIl_zkQKA2Ap&index=4

25:54 / 40:07
















