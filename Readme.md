# How to use NUnit with F# #

This project is an experiment to show how to run moderately complex NUnit tests
written in F#, using FsUnit and FsCheck. The long term goals are to improve
the documentation and possibly tooling of NUnit, FsUnit, and FsCheck, and also
to drive a project template for F# unit testing. There's a nice template for 
MSTest written by Daniel Mohl, and I'd like to do the same for NUnit, since
FsCheck doesn't seem to support MSTest (another thing to fix!).

#Step by Step#
This is way too much work, but here's the process for now.

## Create Projects and Solution##
1. Create Solution and System Under Test Project
2. Right click Solution in Solution Explorer, Add -> New Project, Visual F# -> Windows -> Library
3. Right click test, project, add reference to system under test project
4. Right click Test project References node, Manage NuGet Packages, add FsUnit

## Write test and method##
5. Write a test in the test project, and a method to test in the system under test project
6. Build

## Run with Visual Studio Test Explorer##
1. If you have not already done so, Tools -> Extensions and Updates, add NUnit Test Adapter
2. Test Explorer, Run All Tests
3. Test should pass

## Run with NUnit##
1. One option is to add a Tools entry as [documented at the NUnit site](http://www.nunit.org/index.php?p=vsSupport&r=2.6.4).
2. However, a better way is to change the Tests project to automatically run the NUnit GUI.
	1. Right click Tests project, Properties, click Debug tab
	2. Change "Start Action" to "Start External Program"
	3. Set external program to NUnit console runner; on my system this is C:\Program Files (x86)\NUnit 2.6.4\bin\nunit-console.exe
	4. Set Command Line Arguments to Your.Test.Project.dll
	5. Now when you run the test project the output will appear in the Visual Studio Output window.
	