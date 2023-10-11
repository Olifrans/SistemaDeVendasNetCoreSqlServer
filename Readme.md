# SistemaDeVendas.WEB
Executav�l do sistema

# SistemaDeVendas.Entity
Cont�m todas as entidades do sistema

# SistemaDeVendas.IOC



# SistemaDeVendas.BLL
Cont�m todos dados de neg�cios
The business-logic layer is a crucial component of a software application that handles the processing of data and implementation of business rules. It sits between the UI and data access layers and helps to improve the modularity, security, and performance of the application.




# SistemaDeVendas.DAL
Cont�m todos acessos aos dados


# SistemaDeVendas.IOC 
Cont�m aos dados da Invers�o de controle e as dependencias do projeto

Invers�o de controle ou Invers�o de controlo � um princ�pio de design de programas de computadores onde a sequ�ncia de chamadas dos m�todos � invertida em rela��o � programa��o tradicional, ou seja, ela n�o � determinada diretamente pelo programador

O que � a Invers�o de Controle (IoC)?
Basicamente, a Invers�o de Controle � uma forma diferente que temos para manipular o controle sobre um objeto. � um padr�o. Gosto de pensar na Invers�o de Controle como sendo a mudan�a de conhecimento que uma classe tem em rela��o � outra.

Gosto de ver um trecho te�rico com um trecho de c�digo, ent�o vamos ver desta forma!

Vamos imaginar uma classe bem simples, onde precisamos gravar um Log em um arquivo ap�s Vender um Produto. Ent�o podemos ter a seguinte classe bem simples:


Invers�o de Controle ou Inversion of Control - conhecido pela Sigla IoC � um Pattern que prega para usarmos o controle das instancias de uma determinada classe ser tratada externamente e n�o dentro da classe em quest�o, ou seja, Inverter o controle de uma classe delegando para uma outra classe, interface, componente, servi�o, etc.

Read more: http://www.linhadecodigo.com.br/artigo/3418/inversao-de-controle-ioc-e-injecao-de-dependencia-di-diferencas.aspx#ixzz8Dsq99Opm









# Corre��� de Errrooo!!!
InvalidOperationException: The view 'Index' was not found. The following locations were searched: /Views/Dashboard/Index.cshtml /Views/Shared/Index.cshtml
Encontrei o mesmo problema quando migrei um aplicativo MVC do .NET 5 para o 7. Embora funcionasse perfeitamente na vers�o 5, as vers�es 6 e 7 apresentaram um problema na forma de um , afirmando especificamente InvalidOperationException:The view 'Index' could not be located. The following locations were searched.

Esse problema surge de um problema conhecido relacionado �s visualiza��es do ASP.NET Core 6 e 7 Razor, decorrente de altera��es na forma como as visualiza��es do Razor s�o compiladas.

Para resolver esse problema, tive que incorporar o Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilationpacote ao meu projeto.
Al�m disso, precisei modificar minha configura��o MVC de:

services.AddControllersWithViews();
para:

services.AddControllersWithViews().AddRazorRuntimeCompilation();
Feitos esses ajustes, tudo come�ou a funcionar corretamente.







Comando Entity Framework para instalar o complementos do entity

Scaffold-DbContext "Server=DESKTOP-RL96SQL;DataBase=VENDASNETCORE;Integrated Security=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer


Corrigir erro: TrustServerCertificate=True"
A connection was successfully established with the server, but then an error occurred during the login process. (provider: SSL Provider, error: 0 - A cadeia de certifica��o foi emitida por uma autoridade que n�o � de confian�a.)



PM> Scaffold-DbContext "Server=DESKTOP-RL96SQL;DataBase=VENDASNETCORE;Integrated Security=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer

Build started...
Build succeeded.
To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.


Obs: Para o comando do Scaffold-DbContext funcionar o projeto em quest�o precisa esta setado como inicial



# Passo 01 - Copiando os modelos de CSS e HTML para a pasta wwwroot do executav�l web.

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
















