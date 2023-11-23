using TextAlign;

var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ";

var textBoxLeft = new TextBoxLeft(text);
var textBoxRight = new TextBoxRight(text);
var textBoxCenter = new TextBoxCenter(text);

textBoxLeft.Show(0, 0, 30, 10);
textBoxRight.Show(32, 0, 30, 10);
textBoxCenter.Show(64, 0, 30, 10);

Console.SetCursorPosition(0, 12);
