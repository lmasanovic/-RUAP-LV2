﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using myApp.Models;

namespace myApp.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContacts()
        {
            return new Contact[]
        {
			new Contact
			{
				Id = 1,
				Name = "Glenn Block"
			},
			new Contact
			{
				Id = 2,
				Name = "Dan Roth"
			}
        };
        }
    }
}