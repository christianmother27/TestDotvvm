using System;
using System.Collections.Generic;
using DotVVM.Framework.Binding;
using DotVVM.Framework.Controls;
using DotVVM.Framework.Hosting;
using TestDotvvm.Model;

namespace TestDotvvm.Controls
{
    public class TestControl : DotvvmMarkupControl
    {
        public List<TestData> Data
        {
            get { return (List<TestData>)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }
        public static readonly DotvvmProperty DataProperty
            = DotvvmProperty.Register<List<TestData>, TestControl>(c => c.Data, null);

        protected override void OnInit(IDotvvmRequestContext context)
        {
            base.OnInit(context);

            // Add some test data
            List<TestData> data = new List<TestData>();
            data.Add(new TestData
            {
                ProjectName = "Project A",
                HoursAwarded = (decimal)100.0,
                HoursUsed = (decimal)24.5,
                HoursRemaining = (decimal)(100 - 24.5),
                Expiration = DateTime.Now.AddDays(15),
                Active = "Y"
            });
            data.Add(new TestData
            {
                ProjectName = "Project B",
                HoursAwarded = (decimal)11.0,
                HoursUsed = (decimal)0,
                HoursRemaining = (decimal)(11 - 0),
                Expiration = DateTime.Now.AddDays(27),
                Active = "Y"
            });
            data.Add(new TestData
            {
                ProjectName = "Project C",
                HoursAwarded = (decimal)1000.0,
                HoursUsed = (decimal)50.75,
                HoursRemaining = (decimal)(1000 - 50.75),
                Expiration = DateTime.Now.AddDays(100),
                Active = "N"
            });
            data.Add(new TestData
            {
                ProjectName = "Project D",
                HoursAwarded = (decimal)17.0,
                HoursUsed = (decimal)2,
                HoursRemaining = (decimal)(17 - 2),
                Expiration = DateTime.Now.AddDays(25),
                Active = "Y"
            });

            Data = data;
        }
    }
} 