using CalculatorLib;
using RuriLib.Attributes;
using RuriLib.Logging;
using RuriLib.Models.Bots;

namespace OB2TestPlugin.Blocks.Functions
{
    [BlockCategory("Calculator", "Blocks that allow to perform operations on number", "#9acd32")]
    public static class Methods
    {
        [Block("Adds two numbers together")]
        public static int Addition(BotData data, int firstNumber, int secondNumber)
        {
            var sum = Calculator.Add(firstNumber, secondNumber);

            data.Logger.LogHeader();
            data.Logger.Log($"Calculated: {firstNumber} + {secondNumber} = {sum}", LogColors.YellowGreen);
            return sum;
        }
    }
}
