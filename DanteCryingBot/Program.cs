using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram;

namespace DanteCryingBot
{
    class Program
    {
        static TelegramBotClient bot = new TelegramBotClient("577910577:AAEIrKEU2xbeSul6kKzcm0XiSWT1Im7tUIM");
        static void Main(string[] args)
        {
            bot.StartReceiving();
            bot.OnMessage += Bot_OnMessage;
            Console.ReadLine();
        }

        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == MessageType.Text)
            {
                string armyLove = @"What the fuck did you just fucking say about me, you little bitch? I'll have you know I graduated top of my class in the Navy Seals, and I've been involved in numerous secret raids on Al-Quaeda, and I have over 300 confirmed kills. I am trained in gorilla warfare and I'm the top sniper in the entire US armed forces. You are nothing to me but just another target. I will wipe you the fuck out with precision the likes of which has never been seen before on this Earth, mark my fucking words. You think you can get away with saying that shit to me over the Internet? Think again, fucker. As we speak I am contacting my secret network of spies across the USA and your IP is being traced right now so you better prepare for the storm, maggot. The storm that wipes out the pathetic little thing you call your life. You're fucking dead, kid. I can be anywhere, anytime, and I can kill you in over seven hundred ways, and that's just with my bare hands. Not only am I extensively trained in unarmed combat, but I have access to the entire arsenal of the United States Marine Corps and I will use it to its full extent to wipe your miserable ass off the face of the continent, you little shit. If only you could have known what unholy retribution your little ""clever"" comment was about to bring down upon you, maybe you would have held your fucking tongue. But you couldn't, you didn't, and now you're paying the price, you goddamn idiot. I will shit fury all over you and you will drown in it. You're fucking dead, kiddo.";
                Random rnd = new Random();
                var txt = e.Message.Text;
                string text = txt.ToString().ToUpper();
                var cid = e.Message.Chat.Id;
                var name = e.Message.From.FirstName + " " + e.Message.From.LastName;
                var uid = e.Message.From.Id;
                Console.WriteLine("{0} - {1} : {2}", uid, name, txt);

                var arrayOfQuotes = new string[]
                {
                    "Let's rock baby",
                    "I should’ve been the one to fill your dark soul with light!",
                    "Jackpot.",
                    "This party's getting crazy !",
                    "Don't close your eyes",
                    "YOU AND THE EARTH SHALL BE DESTROYED!!",
                    "YOU COCKY BASTARD!!",
                    "YOU NEED TO BE STOPPED!!",
                    "SAY GOODBYE!!",
                    "This should be fun.",
                    "Kingdom Hearts...IS LIGHT!!",
                    armyLove,
                    "LIQUID",
                    "We live in a society"
               };

                var arrayOfPossiblePhrases = new string[]
                {
                    "I need your help bot!",
                    "Beat this dude up",
                    "My bot will fuck your wife",
                    "booty",
                    "FATHER",
                    "/Names"

                };

                var arrayOfPossibleNames = new string[]
                {
                    "Dante",
                    "Trish",
                    "Vegeta",
                    "Cell",
                    "Yu",
                    "Ruby",
                    "Nu 13",
                    "Blake",
                    "Kanji"
                };

                MessageDifferentiation.messagePicker(text, bot, cid, rnd, arrayOfQuotes, arrayOfPossiblePhrases, arrayOfPossibleNames);
            }
        }
    }
}
