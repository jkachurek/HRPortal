using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRPortal.Web.Models.Data;

namespace HRPortal.Web.Models.Repositories
{
    public class UserRepository
    {
        private static List<User> _users;

        static UserRepository()
        {
            _users = new List<User>
            {
                new User
                {
                    UserId = 1,
                    FirstName = "Rick",
                    LastName = "Sanchez",
                    Email = "rick@morty.com",
                    Phone = "555-555-5555",
                    Address = new Address
                    {
                        StreetAddress = "123 Sample St",
                        City = "Anytown",
                        State = "IN",
                        ZipCode = 23095
                    },
                    HireDate = new DateTime(2015, 10, 18),
                    TimeSheet = new List<TimeEntry>
                    {
                        new TimeEntry { EntryId = 1, Date = new DateTime(2015, 10, 18), HoursWorked = 8 },
                        new TimeEntry { EntryId = 2, Date = new DateTime(2015, 10, 25), HoursWorked = new decimal(6.75) },
                        new TimeEntry { EntryId = 3, Date = new DateTime(2015, 11, 17), HoursWorked = new decimal(3.14) }
                    }
                },
                new User
                {
                    UserId = 2,
                    FirstName = "Dennis",
                    LastName = "Reynolds",
                    Email = "dennis@paddys.com",
                    Phone = "888-123-4567",
                    Address = new Address
                    {
                        StreetAddress = "1372 Generic St",
                        City = "Philadelphia",
                        State = "PA",
                        ZipCode = 12345
                    },
                    HireDate = new DateTime(2015, 3, 19),
                    TimeSheet = new List<TimeEntry>
                    {
                        new TimeEntry { EntryId = 1, Date = new DateTime(2015, 3, 19), HoursWorked = 12 },
                        new TimeEntry { EntryId = 2, Date = new DateTime(2015, 4, 18), HoursWorked = 2 },
                        new TimeEntry { EntryId = 3, Date = new DateTime(2015, 2, 14), HoursWorked = new decimal(14.4)}
                    }
                },
                new User
                {
                    UserId = 3,
                    FirstName = "Philip",
                    LastName = "Fry",
                    Email = "fry@planetexpress.com",
                    Phone = "877-987-6543",
                    Address = new Address
                    {
                        StreetAddress = "1548 Random Rd",
                        City = "New New York",
                        State = "NY",
                        ZipCode = 17283
                    },
                    HireDate = new DateTime(2015, 1, 1),
                    TimeSheet = new List<TimeEntry>
                    {
                        new TimeEntry { EntryId = 1, Date = new DateTime(2015, 1, 1), HoursWorked = 4 },
                        new TimeEntry { EntryId = 2, Date = new DateTime(2015, 7, 4), HoursWorked = new decimal(7.04)},
                        new TimeEntry { EntryId = 3, Date = new DateTime(2015, 5, 25), HoursWorked = new decimal(3.5)}
                    }
                }
            };
        }

        public static User Get(int id)
        {
            return _users.FirstOrDefault(u => u.UserId == id);
        }

        public static IEnumerable<User> GetAll()
        {
            return _users;
        }

        public static void AddTimeEntry(TimeEntry entry)
        {
            var user = Get(entry.Employee.UserId);
            entry.EntryId = user.TimeSheet.Count == 0 ? 1 : user.TimeSheet.Max(x => x.EntryId) + 1;
            user.TimeSheet.Add(entry);
        }
    }
}