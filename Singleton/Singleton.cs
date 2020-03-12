﻿using System;

namespace Singleton
{
    public sealed class Singleton
    {
        public string Mensaje { get; set; }

        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance => lazy.Value;

        private Singleton()
        {
            Console.WriteLine("AAAAAAA");
        }
    }
}
