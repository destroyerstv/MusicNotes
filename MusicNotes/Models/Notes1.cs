using System;
using System.Collections.Generic;
using System.Text;

namespace MusicNotes.Models
{
    public class Notes1 : Notes_Base
    {
        public Notes1(int amount) : base(amount) { }

        public override void Add(byte quantity)
        {
            switch (quantity)
            {
                case 1:

                    if (Amount > 0)
                    {
                        if ((Amount - 1) < 0)
                        {
                            throw new Exception("Не хватает места для ноты");
                        }

                        lw.Add("1");
                        Amount--;
                    }
                    else
                        throw new Exception("Нота не помещается");

                    break;

                case 2:

                    if (Amount > 0)
                    {
                        if ((Amount - 0.5) < 0)
                        {
                            throw new Exception("Не хватает места для ноты");
                        }

                        lw.Add("2");
                        Amount -= 0.5;
                    }
                    else
                        throw new Exception("Нота не помещается");

                    break;

                case 4:

                    if (Amount > 0)
                    {
                        if ((Amount - 0.25) < 0)
                        {
                            throw new Exception("Не хватает места для ноты");
                        }

                        lw.Add("4");
                        Amount -= 0.25;
                    }
                    else
                        throw new Exception("Нота не помещается");

                    break;

                case 8:

                    if (Amount > 0)
                    {
                        if ((Amount - 0.125) < 0)
                        {
                            throw new Exception("Не хватает места для ноты");
                        }

                        lw.Add("8");
                        Amount -= 0.125;
                    }
                    else
                        throw new Exception("Нота не помещается");

                    break;

                case 16:

                    if (Amount > 0)
                    {
                        lw.Add("16");
                        Amount -= 0.0625;
                    }
                    else
                        throw new Exception("Нота не помещается");

                    break;

                default:
                    throw new Exception("Размер ноты может быть равен: 1, 2, 4, 8, 16");
            }
        }
    }
}
