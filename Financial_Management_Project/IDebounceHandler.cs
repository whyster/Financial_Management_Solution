using System;
using System.Collections.Generic;
using System.Threading;

namespace Financial_Management_Project {
    public interface IDebounceHandler {
        // public int default_waiter_milli_seconds { get; set; }
        Dictionary<string, Timer> _timers { get; }
        
        // public Debounce_Handler(int default_wait = 600) {
        //     default_waiter_milli_seconds = default_wait;
        //     _timers = new Dictionary<string, Timer>();
        // }

        void Add(string key, EventHandler callback);

        void Change(string key, int? wait_time = null);
    }
}