using System;
using System.Collections.Generic;
using System.Text;

namespace MusicNotes.Models
{
    public abstract class Notes_Base
    {
        protected double Amount;
        protected List<string> lw = new List<string>();
        public Notes_Base(int amount)
        {
            Amount = 1 * amount;
        }

        public abstract void Add(byte quantity);

        public double Rem()
        {
            return Amount;
        }

        public string Write()
        {
            return String.Join(' ', lw);
        }
    }
}
