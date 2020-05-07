using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс, внутри которого находится список.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список, в котором находится и значение из полей Note
        /// </summary>
        public List<Note> Makenote = new List<Note>();

        public List<Note> SortedList()
        {
            var sortedList = Makenote.OrderBy(note => note.Changed).ToList();
            return sortedList;
        }
        public List<Note> SortedList(NoteCategory notecategory)
        {
            Makenote = Makenote.OrderBy(note => note.Changed).ToList();
            var titles = new List<Note>();
            foreach (var note in Makenote)
            {
                if (notecategory == NoteCategory.All)
                {
                    titles.Add(note);
                }
                else if(note.noteCategory == notecategory)
                { 
                    titles.Add(note);
                }
            }
            return titles;
            //var sortedList2 = Note1.OrderByDescending(note => note.Changed).ToList();
            //return sortedList2;
        }
    }
}
