using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class NotesStore
    {
        List<string> activeNotes = new List<string>();
        List<string> completedNotes = new List<string>();
        List<string> otherNotes = new List<string>();

        public NotesStore() { }
        public void AddNote(String state, String name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name cannot be empty");

            if (!isValidState(state))
                throw new Exception("Invalid state "+ state);
            this.getNotesList(state).Add(name);
        }

        private List<string> getNotesList(string state)
        {
            if (state == "active")
                return activeNotes;
            else if (state == "completed")
                return completedNotes;
            else
                return otherNotes;
        }
        public List<String> GetNotes(String state) {
            if (!isValidState(state))
                throw new Exception("Invalid state " + state);

            return this.getNotesList(state);
        }

        private bool isValidState(string state)
        {
            return state == "active"
                || state == "completed"
                || state == "others";
        }
    }
}
