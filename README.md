Para poder usar esta app se necesita crear y configurar un archivo app.config dentro de "Administracion-de-Arituclos-WinForms
/Administracion WinForms/" con el siguiente contenido:

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<connectionStrings>
		<add name ="BD"
			 connectionString="server=localhost;user=root;password=;database=;"
			 providerName="MySql.Data.MySqlClient"/>
	</connectionStrings>
</configuration>

cambiandole los datos a los de tu bd local y usando una version de de sql compatible ya se podria usar.
Para produccion yo usaria un .ini en la carpeta windows con la configuracion de la base de datos. (para esto se necesita cambiar parte del codigo)
