using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher
{
    public class FileWatcher
    {
        private List<EventObject> list;
        private FileSystemWatcher fileSystemWatcher;

        public FileWatcher()
        {
            list = new List<EventObject>();
            fileSystemWatcher = new FileSystemWatcher();
            fileSystemWatcher.Renamed += Renamed;
            fileSystemWatcher.Deleted += Other;
            fileSystemWatcher.Changed += Other;
            fileSystemWatcher.Created += Other;
        }

        private void Renamed(object sender, RenamedEventArgs e)
        {
            list.Add(new EventObject(sender, e, EventType.Renamed));
        }

        private void Other(object sender, FileSystemEventArgs e)
        {
            list.Add(new EventObject(sender, e, EventType.Other));
        }

        public FileWatcher(string path)
        {
            fileSystemWatcher = new FileSystemWatcher(path);
        }

        public FileWatcher(string path, string filter)
        {
            fileSystemWatcher = new FileSystemWatcher(path, filter);
        }

        public bool EnableRaisingEvents
        {
            get { return fileSystemWatcher.EnableRaisingEvents; }
            set { fileSystemWatcher.EnableRaisingEvents = value; }
        }

        private void Renamed()
        {
            
        }
        //public string Filter { get; set; }
        //public bool IncludeSubdirectories { get; set; }
        //public int InternalBufferSize { get; set; }
        //public NotifyFilters NotifyFilter { get; set; }
        //public string Path { get; set; }
        //public override ISite Site { get; set; }
        //public ISynchronizeInvoke SynchronizingObject { get; set; }
        //public event FileSystemEventHandler Changed;
        //public event FileSystemEventHandler Created;
        public event FileSystemEventHandler Deleted;
        //public event ErrorEventHandler Error;
        //public event RenamedEventHandler Renamed;
        //public void BeginInit();
        //protected override void Dispose(bool disposing);
        //public void EndInit();
        //protected void OnChanged(FileSystemEventArgs e);
        //protected void OnCreated(FileSystemEventArgs e);
        //protected void OnDeleted(FileSystemEventArgs e);
        //protected void OnError(ErrorEventArgs e);
        //protected void OnRenamed(RenamedEventArgs e);
        //public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType);
        //public WaitForChangedResult WaitForChanged(WatcherChangeTypes changeType, int timeout);
    }    



}
