__Intro to MEF - Part 4__

In Part 4 in my series Intro to MEF we take a look at Method Exports.

```cs
[Export(typeof(Action<string>))]
public void Send(string message)
{
    Console.WriteLine("ConsoleMessageSender: " + message);
}

[Import(typeof(Action<string>))]
public Action<string> MessageSender { get; set; }
```
