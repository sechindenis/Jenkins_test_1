﻿using Task4.Models;

namespace Task4.Elements
{
    public abstract class BaseElement
    {
        private IWebElement _element;
        private By _locator;

        public BaseElement(By locator)
        {
            _locator = locator;
        }

        public BaseElement(IWebElement element)
        {
            _element = element;
        }

        public bool IsDisplayed()
        {
            return GetElement().Displayed;
        }

        public IWebElement GetElement()
        {
            if (_locator != null)
            {
                var wait = new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(ConfigData.Timeout));

                _element = wait.Until(e => Browser.GetDriver().FindElement(_locator));
            }

            return _element;
        }
    }
}