﻿
using MongoDB.Bson;

namespace Looks.Models {
    public class ProductSizeType: EntityBase {// like Front, Back,.... Addon
        public ObjectId ProductId { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
    }
}