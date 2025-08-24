# BruhTerminal.API
> Made in about an hour i think?

Easy and leightweight TUI library that can be useful for whipping up quick personal utilities or tool
## How to use
1. Download `BruhTerminal.API.dll` from releases
2. Add a reference to the DLL
## Examples
```csharp
using BruhTerminal.API;

// Creating page content with text wrapping every 2 words
BTAContent content = new BTAContent("This is my page", 2);

// Creating buttons
BTAButton[] buttons = new BTAButton[] { new BTAButton(1, "Enter"), new BTAButton(2, "Exit")};

// Subscribing on button events
buttons[0].Clicked += () => Console.WriteLine("Welcome, dear user!");
buttons[1].Clicked += () => Environment.Exit(0);

// Creating & Running the page
BTAPage page = new BTAPage("This is my page header", content, buttons);
page.Run();

// Output:
// This is my page header
// 
// This is
// my page
//
// [1] Enter
// [2] Exit
// 
// Select an option:
