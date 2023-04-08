using System;

namespace WavingMan
{
    public class RightHandedMan : Man
    {
        public RightHandedMan(int x, int y, int dx, int dy) : base(x, y, dx, dy) { }

        public override void Show()
        {
            SetCursorTop();
            SetCursorLeft();
            Console.WriteLine(_shouldWaveNextTime ? " o/" : " o");
            SetCursorLeft();
            Console.WriteLine(_shouldWaveNextTime ? "/|" : " |");
            SetCursorLeft();
            Console.Write("/ \\");
            _shouldWaveNextTime = !_shouldWaveNextTime;
        }
    }
}