# Blazor WebAssembly - Primeros pasos
Material relacionado con el curso de Blazor WebAssembly - Primeros pasos impartido en CPIC (modalidad virtual) en Marzo 2023.

### Requerimientos de software
1.	Requisitos mínimos del hardware que ocupamos.<br/> 
	https://docs.microsoft.com/en-us/visualstudio/releases/2022/system-requirements
	
2.	Microsoft SQL Server 2008 R2 o superior.<br/> 
	https://www.microsoft.com/en-us/sql-server/sql-server-downloads
	Se acostumbra a utilizar la edición Express, en SQL Server 2017 para desarrollo es posible utilizar la edición Developer.	
	
3.	Microsoft Visual Studio 2022 (edición Community o superior)<br/>
	https://www.visualstudio.com/downloads/<br/>
	https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2022#install-workloads
	
	Aquí se documenta como obtener los instaladores para la instalación local, 
	https://docs.microsoft.com/en-us/visualstudio/install/create-a-network-installation-of-visual-studio?view=vs-2022, 
	esto baja todos los “workloads” pero al momento de instalar no se deben de instalar todos.
	
	Si el Visual Studio 2022 ya se encuentra instalado se puede utilizar el Visual Studio Installer, 
	para efectuar la actualización.

	Se deben instalar al menos los “workloads”: 
	- ASP.NET and web development
		
	En caso de contar con una instalación del Visual Studio 2022, proceder con la actualización a la última versión, 
	y confirmar que se tengan instalados los “workloads” señalados en el punto anterior. Esto se hace ejecutando el 
	Visual Studio Installer, y aplicar en el equipo la actualización cuando aparece el botón “Update”, es solo de 
	aplicarlo y esperar que finalice.
 
	Se puede confirmar el resultado con el “Acerca de” de Visual Studio 2022.
	
4.	Internet Information Services habilitado 
	http://technet.microsoft.com/en-us/library/cc731911.aspx
	
5.	Navegadores Web actualizados a la última versión. 
	- https://www.mozilla.org/en-US/firefox/
	- https://www.google.com/chrome/index.html
	- https://www.microsoft.com/en-us/edge

6. Postman
	- https://www.getpostman.com/apps	
	
De ser posible efectuar la instalación de las versiones del software con el idioma inglés, para unificar con la configuración utilizada por el profesor.

### Bases de datos de ejemplo
* https://github.com/Microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs
