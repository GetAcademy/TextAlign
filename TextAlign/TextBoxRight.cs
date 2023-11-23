namespace TextAlign
{
    internal class TextBoxRight
    {
        private string _text;

        public TextBoxRight(string text)
        {
            _text = text;
        }

        public void Show(int startX, int startY, int width, int height)
        {
            var borderChar = '\u2588';
            var border = string.Empty.PadLeft(width, borderChar);
            Write(border, startX, startY);
            Write(border, startX, startY + height);
            WriteVertical(borderChar, startX, startY + 1, height - 1);
            WriteVertical(borderChar, startX + width - 1, startY + 1, height - 1);
            var words = _text.Split(' ');
            var x = startX + 2;
            var y = startY + 1;
            var maxX = startX + width - 2;
            var maxY = startY + height - 1;
            foreach (var word in words)
            {
                if (x + word.Length > maxX)
                {
                    y++;
                    if (y > maxY) break;
                    x = startX + 2;
                }
                Write(word, x, y);
                x += word.Length + 1;
            }
        }

        private static void Write(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }

        private static void WriteVertical(char letter, int x, int y, int count)
        {
            for (var i = 0; i < count; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(letter);
            }
        }
    }
}
