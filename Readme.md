# Eto.Rx

Reactive extensions for [Eto](https://github.com/picoe/Eto) (adds observables for Eto events.)

Example:

```csharp
new TextBox().Events().KeyUp
    .Select(k => k.KeyData)
    .Where(k => k == (Keys.Control | Keys.C))
    .Subscribe(k => Console.WriteLine("'Control + C' was pressed"));
```

Generated using [ReactiveUI EventBuilder](https://github.com/reactiveui/ReactiveUI/tree/develop/src/EventBuilder)

## Usage

1. Copy [Eto.Rx.cs](Eto.Rx.cs) file to your project.
2. Add `Eto.Forms` and `System.Reactive.Linq` nugets to your project