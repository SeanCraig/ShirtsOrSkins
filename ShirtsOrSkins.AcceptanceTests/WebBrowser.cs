﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace ShirtsOrSkins.AcceptanceTests
{
    [Binding]
    public class WebBrowser
    {
        public static Browser Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("browser"))
                {
                    ScenarioContext.Current["browser"] = new IE();
                }
                return (Browser) ScenarioContext.Current["browser"];
            }
        }

        [AfterScenario]
        public static void Close()
        {
            if (ScenarioContext.Current.ContainsKey("browser"))
            {
                Current.Close();
            }
        }
    }
}
