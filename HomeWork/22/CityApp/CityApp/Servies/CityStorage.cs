using CityApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CityApp.Servies
{
    /// <summary>
    /// Хранилище городов
    /// </summary>
    public class CityStorage
	{
		private readonly List<City> _cities;

		public CityStorage()
		{
			_cities = new List<City>
			{
				new City("Москва","текст",16_000_000),
				new City("Санкт Петербург", "текст",5_000_000)
			};
		}

		/// <summary>
		/// Метод возвращает список всех городов
		/// </summary>
		public City[] GetAll()
		{
			return _cities.ToArray();
		}

        public City Get(Guid id)
        {
            return _cities.FirstOrDefault(city => city.Id == id);
        }

		/// <summary>
		/// Метод добавляет город в коллекцию 
		/// </summary>
		public void Create(City city)
		{

			_cities.Add(city);
		}

		public void Delete(Guid id)
		{
			_cities.Remove(_cities.First(city => city.Id == id));
		}

		public void Update(City city)
		{
			_cities.Remove(_cities.First(x => x.Id == city.Id));
			_cities.Add(city);
		}
	}
}
