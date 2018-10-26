using System;

namespace NewMenuShell.Views
{
    public abstract class BaseView
    {
        protected BaseView(string title)
        {
            Console.Clear();
            Title = title;
            Console.Title = Title;
        }

        private string Title { get; }
        public abstract void Display();
    }
}