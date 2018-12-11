Run tests in Visual Studio:
1. Open 'Kraftvaerk' solution.
2. Rebuild it.
3. Open Test->Windows->Test Explorer
4. Select tests->Run Selected Tests

Run tests in console:
1. Open cmd.exe
2. Command: cd [Your Directories]\NUnit.ConsoleRunner.3.9.0\tools
3. Command: nunit3-console.exe "[Your Directories]\Kraftvaerk\GoogleTest\bin\Debug\GoogleTest.dll" 
(if there is no such dll you shoud rebuild the solution)
4. Test results will be displayed in console and will be saved in TestResult.xml file (in directory of nunit3-console.exe).