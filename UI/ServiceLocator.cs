using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services;

namespace UI
{
    public class ServiceLocator
    {
        private static ServiceLocator instance;

        private static object lockObject = new object();

        private ServiceLocator() { }

        public static ServiceLocator Instance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ServiceLocator();
                }
                return instance;
            }
        }


        public MainForm MainForm { get; set; }
        public DealService DealService { get; set; }
    }
}
