# ProjetImmobilly

## Ouverture du projet
Ouvrez le fichier *ProjetImmobilly.sln* avec Microsoft Visual Studio.

## Connexion à la base de données
Afin de pouvoir se connecter à votre base de données locale, il faut modifier le fichier *App.config*.

La section suivante figure dans le fichier *App.config* : 

 `<connectionStrings>
    <add name="Immobilly_Groupe_SolveigEntities" connectionString="metadata=res://*/BaseImmobillyModel.csdl|res://*/BaseImmobillyModel.ssdl|res://*/BaseImmobillyModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=INFO-GUILLOT\SQLEXPRESS;initial catalog=Immobilly_Groupe_Solveig;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient"/>
  </connectionStrings>`
  
  Elle représente la connexion à votre base de données.
  
  Ici, seul le nom de votre machine va changer, car le nom de la base de données (*Immobilly_Groupe_Solveig*) et celui de l'instance SQL Server (*SQLEXPRESS*) est identique sur tous nos PC.
  
  `data source=INFO-GUILLOT\SQLEXPRESS;`
  
  Il suffit donc de modifier le nom de la machine. Ici, le nom de ma machine est *INFO-GUILLOT*.
  La connexion à votre base de données locale doit être opérationnelle maintenant.
