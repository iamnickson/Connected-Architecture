# Connected-Architecture

Install MySql for visual Studio </br>
https://dev.mysql.com/downloads/windows/visualstudio/ </br>
For older version </br>
https://downloads.mysql.com/archives/visualstudio/ </br>\
Then install connector for .NET framework </br>
https://dev.mysql.com/downloads/connector/net/ </br>

</br>
</br>
Open visual studio and create a new project called DbConnection (As I did) </br>
Tools -> Connect to DataBase -> Select the MySQL Database and complete the form click 'ok' </br>
Right click on the Reference and add reference, go to the MySQL installed folder in your </br>
System volume and select the required in folder v4.5.2 </br>
</br>
Sometimes you may get this error</br>
Error 1 The type or namespace name 'MySql' could not be found (are you missing a using directive or an assembly reference?) F:\MyWorks\DbConnection\DbConnection\Form1.cs 9 7 DbConnection
</br>
To solve this problem download MySql.Data.dll from </br>

https://www.cryptool.org/trac/CrypTool2/export/2020/trunk/AppReferences/x64/MySql.Data.dll </br>
</br>

Right click at File -> Add -> NewFile -> Application Config File </br>

