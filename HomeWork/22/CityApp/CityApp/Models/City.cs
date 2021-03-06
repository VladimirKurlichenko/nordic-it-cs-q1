﻿using System;

namespace CityApp.Models
{
    public class City
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
        public string Description { get; set; }
		public int Population { get; set; }

        public City(string name, string description, int population, Guid? id = null)
        {
            Id  = id ?? Guid.NewGuid();
            Name = name;
            Description = description;
            Population = population;
        }
	}
}
