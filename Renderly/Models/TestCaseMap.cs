﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsvHelper;
using CsvHelper.TypeConversion;
using CsvHelper.Configuration;

namespace Renderly
{
    class TestCaseMap : CsvClassMap<TestCase>
    {
        public override void CreateMap()
        {
            Map(m => m.TestId).Name("Test Id");
            Map(m => m.Type).Name("Type");
            Map(m => m.SourceLocation).Name("Source Location");
            Map(m => m.ReferenceLocation).Name("Reference Location");
            Map(m => m.DateAdded).Name("Date Added");
            Map(m => m.DateModified).Name("Date Modified");
            Map(m => m.Release).Name("Release");
            Map(m => m.Description).Name("Description");
        }
    }
}
