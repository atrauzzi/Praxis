﻿using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.AspNetCore.DataProtection.Repositories;

namespace Praxis.DataProtection
{
    public class NoXmlRepository : IXmlRepository
    {
        public void StoreElement(XElement element, string friendlyName)
        {
            // Newp.
        }

        IReadOnlyCollection<XElement> IXmlRepository.GetAllElements()
        {
            return new List<XElement>();
        }
    }
}
