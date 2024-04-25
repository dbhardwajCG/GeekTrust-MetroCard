using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GeekTrust
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] inputData = File.ReadAllLines(args[0]);
                List<string> inputDataAsString = inputData.ToList<string>();
                inputDataAsString.ForEach(processCommand);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
        public static string processedCommandOutput(string command)
        {
            return command;
        }
        public static void processCommand(string commandWithData)
        {
            string command = commandWithData.Split(" ").ToList<string>().First();
            List<string> arguments = commandWithData.Trim().Split(" ").ToList<string>().Skip(1).ToList<string>();
            processCommandWithData(command, arguments);
        }
        public static void processCommandWithData(string command, List<string> arguments)
        {

        }
        public enum Commands
        {
            BALANCE,
            CHECK_IN,
            PRINT_SUMMARY
        }

        private IDictionary<Commands, Action> Mapping = new Dictionary<Commands, Action>
        {
            { Commands.BALANCE, () => { /* Action 1 */ } },
            { Commands.CHECK_IN, () => { /* Action 2 */ } },
            { Commands.PRINT_SUMMARY, () => { /* Action 3 */ } }
        };

        public void HandleEnumValue(Commands enumValue)
        {
            if (Mapping.ContainsKey(enumValue))
            {
                Mapping[enumValue]();
            }
        }

        public MetroCard debit_metro_card(MetroCard metroCard, int amount)
        {
            if (metroCard.isValidBalance(amount))
            {
                return metroCard;
            }
            return new MetroCard(metroCard.card_id, metroCard.balance - amount);
        }
        public MetroCard credit_metro_card(MetroCard metroCard, int amount)
        {
            return new MetroCard(metroCard.card_id, metroCard.balance + amount);
        }
        public MetroCard deduct_travel_fare(MetroCard metroCard, int fare)
        {
            return new MetroCard(metroCard.card_id, metroCard.balance - fare);
        }
    }
    public enum Commands
    {
        
    }
    class MetroCard
    {
        public string card_id;
        public int balance;
        public Journey[] journey;
        public MetroCard(string card_id, int balance)
        {
            this.card_id = card_id;
            this.balance = balance;
        }
        public bool isValidBalance(int amount)
        {
            return balance < amount;
        }
    }
    class Journey
    {
        public string from_station;
        public string to_station;
    }
 
}
