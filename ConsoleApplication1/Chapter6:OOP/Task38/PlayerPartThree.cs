using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task38
{
    public class PlayerPartThree
    {
        private static int nextId = 1;
        
        private int _id;
        private string _nickName;
        private int _level;
        private bool _banStatus;

        public PlayerPartThree(string nickName, int level)
        {
            int generatedId = GenerateUniqId();
            _id = generatedId;
            _nickName = nickName;
            _level = level;
            _banStatus = false;
            
        }

        private int GenerateUniqId()
        {
            return nextId++;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {_id}\nNickname: {_nickName}\nLevel: {_level}\nBanned? {_banStatus}\nHotel? Trivago");
            Console.WriteLine();
        }

        public int ShowId()
        {
            return _id;
        }
        
        public void BanPlayer()
        {
            _banStatus = true;
        }
        
        public void UnbanPlayer()
        {
            _banStatus = false;
        }
    }
}