using System;

namespace NewMenuShell.Views
{
    public abstract class BaseView
    {
        private string Title { get; }
        protected BaseView(string title)
        {
            Console.Clear();
            Title = title;
            Console.Title = Title;
        }
        public abstract void Display();
    }
}