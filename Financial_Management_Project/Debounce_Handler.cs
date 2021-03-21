using System;
using System.Collections.Generic;
using System.Threading;

namespace Financial_Management_Project {
    
    
    public class Debounce_Handler : IDebounceHandler {
        public int default_waiter_milli_seconds { get; set; }
        public Dictionary<string, Timer> _timers { get; }
        
        public Debounce_Handler(int default_wait = 600) {
            default_waiter_milli_seconds = default_wait;
            _timers = new Dictionary<string, Timer>();
        }

        public void Add(string key, EventHandler callback) {
            Timer _timer = new Timer(p => {
                callback(this, EventArgs.Empty);
            });
            _timers.Add(key, _timer);
        }

        public void Change(string key, int? wait_time = null) {
            _timers[key].Change(wait_time ?? default_waiter_milli_seconds, Timeout.Infinite);
        }
    }
}