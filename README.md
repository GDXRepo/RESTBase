# RESTBase

Requires active server (MAMP on Mac or Denver/Apache on Windows) with active MySQL database with the single `translate` table inside. Table SQL:

```sql
CREATE TABLE `translate` (
  `translate_id` int(11) NOT NULL,
  `language_id` int(11) NOT NULL,
  `loctag` varchar(255) COLLATE utf8_bin NOT NULL COMMENT 'Localization tag',
  `value` varchar(1024) COLLATE utf8_bin NOT NULL DEFAULT '<NOT_TRANSLATED>' COMMENT 'Localized value'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
```
You can change database connection settings in `RESTBase.Web/Web.config` file:

```xml
<connectionStrings>
    <add name="ConfigName" connectionString="Server=localhost;Port=MySqlPort;Database=DBName;Uid=root;Pwd=root;" providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```
After that please make sure that your `ConfigName` identifier equals the argument inside `RESTBase.Data.DAL/DB.cs`:

```csharp
public DB() : base("ConfigName") // <-- here
{
			
}
```

Step-By-Step Basics:
* `RESTBase.Data.DAL/DB.cs` - use it for mapping database tables.
* `RESTBase.Data.Models` - place here specific wrapping classes for your database tables.
* `RESTBase.Domain/Services` - place here your data providers called "services", they are proxies to your database.
* `RESTBase.Web/App_Start/WebApiConfig.cs` - add here your services list (dependency injection).
* `RESTBase.Web/Models` - manage your API in/out structures such as requests and responses.
* `RESTBase.Web/Controller` - manage your API routes and call services to operate with a database.
* `RESTBase.Web/App_GlobalResources/AppResources.resx` - manage localization strings such as error messages, texts, etc.
