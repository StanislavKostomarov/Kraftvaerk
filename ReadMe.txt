Run tests in Visual Studio:
1. Open 'Kraftvaerk' solution in VS2017.
2. Rebuild solution and restore NuGet packages.
3. Open Test->Windows->Test Explorer
4. Select tests->Run Selected Tests

Run tests in console:
1. Open 'Kraftvaerk' solution in VS2017.
2. Rebuild solution and restore NuGet packages.
3. Open cmd.exe
4. Command: cd [Your Directories] Kraftvaerk\packages\NUnit.ConsoleRunner.3.9.0\tools
5. Command: nunit3-console.exe "[Your Directories]\Kraftvaerk\GoogleTest\bin\Debug\GoogleTest.dll" 
6. Test results will be displayed in console and will be saved in TestResult.xml file (in directory of nunit3-console.exe).
