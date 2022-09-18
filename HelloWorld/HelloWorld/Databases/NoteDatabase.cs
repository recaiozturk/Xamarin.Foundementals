using HelloWorld.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Databases
{


    public class NoteDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public NoteDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            //wait ile tablonun oluşturulduktan sonra dewam edilmesini sağlıyoruz
            _database.CreateTableAsync<Note>().Wait();
        }
        
        public Task<List<Note>>  GetNotesAsync()
        {
            return _database.Table<Note>().ToListAsync();
        }

        public Task<int> SaveNoteAsync(Note note)
        {
            if(note.Id != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }

            
        }

        public Task<int> DeleteNoteAsync(Note note)
        {
            return _database.DeleteAsync(note);
        }



    }
}
