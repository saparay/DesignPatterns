using FlyweightDesignPatternRealTimeExample;

var editor = new TextEditor();

editor.InsertCharacter('A', 0, "Arial", 12, true, false);
editor.InsertCharacter('B', 1, "Arial", 12, true, false);
editor.InsertCharacter('C', 2, "Times New Roman", 14, false, true);

editor.DisplayDocument();

Console.ReadKey();