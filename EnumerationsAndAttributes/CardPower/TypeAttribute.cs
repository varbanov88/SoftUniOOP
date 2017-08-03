﻿using System;

namespace CardPower
{
    public class TypeAttribute : Attribute
    {
        private string type;

        public TypeAttribute(string category, string description)
        {
            this.type = "Enumeration";
            this.Category = category;
            this.Description = description;
        }

        public string Type => this.type;

        public string Category { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}";
        }
    }
}