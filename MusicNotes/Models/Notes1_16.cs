using System;
using System.Collections.Generic;
using System.Text;

namespace MusicNotes.Models
{
    public class Notes1_16 : Notes_Base
    {
        public Notes1_16(int amount) : base(amount) { }

        public override void Add(byte quantity)
        {
            if(quantity != 16)
                throw new Exception("Размер ноты может быть равен: 16");


            if (Amount > 0)
            {
                lw.Add("16");
                Amount--;
            }
            else
                throw new Exception("Нота не помещается");
        }
    }
}
