﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PRA_Project.Model
{
    public abstract class User : IComparable<User>
    {
        private readonly int id;

        public User(string firstName, string lastName, bool admin)
        {
            Id = id++;
            FirstName = firstName;
            LastName = lastName;
            Admin = admin;
        }

        public User() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public bool Admin { get; set; }

        public static bool isAdmin(string line) => bool.Parse(line.Split('|')[3]);
        
        public override string ToString() => $"{Id}|{FirstName}|{LastName}|{Admin}";

        public int CompareTo(User? other)
            => this.Id.CompareTo(other.Id);

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}