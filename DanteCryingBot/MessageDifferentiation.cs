using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace DanteCryingBot
{
    class MessageDifferentiation
    {
        public static async void messagePicker(string txt, TelegramBotClient bot, long cid, Random rnd, string[] arrayOfQuotes, string[] arrayOfPossiblePhrases, string[] arrayOfPossibleNames, string name)
        {
            txt = txt.ToUpper();
            if (txt.Contains("I NEED YOUR HELP BOT") || txt.Contains("BEAT THIS DUDE UP") ||
                    txt.Contains("MY BOT WILL FUCK YOUR WIFE") || txt.Contains("BOOTY"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, arrayOfQuotes[rnd.Next(0, arrayOfQuotes.Length - 1)]);
            }

            if (txt.Contains("DANTE"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, arrayOfQuotes[2]);
            }

            if (txt.Contains("TRISH"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, arrayOfQuotes[1]);
            }

            if (txt == "/HELP")
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, String.Join(System.Environment.NewLine, arrayOfPossiblePhrases));
            }

            if (txt == "/NAMES")
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, String.Join(System.Environment.NewLine, arrayOfPossibleNames));
            }

            if (txt.Contains("CELL"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, arrayOfQuotes[5]);
            }
            if (txt.Contains("BACK ME UP BOT") || txt.Contains("FUCK YOU"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, arrayOfQuotes[11]);
            }
            if (txt.Contains("FATHER"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "Bottom text");
            }
            if (txt.Contains("GAMERS RISE UP"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, arrayOfQuotes[13]);
            }
            if (txt.Contains("YU"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "Up and at 'em");
            }
            if (txt.Contains("RUBY"))
            {
                using (Stream stream = System.IO.File.OpenRead("Ruby.jpg"))
                {
                    if(name.Contains("Ana") || name.Contains("Tamir"))
                    {
                        var fileToSendOff = await bot.SendTextMessageAsync(cid, "I wont lose to anyone! EVER!");
                    } else
                    {
                        var fileToSend = await bot.SendPhotoAsync(cid, stream, "I wont lose to anyone! EVER!");
                    }
                    
                }
            }
            if (txt.Contains("NU 13"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "RAGNA!!!");
            }
            if (txt.Contains("BLAKE"))
            {
                using (Stream stream = System.IO.File.OpenRead("Blake.jpg"))
                {
                    if (name.Contains("Ana") || name.Contains("Tamir"))
                    {
                        var fileToSendOff = await bot.SendTextMessageAsync(cid, "Deadly NIGHTSHADE!");
                    } else
                    {
                        var fileToSend = await bot.SendPhotoAsync(cid, stream, "Deadly NIGHTSHADE!");
                    }
                    
                }
            }
            if (txt.Contains("YANG"))
            {
                using (Stream stream = System.IO.File.OpenRead("Yang.jpg"))
                {
                    if (name.Contains("Ana") || name.Contains("Tamir"))
                    {
                        var fileToSendOff = await bot.SendTextMessageAsync(cid, "Time to go out with a YANG!");
                    } else
                    {
                        var fileToSend = await bot.SendPhotoAsync(cid, stream, "Time to go out with a YANG!");
                    }
                    
                }
            }
            if (txt.Contains("BARDOCK"))
            {
                using (Stream stream = System.IO.File.OpenRead("Bardock.jpg"))
                {
                    if (name.Contains("Ana") || name.Contains("Tamir"))
                    {
                        var fileToSendOff = await bot.SendTextMessageAsync(cid, "I'll be sure to visit your grave!");
                    } else
                    {
                        var fileToSend = await bot.SendPhotoAsync(cid, stream, "I'll be sure to visit your grave!");
                    }
                    
                }
            }
            if (txt.Contains("VEGETA"))
            {
                using (Stream stream = System.IO.File.OpenRead("Vegeta.jpg"))
                {
                    if (name.Contains("Ana") || name.Contains("Tamir"))
                    {
                        var fileToSendOff = await bot.SendTextMessageAsync(cid, arrayOfQuotes[6]);
                    } else
                    {
                        var fileToSend = await bot.SendPhotoAsync(cid, stream, arrayOfQuotes[6]);
                    }
                    
                }
            }
            if (txt.Contains("WOW"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "That's INSANE!");
            }
            if (txt.Contains("KANJI"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "YA WANT SOME??");
            }
            if (txt.Contains("SHUT UP"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "No u");
            }
            if (txt.Contains("GOOD JOB"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "Thanks!");
            }
            if (txt.Contains("SHH"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "sorry");
            }
            if (txt.Contains("MAN I'M BORED"))
            {
                var fileToSend = await bot.SendGameAsync(cid, @"RPSSimulator");
            }
            if (txt.Contains("THANKS BOT"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "No problem!");
            }
            if (txt.Contains("YOU'R DOING GREAT BOT!"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "Thanks dad!");
            }
            if (txt.Contains("NO U"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "No u");
            }
            if (txt.Contains("HELLO BOT"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "Hello " + name);
            }
            if (txt.Contains("I LOVE YOU BOT") || txt.Contains("LOVE YOU BOT"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "I love you too my dear, " + name);
            }
            if(txt.Contains("MARRY ME BOT"))
            {
                var fileToSend = await bot.SendTextMessageAsync(cid, "Give me a time and place, " + name + "! I'd love too.");
            }
            
        }
    }
}
