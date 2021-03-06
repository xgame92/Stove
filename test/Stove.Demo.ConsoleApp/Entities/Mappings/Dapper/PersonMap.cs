﻿using DapperExtensions.Mapper;

namespace Stove.Demo.ConsoleApp.Entities.Mappings.Dapper
{
    public sealed class PersonMap : ClassMapper<Person>
    {
        public PersonMap()
        {
            Table("Persons");
            Map(x => x.Id).Key(KeyType.Identity);
            AutoMap();
        }
    }
}
