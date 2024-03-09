﻿namespace GameIndustry.Models
{
    public class AppStyle
    {
        public string Color { get; set; } = "red";
        public string Size { get; set; } = "65px";

        public List<string> WitcherWords { get; set; } = new List<string>()
        {
            new string("Видишь ли, эльфийская красота - она как молодое вино из Боелкра. А я как-то больше по водке."),
            new string("Ты чудесно пахнешь на этих похоронах."),
            new string("Хочешь меня на хер послать? Милости просим.")
        };
    }
}