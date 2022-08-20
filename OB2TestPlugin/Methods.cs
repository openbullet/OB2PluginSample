using CalculatorLib;
using RuriLib.Attributes;
using RuriLib.Logging;
using RuriLib.Models.Blocks.Settings;
using RuriLib.Models.Bots;
using System;

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

namespace OB2TestPlugin.Blocks.Images
{
    [BlockCategory("Images", "Blocks that allow to work with images", "#ffae42")]
    public static class Methods
    {
        [BlockAction("ImageTest")]
        public static void SayHello(RuriLib.Models.Blocks.BlockInstance block)
        {
            block.Settings["str"].InputMode = SettingInputMode.Fixed;
            block.GetFixedSetting<StringSetting>("str").Value = "edited";
        }

        [BlockAction("ImageTest")]
        public static void SayGoodbye(RuriLib.Models.Blocks.BlockInstance block)
        {
            var imageSize = block.Descriptor.Images["myImage"].Value?.Length ?? 0;
            block.Settings["size"].InputMode = SettingInputMode.Fixed;
            block.GetFixedSetting<IntSetting>("size").Value = imageSize;
            (block as RuriLib.Models.Blocks.AutoBlockInstance).Safe = true;
        }

        [Block("Image attribute test")]
        [BlockImage("myImage")]
        public static void ImageTest(BotData data, string str, int size)
        {
            data.Logger.LogHeader();
            data.Logger.Log($"The string says: {str}", LogColors.YellowOrange);
            data.Logger.Log($"The image size is: {size}", LogColors.YellowOrange);
        }
    }
}
