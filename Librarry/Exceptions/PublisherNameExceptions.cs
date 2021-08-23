﻿using Librarry.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Librarry.Exceptions
{
    public class PublisherNameExceptions
    {
        [Serializable]
        public class PublisherNameException : Exception
        {
            public string PublisherName { get; set; }

            public PublisherNameException()
            {

            }

            public PublisherNameException(string message) : base(message)
            {

            }

            public PublisherNameException(string message, Exception inner) : base(message, inner)
            {

            }

            public PublisherNameException(string message, string publisherName) : this(message)
            {
                PublisherName = publisherName;
            }
        }
    }
}
