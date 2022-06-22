# .NET MAUI Issue 8168 Error Reproduction

This solution reproduces this error: https://github.com/dotnet/maui/issues/8168

To reproduce follow these steps:

- Download the project
- Open OnesieMobile.sln
- Run the project as Windows App
- On the top right you'll see a time and date, which automatically updates
- Change the actual page, by clicking on the "Settings" navigation button
- The error should occur


Observations:

The line numbers are refering to -> ViewModel -> MainPageViewModel.cs

The error only occurs, when there is more than one item in the list. 
line 81

What seems to cause the crash, is the line 73

But, when set the line 39 to false, which uses the
Thread recursive, the app crashed at this line 66 -> Thread.Sleep()
and only when line 73 is active.
