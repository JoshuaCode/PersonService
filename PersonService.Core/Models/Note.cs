using System;
using System.Collections;
using System.Collections.Generic;

namespace PersonService.Core.Models
{
    public class Note : Entity
    {
        protected Note()
        {
        }
        public Note(Person creator, Place place, DateTime createdDateTime, string name, string id, string description)
        {
            Creator = creator;
            Place = place;
            CreatedDateTime = createdDateTime;
            Name = name;
            Id = id;
            Description = description;
        }

        public Person Creator { get; protected set; }
        public DateTime CreatedDateTime { get; protected set;}
        public Place Place { get; protected set;}
        public IEnumerable<Person> Participants { get; protected set; }
        public string NoteBody { get; protected set; }
        public string Description { get; protected set;}
        public string Id { get; protected set; }
        public string Name { get; protected set; }
    }
}
