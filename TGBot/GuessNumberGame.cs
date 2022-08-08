using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMyTelegrammBot
{
    internal class GuessNumberGame
    {
        private int balance;
        private int clickValue;
        private int UpgradeValue;


        private void Init()
        {
            clickValue = 1;
            UpgradeValue = 10;
        }

        private void Upgrade()
        {
            balance = balance - UpgradeValue;
            clickValue++;
            UpgradeValue = UpgradeValue * 2;
        }

        private void Click()
        {
            balance = balance + clickValue;
        }

        private void 

        public string ProcessMessage(string messageText)
        {
            switch(messageText)
            {
                case "/start":
                    return "бот работает, заебись";
                case "/click":
                    Click();
                    return $"+клик, ваш баланс {balance}";


            }
           
        }
    }
}




