using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApp.Entity;

namespace MusicApp.Service
{
    interface ISongService
    {
        Song PostSongFree(Song song);

        ObservableCollection<Song> GetFreeSongs();
    }
}
