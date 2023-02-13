using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.Generator
{
    public abstract class NewsGenerator
    {
        //фабричный метод
        public abstract News GenerateNewsWithoutHeader();
        public abstract News GenerateNewsWithHeader();
    }
}
