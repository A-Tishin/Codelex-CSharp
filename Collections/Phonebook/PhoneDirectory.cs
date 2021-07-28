using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _userNums = new SortedDictionary<string, string>();

        public PhoneDirectory(string firstUser, string firstNum) {
            _userNums.Add(firstUser, firstNum);
        }

        private bool Find(string name)
        {
            return _userNums.ContainsKey(name);
        }

        public string GetNumber(string name)
        {
            return _userNums[name];
        }

        public void PutNumber(string name, string number) 
        {
            if (Find(name))
            {
                _userNums[name] = number;
            }
            else 
            {
                _userNums.Add(name, number);
            }
        }
    }
}