# Console Display System
A usefull project to display game or other in console

## How to use
- Create a Screen with a specific size
- Create an Element of what you want to display
- Display Element with the Screen

```csharp
Screen screen = new Screen(30, 10);

Element helloWorld = new Element(new string[] {"Hello", "World"},
        new Coordinates(15, 5),
        Animation.Typing, 
        Placement.mid, 
        ConsoleColor.White, 
        ConsoleColor.Black);
        
screen.DisplayElement(helloWorld);
```

## How to use Layers
- Create a Screen with a specific size
- Create a Layer
- Add Elements to the created Layer
- Display Layer with the Screen

```csharp
Screen screen = new Screen(30, 10);
Layer background = new Layer();

background.Add(element1);
background.Add(element2);
background.Add(...);

screen.DisplayLayer(background);
```

## Features
- Layer system
- Multi-lines
- Typing Animation
- Chat system

## TODO Features
- Image to ASCII
- String to ASCII