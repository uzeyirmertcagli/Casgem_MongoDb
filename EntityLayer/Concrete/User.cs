﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class User
	{
        [BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("userName")]
        public string UserName { get; set; }

		[BsonElement("password")]
		public string Password { get; set; }
    }
}
