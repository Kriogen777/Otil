using OpenHardwareMonitor.Hardware;
using System.Collections.Generic;
using System.Management;
using System.Threading;
using System.Timers;

namespace AIOSystemUtility3
{
    public class Scraper
    {
        // Public
        public bool IsFirstScanComplete { get; protected set; }
        public Semaphore Lock = new Semaphore(1, 1);

        // Protected
        // Searcher
        protected ManagementObjectSearcher searcher;
        protected Computer computerHardware = new Computer();
        protected System.Timers.Timer Update = new System.Timers.Timer(500);
        protected List<IVisitor> Visitors = new List<IVisitor>();
        
        // Public Methods

        /// <summary>
        /// Register a Visitor to update after each scan completes
        /// </summary>
        public void RegisterVisitor(IVisitor V)
        {
            Visitors.Add(V);
        }

        /// <summary>
        /// Stops the scraper from updating
        /// </summary>
        public void StopScraping()
        {
            Update.Stop();
            Update.Dispose();/*
            try
            {
                computerHardware.Close();
            }
            catch(System.Exception e){
                Console.WriteLine(e.StackTrace);
            }*/
        }

        // Private Methods

        /// <summary>
        /// Updates each of its Visitor objects
        /// </summary>
        protected void UpdateVisitors()
        {
            foreach (IVisitor V in Visitors)
            {
                V.Update(this);
            }
        }

        /// <summary>
        /// Called on Update Elapsed event
        /// </summary>
        protected void Update_Elapsed(object sender, ElapsedEventArgs e)
        {
            UpdateVisitors();
        }

        protected Scraper()
        {
            IsFirstScanComplete = false;
            Update.Elapsed += Update_Elapsed;
            // Set so elapsed threads don't queue up and make form wait until complete to close
            Update.AutoReset = false;
            Update.Start();
        }     
    }
}
