﻿using System.Collections.Generic;
using Northwind.Core.EntityLayer;

namespace NorthwindApi.Responses
{
    public class ComposedShipperResponse : Response, IComposedShipperResponse
    {
        public ComposedShipperResponse()
        {

        }

        public IEnumerable<Shipper> Model { get; set; }
    }
}
