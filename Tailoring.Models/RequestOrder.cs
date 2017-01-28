﻿using System;
using System.Collections.Generic;

namespace Looks.Models {
    public class RequestOrder: EntityBase {

        public RequestOrder() {
            this.Product = new Product();
            this.ProductOptions = new List<ProductOption>();
        }
        public int OrderNumber { get; set; }
        public Product Product { get; set; }
        public List<ProductOption> ProductOptions { get; set; }
        public string VisitAddress { get; set; }
        public string Instructions { get; set; }
        public RequestState State { get; set; }
        public TimeSlot TimeSlotId { get; set; }
        public Nullable<DateTime> ScheduleDate { get; set; }
        public Nullable<DateTime> DeliveryDate { get; set; }
        public int TotalAmount { get; set; }
        public int BaseAmount { get; set; }
        public int AddOnAmount { get; set; }
    }
}
