using MusicNotes.Models;
using System;


namespace MusicNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] amount_quantity = str.Split('/');
            string strNotes = Console.ReadLine();
            string[] tacts = strNotes.Split('|');

            int amount = Convert.ToInt32(amount_quantity[0]);
            byte quantity = Convert.ToByte(amount_quantity[1]);
            
            NotesList notesList = new NotesList(amount, quantity, tacts.Length - 1);

            string[] notes;

            try
            {

                for (int i = 0; i < tacts.Length - 1; i++)
                {
                    notes = tacts[i].Split(' ');

                    if (i != 0)
                        notesList.CheckBeat();

                    for (int j = 0; j < notes.Length; j++)
                    {
                        notesList.AddNote(Convert.ToByte(notes[j]));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }

            notesList.Write();
            Console.ReadKey();
        }
    }
}
