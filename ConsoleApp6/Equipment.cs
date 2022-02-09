using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Equipment
    {
        private string _nameGroup;
        private string _stamp;
        private int _readyDate;
        private bool _stateOfReadiness;

        public Equipment(string nameGroup, string stamp, int readyDate, bool stateOfReadiness)
        {
            _nameGroup = nameGroup;
            _stamp = stamp;
            _readyDate = readyDate;
            _stateOfReadiness = stateOfReadiness;
        }

        public string nameGroup { get => _nameGroup; set => _nameGroup = value; }
        public string stamp { get => _stamp; set => _stamp = value; }
        public int readyDate { get => _readyDate; set => _readyDate = value; }
        public bool stateOfReadiness { get => _stateOfReadiness; set => _stateOfReadiness = value; }

        public override string ToString()
        {
            return _nameGroup + ", " + _stamp + ", " + _readyDate + ", " + _stateOfReadiness;
        }
    }
}
