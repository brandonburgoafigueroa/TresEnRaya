using System;

namespace TresEnRayaCore
{
    public class Cell
    {
        public Cell()
        {
            Value = ' ';
        }
        public int X { get; set; }
        public int Y { get; set; }
        public bool HasValue()
        {
            return Value == ' ';
        }
        public void SetValue(char value)
        {
            this.Value = value;
        }
        public char GetValue()
        {
            return Value;
        }
        private char Value { get; set; }

        public bool IsNotEmpty()
        {
            return this.Value != ' ';
        }
    }
}
