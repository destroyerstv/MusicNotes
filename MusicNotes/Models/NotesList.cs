using System;
using System.Collections.Generic;
using System.Text;

namespace MusicNotes.Models
{
    class NotesList
    {
        private int Amount;
        private byte Quantity;
        private int Beats;

        Notes_Base[] arrNotes;

        public NotesList(int amount, byte quantity, int beats)
        {
            Amount = amount;
            Quantity = quantity;
            Beats = beats;

            switch (Quantity)
            {
                case 1:
                    arrNotes = new Notes1[Beats];
                    break;
                case 2:
                    arrNotes = new Notes1_2[Beats];
                    break;
                case 4:
                    arrNotes = new Notes1_4[Beats];
                    break;
                case 8:
                    arrNotes = new Notes1_8[Beats];
                    break;
                case 16:
                    arrNotes = new Notes1_16[Beats];
                    break;
                default:
                    throw new Exception("Размер ноты может быть равен: 1, 2, 4, 8, 16");
            }
        }

        public void AddNote(byte note)
        {
            int ind = Beats - 1;
            if (arrNotes[ind] == null)
            {
                switch (Quantity)
                {
                    case 1:
                        arrNotes[ind] = new Notes1(Amount);
                        break;
                    case 2:
                        arrNotes[ind] = new Notes1_2(Amount);
                        break;
                    case 4:
                        arrNotes[ind] = new Notes1_4(Amount);
                        break;
                    case 8:
                        arrNotes[ind] = new Notes1_8(Amount);
                        break;
                    case 16:
                        arrNotes[ind] = new Notes1_16(Amount);
                        break;
                }
            }
                
            arrNotes[ind].Add(note);
        }

        public void CheckBeat()
        {
            if (Beats > 0)
            {
                int ind = Beats - 1;
                if (arrNotes[ind].Rem() != 0.0)
                    throw new Exception("Нарушен такт");

                Beats--;
            }
        }

        public void Write()
        {
            for(int i = arrNotes.Length - 1; i > -1; i--)
            {
                Console.Write(arrNotes[i].Write() + "|");
            }
        }
    }
}
