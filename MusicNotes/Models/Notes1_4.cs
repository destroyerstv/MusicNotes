using System;
using System.Collections.Generic;
using System.Text;

namespace MusicNotes.Models
{
    public class Notes1_4 : Notes_Base
    {
        public Notes1_4(int amount) : base(amount) { }

        public override void Add(byte quantity)
        {
            switch (quantity)
            {
                case 4:

                    if (Amount > 0)
                    {
                        if ((Amount - 1) < 0)
                        {
                            throw new Exception("Не хватает места для ноты");
                        }

                        lw.Add("4");
                        Amount--;
                    }
                    else
                        throw new Exception("Нота не помещается");

                    break;

                case 8:

                    if (Amount > 0)
                    {
                        if ((Amount - 0.5) < 0)
                        {
                            throw new Exception("Не хватает места для ноты");
                        }

                        lw.Add("8");
                        Amount -= 0.5;
                    }
                    else
                        throw new Exception("Нота не помещается");

                    break;

                case 16:

                    if (Amount > 0)
                    {
                        lw.Add("16");
                        Amount -= 0.25;
                    }
                    else
                        throw new Exception("Нота не помещается");

                    break;

                default:
                    throw new Exception("Размер ноты может быть равен: 4, 8, 16");
            }
        }
    }
}
